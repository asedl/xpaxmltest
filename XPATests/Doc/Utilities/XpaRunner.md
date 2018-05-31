# XpaRunner

XpaRunner is a little utility which can be used to start a Magic XPA Runtime or Magic XPA Studio in order to be able to prepare the environment before 
the Magic XPA Runtime / Engine takes over control. Sometimes there is a requirement to do this - esp. then if you need system / user specific 
settings available in your .INI for path diversion - before the application is actually started so that you could modify the settings from inside Magic.
Check following document for some more details: [altering-the-configuration-of-a-magic-application-before-its-actually-started](/XPATests/Doc/Installation/Magic.md#altering-the-configuration-of-a-magic-application-before-its-actually-started)  

_XpaRunner is implemented as a (C#) .NET application. A script or Java application is not a good option here because we need, in this specific case, an .exe or 
command file in order to be able to set the "Run As Administrator" flag for the executable file - because the Magic setup sets this flag for
MagicXpaRuntime.exe and MagicXpaStudio.exe as well. Trying to start these executables might fail with "requires escalation" system error._  

Which application XpaRunner actually should start you can specify by commandline parameters or a .settings file. Minimum requirement is to
specify the full pathname of the application (EXE), additionally you should specify the working directory (if different from application's 
location) and the command line parameters for the target application - if needed.  

## XpaRunner (renaming the application)
You can rename XpaRunner.exe to something more meaningful, like:
+ StartRuntime.exe
+ StartStudio.exe
+ MyApp.exe
+ InvoiceHandling.exe
+ ..

The only thing you have to ensure if you do this and work with .settings file(s). The application will use it's own name in order to find the 
.settings file which needs to reside in the same directory. So if you have a XpaRunner.settings file and you rename (copy) XpaRunner.Exe to
StartRuntime.exe you also need to rename/copy XpaRunner.settings -> StartRuntime.settings (or create a new file with that name).
  
## XpaRunner.settings
In this file you can persist settings for XpaRunner if you do not want to work with commandline parameters. The .settings file is a simple 
text file from where XpaRunner will read information. If you do additionally pass in one of the settings in that file via the command line, 
the command line parameter has priority resp. overwrites the setting from the file.  

## XpaRunner commandline parameters

Commandline parameters for XPaRunner (which you can use in batch programs, scripts or in target property of Windows shortcuts) follow Windows
conventions and can be prefixed with / (backslash) - (single hyphen). If you need one of these characters in a parameter 
you can enclose the whole parameter in double quotes to excluse it from parsing or escape it.

XpaRunner scans the command line from left to right and stops if it finds the first parameter which is none of those documented below,
a parameter for XpaRunner itself. The rest of the command line is considered as command line for the apllication XpaRunner should start and
is basically not evaluated anymore. Only exception: XpaRunner will scan the rest of the command line for parameters prefixes with an @ sign,
if it's in ENVEXPAND mode. It will have to remove these parameters and replace by modified version. See parameter ENVEXPAND for an explanation,

### command line samples
**XpaRunner.exe -ENVEXPAND -EXE=c:\magic\xpa\MgXpaRuntime.exe -PARAMETERS=@%ProgramData%\MyApp\Config\MyApp.Ini**  
_This will start a Magic XPA Runtime from your Magic XPA installation directory and set the working directory (since you did not specify resp. 
overwrite it) to "c:\magic\xpa" (which is required for Magic XPA anyways). There is only one command line parameter for the Magic Runtime:  
@%ProgramData%\MyApp\Config\MyApp.Ini . The Windows shell will expand %ProgramData% to what is configured for you, ntypically something like "C:\ProgramData". Parameter -ENVEXPAND 
is described further below._

### Parameter: EXE
Mandatory parameter which allows you to specify which application / command XpaRunner should actually start. You can leave aways the full path,
then the usual Windows rules for finding an application apply, Windows will search your PATH environment variable, ...  

### Parameter: PARAMETERS
Commandline parameters for the application you want to start. Optional because not all applications actually read the command line parameters. Besides: 
All command line parameters which are not for XpaRunner itself (and that's those which are not documented here) will be passed on to the application which 
gets started "as is".  

### Parameter: WORKINGDIR
Working directory setting for the application which gets started. If empty or missing XpaRunner will set the working directory ro the path
it has from the EXE parameter, then however you need to be sure that you specify a full pathname in EXE parameter. If you don't and WORKINGDIR
is empty too, Windows will set the working diretory to the directory where the executable which is started resides.

### Parameter: -ENVEXPAND
Only makes sense if one (or more of) the command line parameters for the target application (Magic XPA in our case) starts with an @ sign, 
which is interpreted to declare a "Magic @Merge .INI". 

If XpaRunner detects such a @Merge .INI **and -ENVEXPAND is set**, it will automatically "expand" all variables in the @INI which are surrounded 
with % signs by the value the system environment variable - if it finds an environment veaiable with that name. Efectively this means: Where
you now can only use Magic logical names in your .INI you now can use environment variables too. %HOMEDRIVE%%HOMEDIR% would be expanded to C:\ f.i. .  

An issue with this you would only get if there's Magic logical names and (system) environment variables with the same name. This case 
is currently not handled and there is no escape mechanism. Its about the @INIs only anyway. The Magic.INI with the rest of your settings
won't be touched by XPaRunner.  
  
If a @INI is modified by XpaRunner, XpaRunner works on a copy which it will create in user's temp directory. The original @INI will stay
as it is, it will however be removed from the command line parameters and will be replaced by the (changed) version from temp directory.
If XpaRunner is configured to wait for the process it started to terminate, it has a chance to delete that tempfile. If it will just 
spawn the process and then exit immediately, the file will stay in temp directory. You can use parameter / setting INIDIR to overwrite the output directory 
 to a drive / directory where you centralize these files. 
 
## Parameter: INIDIR
See remarks for parameter ENVEXPAND. With this setting you can overwrite the output folder for temporary @INI files, which by 
default go to the user's temp directory (%TEMP%)

## Parameter: WAIT
By default XpaRunner starts the target process from EXE parameter and terminates. By specifying -WAIT on the command line you can
advise XpaRunner to keep running and wait for the process it started to terminate. It then can remove temporary files it created and exit
too. Basically its possible to do some housekeeping now and check if the application XpaRunner started terminated "gracefully" or crashed.
That feature is however not yet implemented. There might be anpther parameter which allows to specify a command line for a "suffix process"

# Instance handling
"Instance handling" is a feature from a predecessor Version which did not make it into first version of XpaRunner. It helps when you 
have an application where the users tend to start multiple instances of your application and you want to identify these and need some 
(e.g.) "instance specific temp. directories". That requires some coordination of the running instances (since users can continue to 
to start instances and can terminate some while continue to work with others). Information about the instance you get as command line parameter and/or .INI setting and you can f.i. add this "id" to the title bar of your application - which is a surprising nice feature 
when you <alt><tab> fast between theb instances of your application ;).  

You can also use this feature to limit the maximum number of instances a user is allowed to create and if you set it to one, you 
effectively limited the number of possible instances to 1, which helps if multiple instances cause issues, as it is often the case for 
applications with a lot of I/O on lacal drives.

# Further Notes

Processes which XpaRunner creates are started with Process.Start method from System.Diagnostics

Samples for XpaRunner.settings files you will find in the XPATEST root directory:  
+ StartRuntime.settings
+ StartStudio.settings
+ XpaTest.settings
  

 
 







