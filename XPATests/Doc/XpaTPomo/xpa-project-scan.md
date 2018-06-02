# xpa-project-scan

xpa-project-scan is a Magic XPA component which is part of the Magic XPA POMO SDK.  

# Magic XPA Tools infrastructure
xpa-project-scan uses and supports the [Magic XPA Tools infrastructure](http://kb.magicsoftware.com/articles/bl_Reference/Tools-Infrastructure-xpa) . If you add following section to the .ini of any of your Magic XPA projects, you will get it as a menu-entry named "xpa-project-scan" in your Tool menu in XPA Studio.  

```Magic.ini
[TOOLS_MENU]
Compile=*A,xpa-project-scan,,+  
C:\magic\samples\xpaxmltest\XPATests\xpa-project-scan.ecf,,+  C:\magic\samples\xpaxmltest\XPATests\Scripts\xpa_tool\compile_pre.xpts,+  C:\magic\samples\xpaxmltest\XPATests\Scripts\xpa_tool\compile_post.xpts,+  
```
__the pathnames above you will have to adjust to your installation__


