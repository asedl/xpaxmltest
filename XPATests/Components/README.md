## (Magic XPA) Components
This is the folder where we currently keep the sources of Magic XPA components. Each component resides in its own directory. Plan was also to put the compiled .ecf files of all the components here and point with %Components%XXX.ecf from the host applications to here, this does however raise issues.    

When a user starts the application by double-click on the .ecf (XPATest.ecf) logical name %Components% will be empty or not set correctly and the host will fail to load the component. If it's a component which is used before we can set %Components% Magic runtime will simply crash, with an indication in the mgerrorlog that it failed to read a component.  
  
Current workaround / solution: .ecf files of all components reside in the root directory where we also have the main application's .ecf and the path to the component in CRR then simply is .\XXX.ecf.

