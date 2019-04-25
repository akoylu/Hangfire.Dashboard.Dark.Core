# Hangfire.Dashboard.Dark.Core
Shows Hangfire dashboard in a dark bluish theme

[![Build status](https://ci.appveyor.com/api/projects/status/m843wbqjis6qwan6?svg=true)](https://ci.appveyor.com/project/AhmetKoylu/hangfire-dashboard-dark-core)
[![NuGet](https://img.shields.io/nuget/v/Hangfire.Dashboard.Dark.Core.svg)](https://www.nuget.org/packages/Hangfire.Dashboard.Dark.Core/)

## Setup
In .NET Core's Startup.cs:
```c#
public void ConfigureServices(IServiceCollection services)
{
    services.AddHangfire(config =>
    {
        ...
        config.UseDarkDashboard();
    });
}
```
Otherwise,
```c#
GlobalConfiguration.Configuration
    ...
    .UseDarkDashboard();
```

## Screenshots

![dashboard](Screenshots/Screenshot1.png)
![dashboard](Screenshots/Screenshot2.png)
![dashboard](Screenshots/Screenshot3.png)
![dashboard](Screenshots/Screenshot4.png)
