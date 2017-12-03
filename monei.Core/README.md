# monei.Core

This library contains the entities and the business logic of the **monei** applications.
The library is based on .Net Framework.

## Dependencies 

- log4net

## NuGet

The project create a new NuGet package everytime is build in "Relase" configuration.
Post-build script:

    if "$(ConfigurationName)"=="Release" goto :package
    goto :exit

    :package
        del "$(SolutionDir)NuGet\*.nupkg"
        echo ## Create NuGet package (configuration: $(ConfigurationName))
        "$(SolutionDir)NuGet\nuget.exe"  pack "$(ProjectPath)" -Prop Configuration=Release -IncludeReferencedProjects -symbols  -outputdirectory "$(SolutionDir)NuGet"

    :exit
    pause

### Pre-release packages

To create a pre-release package use the "Create NuGet pre-release.bat" file.




## Entities

- Account
- Category
- Subcategory
- Currency
- Entry