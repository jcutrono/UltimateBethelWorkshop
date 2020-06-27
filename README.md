# Ultimate Bethel Workshop
Object oriented programming and testing

## Presetup
* https://code.visualstudio.com/
* Extensions
1. C#
2. C# Extensions
3. C# FixFormat
4. C# FixFormat Fixed
* https://dotnet.microsoft.com/download

## Setup for Web
* https://www.mongodb.com/try/download/community
* https://robomongo.org/
* Optional (https://www.mongodb.com/products/vs-code)
* https://git-scm.com/downloads

## Create the repository
> Create your repo

## Create solution file
    dotnet new sln -o Bethel

## Pardon my OCD
> Move the solution file up to the root *UltimateBethelWorkshop* directory

## Create a new console app
    mkdir OOP-Console
    cd OOP-Console
    dotnet new OOP-Console
    cd ..
    dotnet sln add .\OOP-Console\OOP-Console.csproj

## Create a webapi project
    dotnet new webapi --no-https
    dotnet add package MongoDB.Driver --version 2.10.4

## Create a test project
    dotnet new xunit -o Covid.UnitTests
    dotnet add reference ..\..\CovidWeb\CovidWeb.csproj
    dotnet add package Moq