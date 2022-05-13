# BlazoMirror README!

## Setup

1. Install .NET in the root over the pi user
1. Pull down the code into ~/BlazorMirror on your RaspberryPi from GitHub.
1. If you haven't already, sign up for the free AccuWeather API to get a key. Also find your location key using [this API endpoint](https://developer.accuweather.com/accuweather-locations-api/apis/get/locations/v1/cities/search0)
1. Create a appsettings.json file in wwwroot and fill out the values based on the following example:

   ```json
   {
     "AccuWeather": {
       "ApiKey": "OfV4VvAOkTAlMSA2wj5x1omBA",
       "LocationKey": "351193",
       "UseFakeData":  true,
       "EnableResponseLogging": false
     }
   }
   ```

1. Open a command prompt and run `sudo cp ~/BlazorMirror/Autostart/BlazorMirror.desktop /etc/xdg/autostart/BlazorMirror.desktop`

## Troubleshooting

- If you restart and now terminal window shows up to start the program, you probably didn't chmod the file for execution. Please review the setup steps.

## Attributions

Icons made by [Prosymbols](https://www.flaticon.com/authors/prosymbols) from [www.flaticon.com](https://www.flaticon.com/)
