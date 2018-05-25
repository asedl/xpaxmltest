# XPATests Magic XPA 3.3 (SingleUser) demo project

Currently this project contains samples / demos for following usecases 

## Alternatives for Magic's built-in Http Functions (HttpCall, HttpGet, ..)
### Using a .NET (C#) script from command line to request a URL (Http GET)
Plan is to compile the script(s) to assemblies., that's however not yet done.
In order to get these samples running you need something which allows you to execute .NET scripts.
The Testprogram uses scriptcs, which you need to download and install in order to get these samples working
-> http://scriptcs.net/

### Using cURL to request a URL (Http Get)
Very complete implementation of HTTP (and other protocols) client.
In order to get this sample(s) working you need to download and install cURL for Windows.
Since it will run in its own process you can use both: The 64-Bit or 32-Bit version
-> https://curl.haxx.se/

### Using Apache Http component/core to request a URL from a Java library
### Using Magic HttpCall to request a URL with Magic native functionality
### Using a .NET (C#) inline code (snippet) to request a URL via Http GET from Magic

## MS Office stuff / Apache Poi
### Export XLS/SLSX to CSV via Magic & Apache Poi

## XSLT/XQUERY / Saxon HE
### Apply XSLT file on XML to do a transformation with XSLT

# Installation / Configuration
In order to be able to start the demo application(s) included in this package you do need to have Magic XPA 3.3 installed. If you not have this version you can download and install the free Magic XPA SingleUser edition of that development tool from <http://info.magicsoftware.com/Magic-xpa-Free-Single-User-Edition> (requires registration).

Next to this, there's no mandatory installations required. For specific samples / functionality you will however need to have additional software installed in order to be able to run those too (like a Java Runtime for the Java samples or .NET for the .NET samples, ... ). See further down for a list of additional / optional software.  
  
To open the sample project you do simply start your XPA 3.3 Studio and open the project file [XPATests.edp](/XPATests/XPATests.edp). Basically that's it, there's however a few adjustments to your .INI required which you can either do directly and manually in your Magic.INI (better a copy of it) or by adjusting the accompanying @ini XPATests.ini which you can (after adjustment of the pathnames there) put on the command line properties of the shortcut you do use to start your Studio  

The target property of your shortcut would look like following then:
"C:\Program Files (x86)\MSE\Magic XPA 3.3\MgxpaStudio.exe" @C:\Magic\Samples\XPATests\XPATests.INI

If Magic XPA cabinet files are associated with the Magic XPA 3.3 Runtime on your system you can also start the the demo application by a double click on [XPATests.ecf], the required .INI settings are missing then however definitely since your default Magic.ini will be used. You can however then start the Autocofiguration from Menu Help/About. Help/About does display you the required settings and tries to autoconfigure them if you advise to do so. The changes would be written back to your Magic .INI and should be available next time you start the Runtime (unless you work with a read-only .INI). See the decription of XPATests/Help/About for further details.




