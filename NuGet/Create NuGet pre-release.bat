@echo OFF

set suffix=alpha
set author="Alessandro Piccione"
set /p key=<NuGet_API_key.txt

:: Clean
del *.nupkg

:: Pack
nuget pack "..\monei.Core\monei.Core.csproj" -Properties Configuration=Release;authors=%author% -Suffix %suffix% -IncludeReferencedProjects 

echo.
echo ** NuGet package created **
echo.

:: Publish
set /p publish= "Publish to NuGet? (y/n): "

if "%publish%"=="y" (	
	nuget push *%suffix%.nupkg %key% -Source https://www.nuget.org/api/v2/package
	echo.
	echo ** NuGet package published **
	echo.
)
