rm /home/pi/BlazorMirror/InitScripts/nohop.out &
rm -r /home/pi/BlazorMirror/InitScripts/nohop &
nohup /home/pi/dotnet/dotnet run --project /home/pi/BlazorMirror/BlazorMirror.csproj &
sleep 15
sensible-browser http://localhost:5000 --start-fullscreen
