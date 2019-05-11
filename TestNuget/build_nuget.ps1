# Test Nuget generation
dotnet.exe clean -v n -c Release
dotnet.exe build -v n -c Release --force
dotnet.exe pack -v n -c Release --force -o \\freebox\samsung\Nugets\
