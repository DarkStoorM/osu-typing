# osu!typing

- [osu!typing](#osutyping)
  - [Licensing](#licensing)
  - [Overview](#overview)
  - [Building](#building)
  - [Loading Into osu](#loading-into-osu)
  - [Full Ruleset Description](#full-ruleset-description)
  - [Project Status](#project-status)

---

## Licensing

- This project is licensed under the same MIT licence as [osu!](https://github.com/ppy/osu)
- The standard [osu! licence](https://github.com/ppy/osu/blob/master/LICENCE) and copyright header are used throughout the source code, including my own code written specifically for this ruleset
- Some parts of the code are based on legacy rulesets and are therefore subject to the same licence
- Please refer to the [osu! README](https://github.com/ppy/osu/blob/master/README.md) for further information

---

## Overview

To make this **really short**, in this ruleset, you type random words to "approximately constant" WPM, based on the selected song's BPM.

_BPM_ dictates the difficulty, not the beatmap itself as its contents are replaced.

_**Please**_ refer to [this TL;DR](ABOUT.md#a-tldr-on-how-to-play-this) on how to use it in-game.

---

## Building

```bash
dotnet build -c Release .\osu.Game.Rulesets.Typing\
```

Or, grab the latest [release](https://github.com/DarkStoorM/osu-typing/releases).

> [!Note]
> Downloading a release with different version than your current osu! might not load the ruleset **if** there was an update to the internal Ruleset Version on lazer

---

## Loading Into osu

- Launch osu!
- ctrl/cmd + o (settings)
- Type: `folder`
- Click `Open osu! folder`
- Drop the `osu.Game.Rulesets.Typing.dll` into `rulesets` folder
- Restart osu!

![alt](https://github.com/user-attachments/assets/098d69f6-52db-4f7a-a61a-15f9e8c38b0a)

---

## Full Ruleset Description

The _actual_, full description of what even is this can be found in the [ABOUT](ABOUT.md) document.

> [!Warning]
> The above is an extremely long document, meant to explain almost everything in detail and to show some reasoning behind the features.

## Project Status

**This project is Feature-frozen / maintenance-only.**

I consider this ruleset complete for its intended purpose and will not be  actively developed. Pull requests and feature requests are not accepted. Compatibility updates for newer osu!lazer versions will be added when necessary.

Feel free to fork the project if you'd like to continue development

For more information, please refer to the [CONTRIBUTING](CONTRIBUTING.md) document.
