# XpaTPomo
XpaTPomo is a (quite ambitious) subproject / module / component of XPATests with the goal to add a framework for dependency injection and aspect oriented 
programming to Magic XPA.  

The term "POMO" is (in analogy to Java's POJO): "plain old magic object".  

Magic XPA is very limited when it comes to what is required here, "Reflection", the ability to analyze and modify programs/applications during 
Runtime but, at least, Sources are "XML" since a while so we can analyze and modify those in order to add some stuff by using "annotations".  

Until Magic v8 there was a "Magic control file API" which is, to some extend, exactly what we do need, that was however discontinued in some Magic 8.3 version. Part of the XpaTPomo project is therefore exactly that: A "Magic XPA control file API" based on the projects XML sources.  

