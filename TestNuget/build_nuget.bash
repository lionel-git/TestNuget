#!/bin/bash
#Test Nuget generation
dotnet clean -v n -c Release
dotnet build -v n -c Release --force
dotnet pack -v n -c Release --force -o ~/tmp/
