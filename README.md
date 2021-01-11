# osu!theater

A customized [osu!](https://github.com/ppy/osu) game mode that resembles the Theatrhythm games by Square/indieszero!

This is currently a work-in-progress and does nothing yet... Stay tuned!

## Installation
Since this is a work-in-progress, there is currently no release to install. Follow the Build directions below to compile the `osu.Game.Rulesets.Theater.dll` file.

Once built, open the osu! game folder. The best way to accomplish this is to start osu!, go to the settings menu, and find and click on the **Open osu! folder** button.

Copy the `osu.Game.Rulesets.Theater.dll` file into the `rulesets` directory. Overwrite any previous copy of the existing osu!theater ruleset.

Close and restart osu! if still open. The new game mode should appear under the Mode menu when you enter the song selection menu.

Note: This mode is currently only supported in desktop mode. Mobile support is planned in the future.

## Development
When developing or debugging the `theater-osu` codebase, a few prerequisites are required as following:
* An IDE that supports the C# language. Ideally, your IDE should support automatic code completion and syntax highlighting; examples of such being [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) and above or [JetBrains Rider](https://www.jetbrains.com/rider/).
* The [osu!framework](https://github.com/ppy/osu-framework/tree/master/osu.Framework), and [osu!](https://github.com/ppy/osu) codebases are added as dependencies for building.

### Source Code 
You are able to clone the repository over command line or by downloading it via GitHub's clone options above.

```sh
git clone https://github.com/bdjeffyp/theater-osu.git
cd theater-osu
```

Updating this code to the latest commit would be done with `git pull` inside the theater-osu directory or through your IDE's Git controls.

### Building the game mode
To build the osu!theater game mode, you will need to have the latest [.NET Core](https://dotnet.microsoft.com/download) installed on your computer.

First, open a terminal and navigate to wherever you have the osu!theater source code downloaded. Once you are in the root of the repository, enter the directory named `osu.Game.Rulesets.Theater`.

Next, run the command `dotnet build` and wait for the project to be built.

Once the project has finished building, `dotnet` should tell you where the binary was built to (usually `./tau/osu.Game.Rulesets.Theater/bin/Debug/netstandardx.x/`). Find the .dll binary in the given location and follow the installation instructions above.

## Contributions
All contributions are appreciated in order to improve the mode's playability and functionality. Contributions should be done over an issue or a pull request.

## License
`theater-osu` is licenced under the [MIT](https://opensource.org/licenses/MIT) License. For licensing information, refer to the [license file](https://github.com/bdjeffyp/theater-osu/blob/master/LICENSE).

The licensing here does not directly apply to [osu!](https://github.com/ppy/osu) as it is bound to its own licensing. What is reflected in our licensing *may* not be allowed in the [osu!](https://github.com/ppy/osu) github repository.