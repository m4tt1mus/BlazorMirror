using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMirror.Feature.Weather
{
    public static class AccuWeatherResponses
    {
        public static string CurrentConditionsJsonResponse =
            @"
[
  {
    ""LocalObservationDateTime"": ""2020-11-18T19:43:00-06:00"",
    ""EpochTime"": 1605750180,
    ""WeatherText"": ""Clear"",
    ""WeatherIcon"": 33,
    ""HasPrecipitation"": false,
    ""PrecipitationType"": null,
    ""IsDayTime"": false,
    ""Temperature"": {
      ""Metric"": {
        ""Value"": 21.7,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 71,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""RealFeelTemperature"": {
      ""Metric"": {
        ""Value"": 20.5,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 69,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""RealFeelTemperatureShade"": {
      ""Metric"": {
        ""Value"": 20.5,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 69,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""RelativeHumidity"": 40,
    ""IndoorRelativeHumidity"": 40,
    ""DewPoint"": {
      ""Metric"": {
        ""Value"": 7.8,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 46,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""Wind"": {
      ""Direction"": {
        ""Degrees"": 135,
        ""Localized"": ""SE"",
        ""English"": ""SE""
      },
      ""Speed"": {
        ""Metric"": {
          ""Value"": 7.4,
          ""Unit"": ""km/h"",
          ""UnitType"": 7
        },
        ""Imperial"": {
          ""Value"": 4.6,
          ""Unit"": ""mi/h"",
          ""UnitType"": 9
        }
      }
    },
    ""WindGust"": {
      ""Speed"": {
        ""Metric"": {
          ""Value"": 9.2,
          ""Unit"": ""km/h"",
          ""UnitType"": 7
        },
        ""Imperial"": {
          ""Value"": 5.7,
          ""Unit"": ""mi/h"",
          ""UnitType"": 9
        }
      }
    },
    ""UVIndex"": 0,
    ""UVIndexText"": ""Low"",
    ""Visibility"": {
      ""Metric"": {
        ""Value"": 16.1,
        ""Unit"": ""km"",
        ""UnitType"": 6
      },
      ""Imperial"": {
        ""Value"": 10,
        ""Unit"": ""mi"",
        ""UnitType"": 2
      }
    },
    ""ObstructionsToVisibility"": """",
    ""CloudCover"": 0,
    ""Ceiling"": {
      ""Metric"": {
        ""Value"": 12139,
        ""Unit"": ""m"",
        ""UnitType"": 5
      },
      ""Imperial"": {
        ""Value"": 39827,
        ""Unit"": ""ft"",
        ""UnitType"": 0
      }
    },
    ""Pressure"": {
      ""Metric"": {
        ""Value"": 1025.7,
        ""Unit"": ""mb"",
        ""UnitType"": 14
      },
      ""Imperial"": {
        ""Value"": 30.29,
        ""Unit"": ""inHg"",
        ""UnitType"": 12
      }
    },
    ""PressureTendency"": {
      ""LocalizedText"": ""Rising"",
      ""Code"": ""R""
    },
    ""Past24HourTemperatureDeparture"": {
      ""Metric"": {
        ""Value"": 3.9,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 7,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""ApparentTemperature"": {
      ""Metric"": {
        ""Value"": 21.7,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 71,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""WindChillTemperature"": {
      ""Metric"": {
        ""Value"": 21.7,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 71,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""WetBulbTemperature"": {
      ""Metric"": {
        ""Value"": 13.7,
        ""Unit"": ""C"",
        ""UnitType"": 17
      },
      ""Imperial"": {
        ""Value"": 57,
        ""Unit"": ""F"",
        ""UnitType"": 18
      }
    },
    ""Precip1hr"": {
      ""Metric"": {
        ""Value"": 0,
        ""Unit"": ""mm"",
        ""UnitType"": 3
      },
      ""Imperial"": {
        ""Value"": 0,
        ""Unit"": ""in"",
        ""UnitType"": 1
      }
    },
    ""PrecipitationSummary"": {
      ""Precipitation"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""PastHour"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""Past3Hours"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""Past6Hours"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""Past9Hours"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""Past12Hours"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""Past18Hours"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      },
      ""Past24Hours"": {
        ""Metric"": {
          ""Value"": 0,
          ""Unit"": ""mm"",
          ""UnitType"": 3
        },
        ""Imperial"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        }
      }
    },
    ""TemperatureSummary"": {
      ""Past6HourRange"": {
        ""Minimum"": {
          ""Metric"": {
            ""Value"": 20.9,
            ""Unit"": ""C"",
            ""UnitType"": 17
          },
          ""Imperial"": {
            ""Value"": 70,
            ""Unit"": ""F"",
            ""UnitType"": 18
          }
        },
        ""Maximum"": {
          ""Metric"": {
            ""Value"": 27.2,
            ""Unit"": ""C"",
            ""UnitType"": 17
          },
          ""Imperial"": {
            ""Value"": 81,
            ""Unit"": ""F"",
            ""UnitType"": 18
          }
        }
      },
      ""Past12HourRange"": {
        ""Minimum"": {
          ""Metric"": {
            ""Value"": 6.1,
            ""Unit"": ""C"",
            ""UnitType"": 17
          },
          ""Imperial"": {
            ""Value"": 43,
            ""Unit"": ""F"",
            ""UnitType"": 18
          }
        },
        ""Maximum"": {
          ""Metric"": {
            ""Value"": 27.2,
            ""Unit"": ""C"",
            ""UnitType"": 17
          },
          ""Imperial"": {
            ""Value"": 81,
            ""Unit"": ""F"",
            ""UnitType"": 18
          }
        }
      },
      ""Past24HourRange"": {
        ""Minimum"": {
          ""Metric"": {
            ""Value"": 6.1,
            ""Unit"": ""C"",
            ""UnitType"": 17
          },
          ""Imperial"": {
            ""Value"": 43,
            ""Unit"": ""F"",
            ""UnitType"": 18
          }
        },
        ""Maximum"": {
          ""Metric"": {
            ""Value"": 27.2,
            ""Unit"": ""C"",
            ""UnitType"": 17
          },
          ""Imperial"": {
            ""Value"": 81,
            ""Unit"": ""F"",
            ""UnitType"": 18
          }
        }
      }
    },
    ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/current-weather/351193?lang=en-us"",
    ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/current-weather/351193?lang=en-us""
  }
]
            ";

        public static string FiveDayForecastJsonResponse =
            @"
{
  ""Headline"": {
    ""EffectiveDate"": ""2020-11-21T07:00:00-06:00"",
    ""EffectiveEpochDate"": 1605963600,
    ""Severity"": 5,
    ""Text"": ""Rain Saturday morning"",
    ""Category"": ""rain"",
    ""EndDate"": ""2020-11-21T13:00:00-06:00"",
    ""EndEpochDate"": 1605985200,
    ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/extended-weather-forecast/351193?lang=en-us"",
    ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?lang=en-us""
  },
  ""DailyForecasts"": [
    {
      ""Date"": ""2020-11-18T07:00:00-06:00"",
      ""EpochDate"": 1605704400,
      ""Sun"": {
        ""Rise"": ""2020-11-18T07:00:00-06:00"",
        ""EpochRise"": 1605704400,
        ""Set"": ""2020-11-18T17:33:00-06:00"",
        ""EpochSet"": 1605742380
      },
      ""Moon"": {
        ""Rise"": ""2020-11-18T10:44:00-06:00"",
        ""EpochRise"": 1605717840,
        ""Set"": ""2020-11-18T21:03:00-06:00"",
        ""EpochSet"": 1605754980,
        ""Phase"": ""WaxingCrescent"",
        ""Age"": 4
      },
      ""Temperature"": {
        ""Minimum"": {
          ""Value"": 56,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 80,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperature"": {
        ""Minimum"": {
          ""Value"": 58,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 79,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperatureShade"": {
        ""Minimum"": {
          ""Value"": 58,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 77,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""HoursOfSun"": 10.5,
      ""DegreeDaySummary"": {
        ""Heating"": {
          ""Value"": 0,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Cooling"": {
          ""Value"": 3,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""AirAndPollen"": [
        {
          ""Name"": ""AirQuality"",
          ""Value"": 60,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2,
          ""Unit"": ""Ozone""
        },
        {
          ""Name"": ""Grass"",
          ""Value"": 0,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Mold"",
          ""Value"": 3250,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Ragweed"",
          ""Value"": 5,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Tree"",
          ""Value"": 8,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""UVIndex"",
          ""Value"": 4,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2
        }
      ],
      ""Day"": {
        ""Icon"": 1,
        ""IconPhrase"": ""Sunny"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Pleasant with sunshine"",
        ""LongPhrase"": ""Pleasant with sunshine"",
        ""PrecipitationProbability"": 0,
        ""ThunderstormProbability"": 0,
        ""RainProbability"": 0,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 4.6,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 143,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 13.8,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 164,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 9
      },
      ""Night"": {
        ""Icon"": 36,
        ""IconPhrase"": ""Intermittent clouds"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Increasing cloudiness"",
        ""LongPhrase"": ""Mainly clear this evening followed by low clouds late"",
        ""PrecipitationProbability"": 0,
        ""ThunderstormProbability"": 0,
        ""RainProbability"": 0,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 3.5,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 160,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 9.2,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 166,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 57
      },
      ""Sources"": [
        ""AccuWeather""
      ],
      ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=1&lang=en-us"",
      ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=1&lang=en-us""
    },
    {
      ""Date"": ""2020-11-19T07:00:00-06:00"",
      ""EpochDate"": 1605790800,
      ""Sun"": {
        ""Rise"": ""2020-11-19T07:01:00-06:00"",
        ""EpochRise"": 1605790860,
        ""Set"": ""2020-11-19T17:32:00-06:00"",
        ""EpochSet"": 1605828720
      },
      ""Moon"": {
        ""Rise"": ""2020-11-19T11:40:00-06:00"",
        ""EpochRise"": 1605807600,
        ""Set"": ""2020-11-19T22:05:00-06:00"",
        ""EpochSet"": 1605845100,
        ""Phase"": ""WaxingCrescent"",
        ""Age"": 5
      },
      ""Temperature"": {
        ""Minimum"": {
          ""Value"": 60,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 80,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperature"": {
        ""Minimum"": {
          ""Value"": 63,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 80,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperatureShade"": {
        ""Minimum"": {
          ""Value"": 63,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 77,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""HoursOfSun"": 5.3,
      ""DegreeDaySummary"": {
        ""Heating"": {
          ""Value"": 0,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Cooling"": {
          ""Value"": 5,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""AirAndPollen"": [
        {
          ""Name"": ""AirQuality"",
          ""Value"": 75,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2,
          ""Unit"": ""Particle Pollution""
        },
        {
          ""Name"": ""Grass"",
          ""Value"": 0,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Mold"",
          ""Value"": 3250,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Ragweed"",
          ""Value"": 46,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2
        },
        {
          ""Name"": ""Tree"",
          ""Value"": 9,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""UVIndex"",
          ""Value"": 3,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2
        }
      ],
      ""Day"": {
        ""Icon"": 4,
        ""IconPhrase"": ""Intermittent clouds"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Low clouds, then sun and warm"",
        ""LongPhrase"": ""Low clouds followed by sunshine and warm"",
        ""PrecipitationProbability"": 1,
        ""ThunderstormProbability"": 0,
        ""RainProbability"": 1,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 4.6,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 163,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 10.4,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 181,
            ""Localized"": ""S"",
            ""English"": ""S""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 53
      },
      ""Night"": {
        ""Icon"": 38,
        ""IconPhrase"": ""Mostly cloudy"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Increasing cloudiness"",
        ""LongPhrase"": ""Partly cloudy in the evening followed by low clouds late"",
        ""PrecipitationProbability"": 2,
        ""ThunderstormProbability"": 1,
        ""RainProbability"": 2,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 2.3,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 173,
            ""Localized"": ""S"",
            ""English"": ""S""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 8.1,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 161,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 60
      },
      ""Sources"": [
        ""AccuWeather""
      ],
      ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=2&lang=en-us"",
      ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=2&lang=en-us""
    },
    {
      ""Date"": ""2020-11-20T07:00:00-06:00"",
      ""EpochDate"": 1605877200,
      ""Sun"": {
        ""Rise"": ""2020-11-20T07:01:00-06:00"",
        ""EpochRise"": 1605877260,
        ""Set"": ""2020-11-20T17:32:00-06:00"",
        ""EpochSet"": 1605915120
      },
      ""Moon"": {
        ""Rise"": ""2020-11-20T12:26:00-06:00"",
        ""EpochRise"": 1605896760,
        ""Set"": ""2020-11-20T23:06:00-06:00"",
        ""EpochSet"": 1605935160,
        ""Phase"": ""WaxingCrescent"",
        ""Age"": 6
      },
      ""Temperature"": {
        ""Minimum"": {
          ""Value"": 63,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 81,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperature"": {
        ""Minimum"": {
          ""Value"": 65,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 82,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperatureShade"": {
        ""Minimum"": {
          ""Value"": 65,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 79,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""HoursOfSun"": 4.9,
      ""DegreeDaySummary"": {
        ""Heating"": {
          ""Value"": 0,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Cooling"": {
          ""Value"": 7,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""AirAndPollen"": [
        {
          ""Name"": ""AirQuality"",
          ""Value"": 25,
          ""Category"": ""Good"",
          ""CategoryValue"": 1,
          ""Unit"": ""Ozone""
        },
        {
          ""Name"": ""Grass"",
          ""Value"": 0,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Mold"",
          ""Value"": 3250,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Ragweed"",
          ""Value"": 59,
          ""Category"": ""High"",
          ""CategoryValue"": 3
        },
        {
          ""Name"": ""Tree"",
          ""Value"": 9,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""UVIndex"",
          ""Value"": 4,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2
        }
      ],
      ""Day"": {
        ""Icon"": 4,
        ""IconPhrase"": ""Intermittent clouds"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Very warm with some sun"",
        ""LongPhrase"": ""Very warm with times of clouds and sun"",
        ""PrecipitationProbability"": 7,
        ""ThunderstormProbability"": 2,
        ""RainProbability"": 7,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 3.5,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 164,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 8.1,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 172,
            ""Localized"": ""S"",
            ""English"": ""S""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 60
      },
      ""Night"": {
        ""Icon"": 38,
        ""IconPhrase"": ""Mostly cloudy"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Turning cloudy and mild"",
        ""LongPhrase"": ""Turning cloudy and mild"",
        ""PrecipitationProbability"": 10,
        ""ThunderstormProbability"": 3,
        ""RainProbability"": 10,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 2.3,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 133,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 8.1,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 145,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 56
      },
      ""Sources"": [
        ""AccuWeather""
      ],
      ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=3&lang=en-us"",
      ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=3&lang=en-us""
    },
    {
      ""Date"": ""2020-11-21T07:00:00-06:00"",
      ""EpochDate"": 1605963600,
      ""Sun"": {
        ""Rise"": ""2020-11-21T07:02:00-06:00"",
        ""EpochRise"": 1605963720,
        ""Set"": ""2020-11-21T17:32:00-06:00"",
        ""EpochSet"": 1606001520
      },
      ""Moon"": {
        ""Rise"": ""2020-11-21T13:06:00-06:00"",
        ""EpochRise"": 1605985560,
        ""Set"": ""2020-11-22T00:05:00-06:00"",
        ""EpochSet"": 1606025100,
        ""Phase"": ""First"",
        ""Age"": 7
      },
      ""Temperature"": {
        ""Minimum"": {
          ""Value"": 64,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 78,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperature"": {
        ""Minimum"": {
          ""Value"": 61,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 79,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperatureShade"": {
        ""Minimum"": {
          ""Value"": 61,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 76,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""HoursOfSun"": 3.4,
      ""DegreeDaySummary"": {
        ""Heating"": {
          ""Value"": 0,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Cooling"": {
          ""Value"": 6,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""AirAndPollen"": [
        {
          ""Name"": ""AirQuality"",
          ""Value"": 25,
          ""Category"": ""Good"",
          ""CategoryValue"": 1,
          ""Unit"": ""Ozone""
        },
        {
          ""Name"": ""Grass"",
          ""Value"": 0,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Mold"",
          ""Value"": 4875,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Ragweed"",
          ""Value"": 52,
          ""Category"": ""High"",
          ""CategoryValue"": 3
        },
        {
          ""Name"": ""Tree"",
          ""Value"": 5,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""UVIndex"",
          ""Value"": 2,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        }
      ],
      ""Day"": {
        ""Icon"": 12,
        ""IconPhrase"": ""Showers"",
        ""HasPrecipitation"": true,
        ""PrecipitationType"": ""Rain"",
        ""PrecipitationIntensity"": ""Light"",
        ""ShortPhrase"": ""Rain and drizzle in the a.m."",
        ""LongPhrase"": ""Occasional morning rain and drizzle; otherwise, mostly cloudy and warm"",
        ""PrecipitationProbability"": 53,
        ""ThunderstormProbability"": 3,
        ""RainProbability"": 53,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 3.5,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 126,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 8.1,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 130,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0.03,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0.03,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 1.5,
        ""HoursOfRain"": 1.5,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 77
      },
      ""Night"": {
        ""Icon"": 38,
        ""IconPhrase"": ""Mostly cloudy"",
        ""HasPrecipitation"": true,
        ""PrecipitationType"": ""Rain"",
        ""PrecipitationIntensity"": ""Light"",
        ""ShortPhrase"": ""Some clouds, a shower late"",
        ""LongPhrase"": ""Partly to mostly cloudy and mild; a late-night shower in spots"",
        ""PrecipitationProbability"": 47,
        ""ThunderstormProbability"": 20,
        ""RainProbability"": 47,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 3.5,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 149,
            ""Localized"": ""SSE"",
            ""English"": ""SSE""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 10.4,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 140,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0.03,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0.03,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0.5,
        ""HoursOfRain"": 0.5,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 67
      },
      ""Sources"": [
        ""AccuWeather""
      ],
      ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=4&lang=en-us"",
      ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=4&lang=en-us""
    },
    {
      ""Date"": ""2020-11-22T07:00:00-06:00"",
      ""EpochDate"": 1606050000,
      ""Sun"": {
        ""Rise"": ""2020-11-22T07:03:00-06:00"",
        ""EpochRise"": 1606050180,
        ""Set"": ""2020-11-22T17:31:00-06:00"",
        ""EpochSet"": 1606087860
      },
      ""Moon"": {
        ""Rise"": ""2020-11-22T13:41:00-06:00"",
        ""EpochRise"": 1606074060,
        ""Set"": ""2020-11-23T01:02:00-06:00"",
        ""EpochSet"": 1606114920,
        ""Phase"": ""WaxingGibbous"",
        ""Age"": 8
      },
      ""Temperature"": {
        ""Minimum"": {
          ""Value"": 53,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 79,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperature"": {
        ""Minimum"": {
          ""Value"": 50,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 79,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""RealFeelTemperatureShade"": {
        ""Minimum"": {
          ""Value"": 50,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Maximum"": {
          ""Value"": 78,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""HoursOfSun"": 4,
      ""DegreeDaySummary"": {
        ""Heating"": {
          ""Value"": 0,
          ""Unit"": ""F"",
          ""UnitType"": 18
        },
        ""Cooling"": {
          ""Value"": 1,
          ""Unit"": ""F"",
          ""UnitType"": 18
        }
      },
      ""AirAndPollen"": [
        {
          ""Name"": ""AirQuality"",
          ""Value"": 34,
          ""Category"": ""Good"",
          ""CategoryValue"": 1,
          ""Unit"": ""Ozone""
        },
        {
          ""Name"": ""Grass"",
          ""Value"": 0,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""Mold"",
          ""Value"": 8044,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2
        },
        {
          ""Name"": ""Ragweed"",
          ""Value"": 23,
          ""Category"": ""Moderate"",
          ""CategoryValue"": 2
        },
        {
          ""Name"": ""Tree"",
          ""Value"": 1,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        },
        {
          ""Name"": ""UVIndex"",
          ""Value"": 2,
          ""Category"": ""Low"",
          ""CategoryValue"": 1
        }
      ],
      ""Day"": {
        ""Icon"": 12,
        ""IconPhrase"": ""Showers"",
        ""HasPrecipitation"": true,
        ""PrecipitationType"": ""Rain"",
        ""PrecipitationIntensity"": ""Light"",
        ""ShortPhrase"": ""A brief shower or two"",
        ""LongPhrase"": ""Mostly cloudy and remaining warm with a passing shower or two"",
        ""PrecipitationProbability"": 56,
        ""ThunderstormProbability"": 20,
        ""RainProbability"": 56,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 3.5,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 189,
            ""Localized"": ""S"",
            ""English"": ""S""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 11.5,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 141,
            ""Localized"": ""SE"",
            ""English"": ""SE""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0.06,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0.06,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 2,
        ""HoursOfRain"": 2,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 72
      },
      ""Night"": {
        ""Icon"": 38,
        ""IconPhrase"": ""Mostly cloudy"",
        ""HasPrecipitation"": false,
        ""ShortPhrase"": ""Mostly cloudy"",
        ""LongPhrase"": ""Mostly cloudy"",
        ""PrecipitationProbability"": 25,
        ""ThunderstormProbability"": 5,
        ""RainProbability"": 25,
        ""SnowProbability"": 0,
        ""IceProbability"": 0,
        ""Wind"": {
          ""Speed"": {
            ""Value"": 8.1,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 8,
            ""Localized"": ""N"",
            ""English"": ""N""
          }
        },
        ""WindGust"": {
          ""Speed"": {
            ""Value"": 13.8,
            ""Unit"": ""mi/h"",
            ""UnitType"": 9
          },
          ""Direction"": {
            ""Degrees"": 7,
            ""Localized"": ""N"",
            ""English"": ""N""
          }
        },
        ""TotalLiquid"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Rain"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Snow"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""Ice"": {
          ""Value"": 0,
          ""Unit"": ""in"",
          ""UnitType"": 1
        },
        ""HoursOfPrecipitation"": 0,
        ""HoursOfRain"": 0,
        ""HoursOfSnow"": 0,
        ""HoursOfIce"": 0,
        ""CloudCover"": 88
      },
      ""Sources"": [
        ""AccuWeather""
      ],
      ""MobileLink"": ""http://m.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=5&lang=en-us"",
      ""Link"": ""http://www.accuweather.com/en/us/austin-tx/78701/daily-weather-forecast/351193?day=5&lang=en-us""
    }
  ]
}

            ";
    }
}
