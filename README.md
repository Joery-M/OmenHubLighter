# OMEN Hub Lighter

OMEN Hub Light is an opensource and lightweight substitute for a series programs from HP. It is based on the reverse engineering, and trying to keep a similar architecture to HP's programs for keeping update with HP.

OMEN Hub Lighter is an extension of OMEN Hub Light with extra functionality and a nicer UI.

## What this fork changes

- A quick UI for when Omen key is pressed
- Ability to set fans to max or turn them off
- Ability to remap the OMEN key to any other key (or hotkey)
- Ability to remap the OMEN key to execute programs
- Responds to trackpad lock key and Windows key lock
- Remove Four Zone Keyboard light (Maybe for in the future)
- An option to run on startup
- New enum values for fan control (Quiet mode wasn't working for me in the original version)
- Added fan speed text (Not sure how accurate it is)

![Fan control menu](<https://raw.githubusercontent.com/Joery-M/OmenHubLighter/master/README Images/Fan control.jpg>)
![Remap menu](<https://raw.githubusercontent.com/Joery-M/OmenHubLighter/master/README Images/remap.png>)

## Why I need it?

Tuning your computer fast when others are still launching OMEN Gaming Hub, without annoying HP product advertisements.

The goal is to replace or help you removing the following HP Apps:

- OMEN Gaming Hub (Previously "OMEN Command Center")
- HP System Event Utility
- HP Application Enabling Services (Software component driver)
  - HP Analytics services
  - HP App Helper HSA Service
  - HP Diagnostics HSA Service
  - HP Network HSA Service
  - HP System Info HSA Service
- Omen Software and Services (Software component driver)
  - HP Omen HSA Service

Also, you can avoid the "HP System Event Utility" pouring trashes to your `C:\system.sav`, and other components with various stacks of telemetry components.

## How to use it?

Since OMEN Gaming Hub is a huge project, determ1ne only implemented a small part of it which their notebook (OMEN 15-dc0xxx, i7-8750H with NVIDIA GTX 1060) needed. But I also added features for my notebook (Victus 16-d0xxx, i7-11800H with NVIDIA RTX 3060).

Currently, the application support the following feature:

- ~~Four Zone Keyboard Light~~ (Maybe in the future)
- Fan Control (For the models with only three options)

But if you want, you can easily port what you need, because the fundamental chores are available in a similar form to what HP programed in their applications. Happy hacking!

## Contributing

I was able to find most of what I need by decompiling `HP.Omen.Background.FanControlBg.dll` using [dotPeek](https://www.jetbrains.com/decompiler/) and then going to `HP.Omen.Core.Common.OmenHsaClient`.

**REQUIRES .NET 5 AND 6**

Build and run **OmenHubLighter** is enough. OmenDriverPatcher enables you to use LPC service from HP driver, whose client is provided in `NativeRpcClient.dll` from OMEN Gaming Hub or HP System Event Utility app package.