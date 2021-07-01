# ZedSharp

![Nuget Version Badge](https://img.shields.io/nuget/v/ZedSharp_John_singh?style=for-the-badge)

# Description
C#/.NET Standard API Wrapper for Zed.run. We currently support querying for horses, stable information, and race data. All of this info is currently publicly available through the Zed.run api without any API keys.

# Usage
All data can be retrieved through a specific client. We currently support three clients: Horse, Stable, and Race clients.

## HorseClient
    var client = new HorseClient();
    var horse = await client.GetHorseAsync(address);

### Result
This will return a [Horse model](https://github.com/wethegreenpeople/ZedSharp/blob/master/Models/Horse.cs)

## StableClient
    var client = new StableClient();
    var stable = await client.GetStableAsync(address);

### Result
This will return a list of [Horse models](https://github.com/wethegreenpeople/ZedSharp/blob/master/Models/Horse.cs)

## RaceClient
    var raceAmount = 10;
    var client = new RaceClient();
    var races = await client.GetLatestRaces(raceAmount);

### Result
This will return a [Race model](https://github.com/wethegreenpeople/ZedSharp/blob/master/Models/Race.cs)
