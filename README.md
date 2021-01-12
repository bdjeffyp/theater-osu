# osu!theater

A customized [osu!](https://github.com/ppy/osu) game mode that resembles the Theatrhythm games by Square Enix/indieszero!

This is currently a work-in-progress and does nothing yet... Stay tuned!

## Prerequisites
You will need a copy of osu!laser built and run at least once. Visit the [osu!laser](https://github.com/ppy/osu) GitHub page for details on how to build that project.

## Installation
Since this is a work-in-progress, there is currently no release to install. Follow the Build directions below to compile the `osu.Game.Rulesets.Theater.dll` file.

**NOTE:** This mode is currently only supported in desktop mode. Mobile support is planned in the future.

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

You can run osu!laser with this game mode installed for you directly from the IDE! The `.csproj` file contains a post-build event script that always runs when the Debug (F5) or Run Without Debugging (Ctrl+F5) command is given in Visual Studio 2019. Running from the IDE will issue an error dialog stating that "A project with an Output Type of Class Library cannot be started directly" after closing osu!laser that can be safely ignored.

If you are not using Visual Studio 2019 or you feel inclined to, you can also run osu!laser with the osu!theater ruleset from the command line when you build this project with `dotnet build`.

**NOTE:** You will need to update the `osu.Game.Rulesets.Theater.csproj` file and modify the `<OsuDir>` environment variable with the build location of your instance of osu!laser for this to work.

## Contributions
All contributions are appreciated in order to improve the mode's playability and functionality. Contributions should be done over an issue or a pull request.

## License
`theater-osu` is licenced under the [MIT](https://opensource.org/licenses/MIT) License. For licensing information, refer to the [license file](https://github.com/bdjeffyp/theater-osu/blob/master/LICENSE).

The licensing here does not directly apply to [osu!](https://github.com/ppy/osu) as it is bound to its own licensing. What is reflected in our licensing *may* not be allowed in the [osu!](https://github.com/ppy/osu) github repository.