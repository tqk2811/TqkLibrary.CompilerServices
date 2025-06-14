$key=$env:nugetKey
nuget pack .\TqkLibrary.CompilerServices.nuspec -Symbols -OutputDirectory .\TqkLibrary.CompilerServices\bin\Release
iex "nuget push .\TqkLibrary.CompilerServices\bin\Release\ -ApiKey $($key) -Source https://api.nuget.org/v3/index.json"