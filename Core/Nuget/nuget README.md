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
It doesn't work with .xproj file.  

D:\Programming\.Net works\monei\monei Core\Core\Nuget>nuget pack "..\Core.xproj.nuspec"
Error:  
MSBuild auto-detection: using msbuild version '14.0' from 'C:\Program Files (x86)\MSBuild\14.0\bin'.
Attempting to build package from 'Core.xproj.nuspec'.
The package ID '..\Core.xproj' contains invalid characters. Examples of valid package IDs include 'MyPackage' and 'MyPackage.Sample'.

## create a spec
:\>nuget spec [path to your project file]  

ex. nuget spec ..\MyProject.xproj  

## Package CreateNuGetPAckageAfterEachBuild
This create the NuGet package file in the "artifacts" folder.  
But it is not a valid package:
+ "Core" is not accepted for package ID (why?). I used "monei.Core".
+ Does it works without the Application property in Build "Produce output on build"?
