# osu!typing

- [osu!typing](#osutyping)
  - [Licensing](#licensing)
  - [Overview](#overview)
  - [Building](#building)
  - [Loading Into osu](#loading-into-osu)
  - [Full Ruleset Description](#full-ruleset-description)

---

## Licensing

- This project is licensed under the same MIT licence as [osu!](https://github.com/ppy/osu)
- The standard [osu! licence](https://github.com/ppy/osu/blob/master/LICENCE) and copyright header are used throughout the source code, including my own code written specifically for this ruleset
- Some parts of the code are based on legacy rulesets and are therefore subject to the same licence
- Please refer to the [osu! README](https://github.com/ppy/osu/blob/master/README.md) for further information

---

## Overview

TBA

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

The *actual*, full description of what even is this can be found in the [ABOUT](ABOUT.md) document.
