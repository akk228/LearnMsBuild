# Managing references

In this exercise I'm adding a reference to a project via nuget cli.
Since I use .net framework there are two things to consider:

1) We add references to nuget packages in in .csproj file vie refrence tag, not via PackageReference, like so

    ```xml
        <Reference Include="Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed, processorArchitecture=MSIL">
            <HintPath>packages\Newtonsoft.Json.13.0.3\lib\net45\Newtonsoft.Json.dll</HintPath>
        </Reference>
    ```
     - Here one important thing to consider is the "Include" attribute where we specify package
     - Another thing is the hintpath, that tells us where do we get the binary (.dll) for the package from.
     
2) we add packages.config file that nuget cli uses to restore packages.

# Execution steps on msbuild SimpleProj.csproj execution

1) in the .csproj file we add target `PackagesDirectory` that creates directory where we r  gonna restore out buget packages. Which runs before target that restores packages.
2) then the `RestorePackages` target is kicked off to download nuget packages that we need to use as our dependecies
    - Notice that it has to run before the target `PrepareForBuild` that is default msbuild target.
3) after running msbuild SimpleProj.csproj u can go to bin folder and execute SimpleProj.exe to see that it uses automapper.