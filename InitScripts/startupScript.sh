rm /home/pi/nohop.out &
nohup /home/pi/dotnet/dotnet run --project /home/pi/BlazorMirror/BlazorMirror.csproj &> /home/pi/nohup.out &
sleep 15
sensible-browser http://localhost:5000 --start-fullscreen
