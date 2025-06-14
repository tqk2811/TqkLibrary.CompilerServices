$key=$env:nugetKey

Remove-Item -Recurse -Force .\bin\Release\** -ErrorAction SilentlyContinue;
nuget pack .\TqkLibrary.CompilerServices.nuspec -OutputDirectory .\bin\Release

Write-Host "enter to push nuget"
pause
Write-Host "enter to confirm"
pause

nuget push .\bin\Release\ -ApiKey $($key) -Source https://api.nuget.org/v3/index.json