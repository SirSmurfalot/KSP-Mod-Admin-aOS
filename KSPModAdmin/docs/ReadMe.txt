﻿KSP Mod Admin aOS by Bastian Heinrich - A tool to manage the installation, update and removal of mods.

OK, no rocket science but it speed up the installation, updating or deinstallation of mods and so you will have more time to do rocket science :D.
It also let you choose what parts of the mod should be installed.


Features:
- KSP Version independent! (Until they changes mod loading again.)
- Localized: English, German, Russian, Italian, more are coming ... (contact me if you want to help)
- Multi OS support: Win, Linux and Mac (via Mono-Project (see http://www.mono-project.com/))
- Supports multiple installations of KSP. Change between different KSP installations with one click.
- Support of ZIP-, RAR- and 7ZIP- mod archives.
- Add mods or crafts with drag & drop, file selection or URL (Support of KSP Forum, Curse, CurseForge, KerbalStuff, GitHub and BitBucket urls).
- AVC Plugin version file detection.
- Auto detects install folder for the mod (if possible the mod will be installed to the GameData folder).
- Easy install destination control (for those cases the destination can't be auto detected).
- Choose what to include, just by hook or unhook parts of a mod.
- GameData scan for installed mods (they will be added to the mod selection if they aren't listed already).
- Read text files of a mod by double click the files.
- Update support:
  - for KSP Mod Admin.
  - for Mods (includes auto check for updates and auto install/update of outdated mods).
- Conflict detection and easy conflict solving for files that are referenced by more than one mod.
- Project code included! (VS2013 Solution - Language: C#)


Requirements:
- Windows:
  .Net 4.0 (Web installer included in download or see http://www.microsoft.com/en-us/download/details.aspx?id=17851)
- Linux & Mac:
  Mono - Linux install instructions http://www.mono-project.com/docs/getting-started/install/linux/
       - OSx install instructions http://www.mono-project.com/docs/about-mono/supported-platforms/osx/


Installation:
 Windows:
   - Install the .Net4.0 framework from Microsoft (Win7 or lower).
   - Just extract/copy the KSP Mod Admin folder from the zip to any location you want.
   - Start KSP Mod Admin ...
 Mac:
   - Install the Mono framework.
   - Just extract/copy the KSP Mod Admin folder from the zip to any location you want.
   - Start KSP Mod Admin via mono ...
 Linux:
   - Install the Mono framework. (by type "sudo apt-get install mono-complete" in your terminal)
   - Install Mozilla certificates. (by type "mozroots --sync --import" in your terminal)
   - Just extract/copy the KSP Mod Admin folder from the zip to any location you want.
   - Start KSP Mod Admin via mono ...


Special thanks to:
4o66, Gribbleshnibit8, HubertNNN, diomedea, SVlad, TheAlmightyOS, ... any many more!


License:
  - This project (KSP Mod Admin) is published under the CC BY-NC-SA 3.0 DE license (see http://de.creativecommons.org/was-ist-cc/).
    (With this license you are allowed to copy, change and redistribute this work, when 
     - you name me (write a mail to mackerbal@mactee.de to discuss details)
     - the redistribution is non commercial!
     - and your redistribution have the same license)

  - KSP Mod Admin uses several other open source projects with different licenses (a copy of most licenses could be found here KSPModAdmin\docs\Licenses\...):
    - TreeViewAdv
	  Project URL: http://www.codeproject.com/Articles/14741/Advanced-TreeView-for-NET
	  License: Berkeley Software Distribution License see KSPModAdmin/Docs/Licenses/TreeViewAdvLicense.txt for details.
	- CheckBoxComboBox
	  Project URL: http://www.codeproject.com/Articles/21085/CheckBox-ComboBox-Extending-the-ComboBox-Class-and
	  License: The Code Project Open License (CPOL) 1.02 (see http://www.codeproject.com/info/cpol10.aspx).
    - FolderSelectionDialog
	  Project URL: http://www.lyquidity.com/devblog/?p=136
	  License: There’s no license as such as you are free to take and do with the code what you will.
    - SharpCompress
	  Project URL: https://sharpcompress.codeplex.com/
	  License: Microsoft Public License (Ms-PL) (see http://sharpcompress.codeplex.com/license).
	- HtmlAgilityPack
	  Project URL: http://htmlagilitypack.codeplex.com/
	  License: Microsoft Public License (Ms-PL) (see http://htmlagilitypack.codeplex.com/license).
	- Newtonsoft.Json
	  Project URL: http://json.codeplex.com/
	  License: The MIT License (MIT) (see http://json.codeplex.com/license).
	