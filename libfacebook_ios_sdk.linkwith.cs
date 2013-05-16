using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libfacebook_ios_sdk.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, "-ObjC -lsqlite3", ForceLoad = true, Frameworks = "CoreGraphics CoreLocation QuartzCore Security", WeakFrameworks = "Accounts AdSupport Social")]