@echo OFF

set author="Alessandro Piccione"
set /p key=<NuGet_API_key.txt

:: Clean
del *.nupkg

:: Pack
nuget pack "..\monei.Core\monei.Core.csproj" -Properties Configuration=Release;authors=%author% -IncludeReferencedProjects 

echo.
echo ** NuGet package created **
echo.

:: Publish

set publish=n
if "%1" == "publish" set publish=y

if "%publish%" neq "y" (
    set /p publish= "Publish to NuGet? (y/n): "
)


if "%publish%"=="y" (	
    nuget push *.nupkg %key% -Source https://www.nuget.org/api/v2/package
    echo.
    echo ** NuGet package published **
    echo.
)
