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
1. Add a start up item to run the startupScript.sh. You only need to do this once. This find the exit 0 line in /etc/rc.local and adds a new line above it to run the startupScript.
    ```
    sed '/^exit 0/i \nohop sh ~/BlazorMirror/InitScripts/startupScript.sh &' /etc/rc.local 
    ```



# Attributions
Icons made by <a href="https://www.flaticon.com/authors/prosymbols" title="Prosymbols">Prosymbols</a> from <a href="https://www.flaticon.com/" title="Flaticon">www.flaticon.com</a>
