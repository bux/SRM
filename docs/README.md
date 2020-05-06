# SRM (Swifty Repo Manager)

SRM is a simple User Interface for managing multiple repositories for Swifty. The idea behind SRM is to have a single directory containing all mods and have them symlinked (or junction'ed) to an output folder that is served from a webserver.

## Using SRM

### Requirements

* swifty-cli from <https://getswifty.net/download>
* A folder where all mods are stored _(e.g. `C:\AllMyMods`)_
* A temporary folder where all generated repositories are first created in _(e.g. `C:\Temp\SwiftyRepos`)_
* A folder where the output of all repositories are stored in _(e.g. somewhere in "htdocs" for apache, or "wwwroot" for IIS e.g. `C:\inetpub\wwwroot\Repos`)_

### Configuration

When first starting SRM you should configure the settings. To do this click "Settings" in the menu. Adjust the paths to your need.

### Creating a new repository

* In the menu click on "File" &rarr; "New Profile".
* In the "Add Profile" dialog enter a name for the Profile (this is not the name of the repository)
* Confirm with "Ok".
* After the dialog has closed continue with filling out the required fields in the "Profile" panel.

| Field | Description |
|--|--|
| Repository Name _(required)_ | The name of the repository. This will be displayed in the swifty client |
| Target Path _(required)_ | The folder where the output of swity-cli will be copied to |
| Repo Image _(required)_ | An image file (PNG, e.g. 300x160 pixel) that will be displayed in the swifty client |
| Repo Icon _(required)_ | An image file (PNG, e.g. 32x32 pixel) that will be displayed in the swifty client |
| Server Name _(optional)_ | The name of your Arma 3 Server |
| Server Address _(optional)_ | The IP address of your Arma 3 Server |
| Server Port _(optional)_ | The Port of your Arma 3 Server |
| Server Password _(optional)_ | The password of your Arma 3 Server (if any) |
| Client Parameters _(optional)_ | [Arma 3 Startup Parameters](https://community.bistudio.com/wiki/Arma_3_Startup_Parameters) that a client should start with. Default `-noSplash -skipIntro -noPause` |
| BattleEye _(optional)_ | If your Arma 3 Server uses BattleEye |

* After filling out the required fields, choose the mods you want to have in your repository from the listbox below. Either as required mods or as optional mods. _(You can select multiple by just clicking with the left mouse button)_
* When you have finished your selection click on the "Save Profile" button
* Now you can click on "Create Repository" to let swifty-cli create the repository for you and have SRM create the junctions.

### Switching between multiple repositories

* In the menu click on "Prodiles" and select the desired profile.

### Create all repositories at once

* In the menu click on "Tools" &rarr; "Create all repositories".
    * This is useful, if you've updated a mod and want to recreate all repositories with the updated files.
