# project that uses depednecy on another dll

This proj combines a bit more involved build.

## Structure

 - main proj : full build
    - Class library : compies class library into output directory "bin"
    - Our executable : compiles to exe that we run

In this proj we provide our SimpleProject a reference to dummy class library.
This reference is provided as a parameter to the c# compiler.

### main.csproj does following things (besides usual clean-up)
1. Compile class library to bin
2. Compile SimpleSolution.exe that references ClassLib.dll from "bin"
 - Notice!, that we have to compile ClassLib.csproj before we start compiling executable

Try runing SimpleProject.exe, adn see what happens