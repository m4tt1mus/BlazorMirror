# Setup
1. Install .NET in the root over the pi user
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
1. Open a command prompt and run `crontab -e`. This will open the cronjobs configuration file for editing. On a blank line after the comments paste in `@reboot /home/pi/BlazorMirror/InitScripts/startupScript.sh`.


# Troubleshooting
+ If you restart and now terminal window shows up to start the program, you probably didn't chmod the file for execution. Please review the setup steps.
# Attributions
Icons made by <a href="https://www.flaticon.com/authors/prosymbols" title="Prosymbols">Prosymbols</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>
