# XpaCompile

XpaCompile is a command line "compiler" for Magic XPA projects. It uses the [Magic XPA tools infrastructure](http://kb.magicsoftware.com/articles/bl_Reference/Tools-Infrastructure-xpa) to create a Magic XPA cabinet file (*.ecf).  

# Usage / command line parameters
XpaCompile.exe -project=c:\magic\samples\xpaxmltest\xpatest\xpatest.edp

## Parameter: project
Allows you to specify a Magic XPA project file (.edp).

## Parameter: ecf
Allows you to specify the (full path-) name of the Magic XPA cabinet file which will be created as the result of the "compilation". This parameter is optional, if you leave it aways, name of the resulting .ecf file will be the name of the project file with extension .ecf.

