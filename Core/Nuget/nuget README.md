# NGet README

## Use NuGet

Create a batch file in the same folder where is nuget.exe:
nuget.exe
pause

## update nuget
:\> nuget update -self

## create a package
:\>nuget pack [path to your project file]

ex. nuget pack ..\myProgect.csproj
It doesn't work with .xproj file

## create a spec
:\>nuget spec [path to your project file]

ex. nuget spec ..\MyProject.xproj







