# SRM

## Using SRM

### Requirements

* swifty-cli from <https://getswifty.net/download>
* A folder where all mods are stored
* A temporary folder where all generated repositories are first created in
* A folder where the output of all repositories are stored in (e.g. somewhere in "htdocs" for apache, or "wwwroot" for IIS)

### Configuration

When first starting SRM you should adjust the configuration to your needs. To do this click "Settings" in the menu. Adjust the paths to your need.

### Creating a new repository

* In the menu click on "File" &rarr; "New Profile".
* In the "Add Profile" dialog enter a name for the Profile (this is not the name of the repository)
* Confirm with "Ok".
* After the dialog has closed continue with filling out the required fields in the "Profile" panel.

| Field | Description |
|--|--|
| Target Path _(required)_ | The folder where the output of swity-cli will be copied to |
| Repo Image _(required)_ | An image file (PNG, 300x160 pixel) that will be displayed in the swifty client |
| Server Name _(optional)_ | The name of your Arma 3 Server |
| Server Address _(optional)_ | The IP address of your Arma 3 Server |
| Server Port _(optional)_ | The Port of your Arma 3 Server |
| Server Password _(optional)_ | The password of your Arma 3 Server if any |
| Client Parameters _(optional)_ | [Arma 3 Startup Parameters](https://community.bistudio.com/wiki/Arma_3_Startup_Parameters) that a client should start with. Default `-noSplash -skipIntro -noPause` |
| BattleEye _(optional)_ | If your Arma 3 Server uses BattleEye |

* After filling out the required fields, choose the mods you want to have in your repository from the listbox below
* You can select multiple by just clicking with the left mouse button
* When you have finished your selection click on the "Save Profile" button
* Now you can click on "Create Repository" to let swifty-cli create the repository for you and have SRM create the junctions.
