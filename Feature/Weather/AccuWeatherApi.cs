using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace BlazorMirror.Feature.Weather
{
    public class AccuWeatherApi
    {
        public IConfiguration Configuration { get; set; }
        public HttpClient HttpClient { get; }
        public string LocationKey { get; set; }
        public string ApiKey { get; set; }
        public bool PullDataFromApi { get; set; } = true;
        public bool EnableResponseLogging { get; set; }

        public AccuWeatherApi(
            IConfiguration configuration,
            HttpClient httpClient)
        {
            Configuration = configuration;
            HttpClient = httpClient;

            PullDataFromApi = !Configuration.GetValue<bool>("AccuWeather:UseFakeData");
            ApiKey = Configuration.GetValue<string>("AccuWeather:ApiKey");
            LocationKey = Configuration.GetValue<string>("AccuWeather:LocationKey");
            EnableResponseLogging = Configuration.GetValue<bool>("AccuWeather:EnableResponseLogging");
        }

        public async Task<Conditions> GetCurrentConditions()
        {
            var rawStringResponse = AccuWeatherResponses.CurrentConditionsJsonResponse;
            if (PullDataFromApi)
            {
                var url = $"http://dataservice.accuweather.com/currentconditions/v1/{LocationKey}?apikey={ApiKey}&details=true";
                rawStringResponse = await HttpClient.GetStringAsync(url);
            }
            rawStringResponse = rawStringResponse.Trim().TrimStart('[').TrimEnd(']');
            var jsonResponse = JObject.Parse(rawStringResponse);
            if (EnableResponseLogging)
            {
                Console.WriteLine(jsonResponse);
            }

            var conditions = new Conditions();

            var dateString = jsonResponse["LocalObservationDateTime"]?.ToString();
            conditions.DateTime = Convert.ToDateTime(dateString);

            conditions.Description = jsonResponse["WeatherText"]?.ToString();
            conditions.DescriptionIconLocation = GetDescriptionIconLocation(conditions.Description);

            conditions.Temperature = new Temperature();
            conditions.Temperature.Value = Convert.ToDouble(jsonResponse["Temperature"]?["Imperial"]?["Value"]);
            conditions.Temperature.Unit = jsonResponse["Temperature"]?["Imperial"]?["Unit"]?.ToString();

            conditions.RelativeHumidity = jsonResponse["RelativeHumidity"]?.ToString();

            conditions.Wind = new Wind();
            conditions.Wind.Direction = jsonResponse["Wind"]?["Direction"]?["English"]?.ToString();
            conditions.Wind.Speed = Convert.ToDouble(jsonResponse["Wind"]?["Speed"]?["Imperial"]?["Value"]);
            conditions.Wind.SpeedUnit = jsonResponse["Wind"]?["Speed"]?["Imperial"]?["Unit"]?.ToString();

            conditions.Uv = new Uv();
            conditions.Uv.Index = Convert.ToInt32(jsonResponse["UVIndex"]);
            conditions.Uv.IndexDescription = jsonResponse["UVIndexText"]?.ToString();

            conditions.Visibility = new Visibility();
            conditions.Visibility.Distance = Convert.ToDouble(jsonResponse["Visibility"]?["Imperial"]?["Value"]);
            conditions.Visibility.DistanceUnit = jsonResponse["Visibility"]?["Imperial"]?["Unit"]?.ToString();

            return conditions;
        }

        private string GetDescriptionIconLocation(string conditionsDescription)
        {
            var iconDict = new Dictionary<string, string>()
            {
                {"sunny", "iconfinder_Sunny_3741356"},
                {"mostly sunny", "iconfinder_Sunny_3741356"},
                {"clear", "iconfinder_Sunny_3741356"},
                {"mostly clear", "iconfinder_Sunny_3741356"},

                {"partly sunny", "iconfinder_Partly_Cloudy_3741357"},
                {"intermittent clouds", "iconfinder_Partly_Cloudy_3741357"},
                {"hazy sunshine", "iconfinder_Partly_Cloudy_3741357"},
                {"partly cloudy", "iconfinder_Partly_Cloudy_3741357"},

                {"mostly cloudy", "iconfinder_Overcast_3741359"},
                {"cloudy", "iconfinder_Overcast_3741359"},
                {"dreary", "iconfinder_Overcast_3741359"},
                {"dreary (overcast)", "iconfinder_Overcast_3741359"},

                {"fog", "iconfinder_Foggy_3741362"},

                {"showers", "iconfinder_Moderate_Rain_3741351"},
                {"light rain", "iconfinder_Moderate_Rain_3741351"},
                {"mostly cloudy w/ showers", "iconfinder_Moderate_Rain_3741351"},
                {"partly sunny w/ showers", "iconfinder_Moderate_Rain_3741351"},
                {"rain", "iconfinder_Moderate_Rain_3741351"},
                {"partly cloudy w/ showers", "iconfinder_Moderate_Rain_3741351"},

                {"t-storms", "iconfinder_Thunder_3741360"},
                {"thunderstorms", "iconfinder_Thunder_3741360"},
                {"thunderstorm", "iconfinder_Thunder_3741360"},
                {"mostly cloudy w/ t-storms", "iconfinder_Thunder_3741360"},
                {"partly sunny w/ t-storms", "iconfinder_Thunder_3741360"},
                {"partly cloudy w/ t-storms", "iconfinder_Thunder_3741360"},

                {"flurries", "iconfinder_Snow_3741358"},
                {"mostly cloudy w/ flurries", "iconfinder_Snow_3741358"},
                {"partly sunny w/ flurries", "iconfinder_Snow_3741358"},
                {"snow", "iconfinder_Snow_3741358"},
                {"mostly cloudy w/ snow", "iconfinder_Snow_3741358"},

                {"ice", "iconfinder_Light_Rain_3741355"},
                {"sleet", "iconfinder_Light_Rain_3741355"},
                {"freezing rain", "iconfinder_Light_Rain_3741355"},
                {"rain and snow", "iconfinder_Light_Rain_3741355"},

                {"hot", "iconfinder_Thermometer_Hot_3741361"},

                {"cold", "iconfinder_Thermometer_Cold_3741365"},

                {"windy", "iconfinder_Windy_3741354"},

                {"hazy moonlight", "iconfinder_Cloudy_Night_3741352"},
            };
            var icon = iconDict[conditionsDescription.ToLower()];
            return $"/icons/weather-icons/{icon}.svg";
        }

        public async Task<DaysForecast[]> GetFiveDayForecast()
        {
            var fiveDay = new DaysForecast[5];
            var rawStringResponse = AccuWeatherResponses.FiveDayForecastJsonResponse;
            if (PullDataFromApi)
            {
                var url =
                    $"http://dataservice.accuweather.com/forecasts/v1/daily/5day/{LocationKey}?apikey={ApiKey}&details=true";
                rawStringResponse = await HttpClient.GetStringAsync(url);
            }

            rawStringResponse = rawStringResponse.Trim();
            var jsonResponse = JObject.Parse(rawStringResponse);
            if (EnableResponseLogging)
            {
                Console.WriteLine(jsonResponse);
            }

            for (int i = 0; i < fiveDay.Length; i++)
            {
                fiveDay[i] = new DaysForecast();

                var forecastDay = jsonResponse["DailyForecasts"]?[i]?["Date"]?.ToString();
                fiveDay[i].Day = Convert.ToDateTime(forecastDay);

                var sunrise = jsonResponse["DailyForecasts"]?[i]?["Sun"]?["Rise"]?.ToString();
                fiveDay[i].Sunrise = Convert.ToDateTime(sunrise);

                var sunset = jsonResponse["DailyForecasts"]?[i]?["Sun"]?["Set"]?.ToString();
                fiveDay[i].Sunset = Convert.ToDateTime(sunset);

                fiveDay[i].High = new Temperature();
                fiveDay[i].High.Value =
                    Convert.ToDouble(jsonResponse["DailyForecasts"]?[i]?["Temperature"]?["Maximum"]?["Value"]);
                fiveDay[i].High.Unit = jsonResponse["DailyForecasts"]?[i]?["Temperature"]?["Maximum"]?["Unit"]?.ToString();

                fiveDay[i].Low = new Temperature();
                fiveDay[i].Low.Value = Convert.ToDouble(jsonResponse["DailyForecasts"]?[i]?["Temperature"]?["Minimum"]?["Value"]);
                fiveDay[i].Low.Unit = jsonResponse["DailyForecasts"]?[i]?["Temperature"]?["Minimum"]?["Unit"]?.ToString();

                fiveDay[i].Description = jsonResponse["DailyForecasts"]?[i]?["Day"]?["IconPhrase"]?.ToString();
                fiveDay[i].DescriptionIconLocation = GetDescriptionIconLocation(fiveDay[i].Description);
            }

            return fiveDay;
        }
    }
}
