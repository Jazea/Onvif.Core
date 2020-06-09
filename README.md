# Onvif.Core

A lightweight ONVIF Discovery and Client library.

[![NuGet Badge](https://buildstats.info/nuget/Onvif.Core)](https://www.nuget.org/packages/Onvif.Core)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://raw.githubusercontent.com/chkr1011/MQTTnet/master/LICENSE)

## Examples

```csharp
var account = new Account("camera_ip", "camera_username", "camera_password");
var camera = Camera.Create(account, ex =>
{
    // exception
});

if (camera != null)
{
    //move...
    var vector1 = new PTZVector { PanTilt = new Vector2D { x = 0.5f } };
    var speed1 = new PTZSpeed { PanTilt = new Vector2D { x = 1f, y = 1f } };
    await camera.MoveAsync(MoveType.Absolute, vector1, speed1, 0);

    //zoom...
    var vector2 = new PTZVector { Zoom = new Vector1D { x = 1f } };
    var speed2 = new PTZSpeed { Zoom = new Vector1D { x = 1f } };
    await camera.MoveAsync(MoveType.Absolute, vector2, speed2, 0);

    //focus...
    //var focusMove = new FocusMove { Absolute=new AbsoluteFocus {   } };
    //await camera.FocusAsync(focusMove);
}

```
