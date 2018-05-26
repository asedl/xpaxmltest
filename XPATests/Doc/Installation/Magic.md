# Getting information about the Magic runtime environemnt from inside a Magic application (project)

## How does XPATEST find the Magic installation it will use for shortcuts and (.ini) settings

There's not much need for a Magic application to know how it does get executed (by a Studio, by a Runtime, which version of that "Engine", ...). Autoconfiguration of a Magic application is however part of that Demo container and so it tries to get that information from inside the Magic application. There's several options.

### %EngineDir%

Thats's a logical name which Magic runtime injects during startup and which you can query from inside the application. It gives you the directory of the "Engine" used to start the application. Only problem with that: Magic renames the product quite often. How would you know what the .exe currently is named ? For XPA 3.3 it's "MgXPARuntime.Exe" and if you want tro create links/shortcuts, you could use following expression: Trim(Translate('%EngineDir%')) & 'MgXpaRuntime.exe".

### Commandline

In a Magic application you do not have access to the commandline, used to start the process so you cant read the first argument, which is by convention the name of the executable itself. MgXpaRuntime.exe in our case. There is a sample program in XPATEST which shows how to get the commandline, by using .NET Enviuronment and by using Windows API GetCommandlineW

### Registry

XPATEST will query the registry for a key named HKEY_CLASSES_ROOT\EDPFile\shell\command\open, the shell open command for .edp files, Magic XPA project files. On a machine where Magic has been installed with the Magic Setup program, this will point to the latest Magic version installed on that machine. XPATEST will extract the first command line argument (which points to the application) and found thereby the installation directory. In addition it will query the version properties of that file.

On a system where Magic was not installed from Installation media (Setup) this won't help and in the Magic world its quite common to simply copy an installation from one machine to another.

 
