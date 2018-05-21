# Iron SDE

Iron SDE is a .NET library providing embedded data from the Eve Static Data Export. There are no database queries, API calls or JSON files to worry about: the data is encoded in plain old CLI code. This can make for quite fast (single digit microsecond) access times, and with direct data there's a much lesser need for caching. 

## What's included ##

[This is a partial conversion of the SDE](https://github.com/jameson2011/IronSde/wiki/SDE-coverage). Universe (regions, solar systems, celestials) & item types (groups, metagroups & market groups) are included in the library.

## Usage ##

Please refer to the [wiki](https://github.com/jameson2011/IronSde/wiki). Although IronSDE built & designed for F#, C# is fully interoperable.

## Roadmap ##

What's in store is in the [wiki](https://github.com/jameson2011/IronSde/wiki/Roadmap).

## Credits & Copyright ##

Although the software is copyright Jameson2011, IronSDE uses data from EVE Online, which is covered by a separate license from [CCP](https://www.ccpgames.com/). All data is copyright CCP hf.

## Builds

Builds are available from AppVeyor:
[![Build status](https://ci.appveyor.com/api/projects/status/ix2sqdn26dc7ro6l?svg=true)](https://ci.appveyor.com/project/jameson2011/ironsde)

Packages available from Nuget: 
[![Build status](https://img.shields.io/nuget/v/IronSde.svg)](https://www.nuget.org/packages/IronSde)