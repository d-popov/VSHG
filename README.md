# Mercurial Source Control Plugin for MS Visual Studio

A fork of VisualHG, which works with Visual Studio 2019 and Visual Studio 2017.

Don't forget to set your source control provider to VSHG after installation (Tools->Options--->Source Control->Plug-in Selection)

VSHG indicates file status within the project files tree of MSVC
Tracks adding, moving and renaming of file actions
Give you dialogs for committing changes, viewing detailed status of files and history and many more. Using TortoiseHG as its backend
Everything directly from your workspace via context menu and a toolbar
Support for Mercurial Subrepositories
Recogonize projects under version control that are not in the same folder as the solution
File status icon for renamed files
File state indicating tooltips
View per file branch label in file tooltip

### To learn more about Mercurial, TortoiseHG and VisualHG watch Rob Conery's excellent video tutorial

Contributions are most welcome! Contact me at VisualHG@Live.de.

To get started working with VisualHG is very simple.

### (Deinstall prev Version of VisualHG).
Download and install TortoiseHg and VisualHG. Or load from Visual Studio Extension Manager / Online Gallery.
Open Visual Studio and go to Tools -> Options.

In the options tree view, select Source Control. (You may need to click the Show all Settings checkbox)
Select VisualHG from the drop down list, and click OK.
Open your Mercurial based solution to see the plugin installed and determining your files' statuses.
