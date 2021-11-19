# Setup
1. Pull down the code into ~/BlazorMirror on your RaspberryPi from GitHub.
1. Create a appsettings.json file in wwwroot and fill out he values based on the following example:
    ```
    {
      "AccuWeather": {
        "ApiKey": "OfV4VvAOkTAlMSA2wj5x1omBA",
        "LocationKey": "351193",
        "UseFakeData":  true,
        "EnableResponseLogging": false
      }
    }
    ```
1. chmod the startup script to be executable.  Here is more info: https://askubuntu.com/questions/228304/how-do-i-run-a-script-at-start-up
    ```
    chmod +x ~/BlazorMirror/InitScripts/startupScript.sh
    ```




# Attributions
Icons made by <a href="https://www.flaticon.com/authors/prosymbols" title="Prosymbols">Prosymbols</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>
