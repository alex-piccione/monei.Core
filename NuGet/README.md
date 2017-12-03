# NuGet

## API key

The solution has a reference to the file NuGet/NuGet_API_key.txt that must be populated with the valid API key.
I'm using my personal API key so this file is not included in the repository.

## Docs

http://docs.nuget.org/ndocs/tools/nuget.exe-cli-reference#pack  
Call ```nuget pack``` on project file automatically load .nuspec file to use the templates (like $version$, $Author$)

-verbosity detailed
-symbols   (generate a .symbols.nupkg file)  
-outputdirectory "..\output"

## Problems

pack returns "WARNING: Author was not specified. Using '[user_name]."
https://github.com/NuGet/Home/issues/6246  
That happens only with Configuration=Release.



## Batch script

(I should use PowerShell)

````setlocal EnableDelayedExpansion````  could be necessary for some operations.

