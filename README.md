# Magic XPA (SingleUser) demo project XPATests

This is a repository with a growing collection of Magic XPA demos / samples with a strong focus on the exotic stuff. If you do want demos / samples in order to actually learn "Magic" you should download and install (latest version) of Magic XPA and first have a look into the samples and demo applications which do ship with that (also exotic) development tool.

It's rather pricey and requires you to pay for runtime licenses later on, when you want to deploy your applications, too, there is however - since a while, at least a free "Single User" edition. That version lacks support of all the "enterprise features" and does support SQLite as datbase only. You can download that edition from following link (requires registration):  
<http://info.magicsoftware.com/Magic-xpa-Free-Single-User-Edition> . There's also a website from Magic Software which is exclusively about this special, free, version, of their development tool, its a bit old however and seems not maintained, many links do not work anymore there and the "Magic DevNet" has basically been discontinued as it looks: http://homeedition.magicsoftware.com/

The IDE (aka: "Magic XPA Studio") is only available for Microsoft Windows. The applications you do build with Magic XPA do then run on some different systems / platforms too and if you keep it "Single User" you can also deploy your applications for free and do not have to purchase runtime licenses from the vendor. Its interesting technology, esp. the RIA things and quite different from everything else in that area but maybe worth a look. It's rather "B2B" though.

# Installation / Configuration
  
In order to be able to start the demo application(s) included in this package you do need to have Magic XPA 3.3 installed. If you do not have this version you can download and install the free Magic XPA SingleUser edition of that development tool from the link above. Next to this, there's no mandatory installations required. For specific samples / functionality you will however need to have additional software installed in order to be able to run those too (like a Java Runtime for the Java samples, ...). Those requirements are mentioned where needed.  
  
To open the sample project you do simply start your XPA 3.3 Studio and open the project file [XPATests.edp](/XPATests/XPATests.edp). Basically that's it, there's however a few adjustments to your .INI required which you can either do directly and manually in your Magic.INI (better a copy of it) or by adjusting the accompanying @ini [XPATests.ini](/XPATests/XPATests.ini) and put that on the command line properties of the shortcut you do use to start your Studio / Runtime. In Help Menu there's also an entry which does this for you. It generates the required .INI file and creates shortcuts to start Studio and Runtime - in your installation folder.  
  
One goal of this project is to get a framework / container application for demo programs which allows you to download and start an application developed with Magic without much need for an installation or a complicated configuration. Thanks to the %WorkingDir% variable which Magic injects during startup that's trivial for simple applications but when you start to add components to your application (may be Magic components or 3'rd party) things might get complicated - you either need a setup / deploy script or try to configure the application automatically during startup. There's separate documents for these issues, be sure to check the folder for those too if you run into issues: https://github.com/asedl/xpaxmltest/tree/master/XPATests/Doc/Installation
  

# Content

Currently this project contains following top-level samples / demos / modules, maybe only stubs with not much implemented yet: 

| Demo / Subproject    | Brief description
| -------------------- | ----------------- |
| XpaTest | Goal is basically a small Framework for more complex Magic applications which does autoconfigure itself |
| XpaTHttp | https://github.com/asedl/xpaxmltest/tree/master/XPATests/Doc |
| XpaTOffice | There's some samples which do use functionality from Apache POI for MS Office stuff like converting Excel -> CSV for an easy import into Magic without the requirement to have MS Office actally be installed |
| XpaTXML | There's some samples which do demo "advanced" XML technics, like XSL/XSLT/XQuery for reformatting of existing XML to whatever or extracting information from there with standard query languages |  
XpaTPomo | "POMO" is a new term invented for this project in analogy to Java POJOs, a "plain old Magic object". Goal is to get a (compile time) framework for Magic XPA applications in order to enable dependency injection and aspect oriented programming |
| XpaTHelp | Component which can be added to Magic programs to integrate/implement an online help system |
  
some more stuff is in the pipeline. Initial versions not yet commited to this repository.

| Demo / Subproject    | Brief description
| -------------------- | ----------------- |
| XpaTBuild | Maven multi-module project + required stuff to get a Magic application (or parts of it) deployed with standard build systems / continouus delivery piplines / Jenkins / .... |

