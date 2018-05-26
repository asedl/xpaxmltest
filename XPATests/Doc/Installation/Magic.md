## How does XPATEST find the Magic installation it will use for shortcuts and (.ini) settings

XPATEST will query the registry for a key named HKEY_CLASSES_ROOT\EDPFile\shell, the shell open coammand for .edp files, Magic XPA project files. On a machine where Magic has been installed with the Magic Setup program, this will point to the latest Magic version installed on that machine. XPATEST will extract the first command line argument (which points to the application) and found thereby the installation directory. In addition it will query the version properties of that file.

On a system where Magic was not installed from Installation media (Setup) this won't help and in the Magic world its quite common to simply copy an installation from one machine to another.

 