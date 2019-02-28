## Analytic
Monitor the four key dimensions of video QoS: playback failures, startup time, rebuffering, and video quality. These 15 metrics help you track playback performance, so your team can know exactly what’s going on.
See details [here](https://docs.uiza.io/#analytic).

## Get Total Line
Get data grouped by hour (data refresh every 5 minutes). Track video playback on any metric performance, so you can know exactly what’s happening on every user’s device and debug more effectively.
See details [here](https://docs.uiza.io/#total-line).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var getTotalLine = UizaServices.Analytic.GetTotalLine(new AnalyticTotalLineParameter()
{
    StartDate = @"2018-11-01 20:00",
    EndDate = @"2018-11-19 20:00",
    Metric = MetricType.RebufferCount
});
Console.WriteLine("Get Total Line Success");
```

## Get Type
Get data base on 4 type of filter: country, device, title, player
See details [here](https://docs.uiza.io/#type).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var getType = UizaServices.Analytic.GetType(new AnalyticTypeParameter()
{
    StartDate = @"2018-11-01 20:00",
    EndDate = @"2018-11-19 20:00",
    TypeFilter = MetricTypeFilter.Country
});
Console.WriteLine("Get Type  Total Line Success");
```

## Get Line
Get data grouped by hour. Get total view in time range. This help you to draw a line chart to visualize data
See details [here](https://docs.uiza.io/#line).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var getLine = UizaServices.Analytic.GetLine(new AnalyticLineParameter()
{
    StartDate = @"2018-11-01",
    EndDate = @"2018-11-19"
});
Console.WriteLine("Get Line Success");
```

