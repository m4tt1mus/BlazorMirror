rm ~/BlazorMirror/InitScripts/nohop.out &
rm -r ~/BlazorMirror/InitScripts/nohop &
nohup dotnet run --project ~/BlazorMirror/BlazorMirror.csproj &
sleep 15
sensible-browser http://localhost:5000 --start-fullscreen
