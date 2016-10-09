
@echo OFF
rem http://docs.nuget.org/ndocs/tools/nuget.exe-cli-reference#pack
rem call nuget pack on project file automatically load .nuspec file to use the templates ($version$)

rem NuGet does not work with xproj files

nuget pack "..\monei.Core\monei.Core.csproj" -Prop Configuration=Release -IncludeReferencedProjects -symbols 
rem -outputdirectory "..\output"

echo "NuGet package created"