# Getting the Java samples working ...

Java raises some installation / configuration issues when you decide to leverage the "Magic & Java" functionality of Magic XPA, which saw quite some rework in Magic XPA 3.3 btw.  
  
One of the major reasons for that is: Magic is quite picky regarding the Java versions it supports and also requires a 32-Bit Java VM. On today's desktop systems you do however rather find: Latest version of Java Runtime (JRE), 64 Bit (which currently would expand to 64-Bit-Java v8 for Windows). Magic XPA 3.3 requires 32-Bit-Java for Windows, support for Java 7 has been added (asfaik) to XPA 2.5. Versions before do require Java 6 and cannot work with a later Java version.

On a development system a JRE is not sufficient too, you will need a JDK. A JDK you will also need in order to get some of the "enterprise functionality" of XPA running but that we do not cover in a demo project for the SingleUser edition anyways. Related to this is also Magic development for Mobile (Android), since the Android SDK which is required then to be installed is Java based.

Fortunately the vendor (Magic Software) knows that they are always a few years behind when it comes to the Java versions they do support and added Java settings to the configuration file ("Magic.ini") which allows us to specify which Java VM will be used by Magic XPA in order to execute our Java stuff. During installation/configuration we just have to check if we find a Java 8 32-Bit on the system and modify the .INI settings accordingly. 

Currently this feature is however missing in the demo, you have to adjust the .INI of the application manually. 
  
[MAGIC_JAVA]  
JAVA_HOME=*C:\Java\jdk1.8.x86  
CLASSPATH=*.;Support\*;Libraries\*;C:\magic\samples\xpaxmltest\XPATests\ext+  
ernal\Java\XPATest\target\XPATest-0.0.1-SNAPSHOT-jar-with-dependencies.jar

