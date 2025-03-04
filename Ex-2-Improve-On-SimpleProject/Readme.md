# Ex 2

Here we extend build process from ex-1 by adding some intermediate steps, like 
1) creating directory for the output
2) doing clean up before compiling 
3) introducing dependecies between targets
4) using proprty groups to specify project parameters

# Playground

## default call to msbuild
1) try running 'msbuild /v:d main.proj'
you'll see that a build direcotry was created, and SimpleProject.exe appeared there.

That happens becasue project file is created with DefaultTargets="Compile", try deleting DefaultTargets from Project props and see what happens

2) try running a target for clean up alone 'msbuild main.proj -t:Clean