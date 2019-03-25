## Analytic
Monitor the four key dimensions of video QoS: playback failures, startup time, rebuffering, and video quality. These 15 metrics help you track playback performance, so your team can know exactly what’s going on.
See details [here](https://docs.uiza.io/#analytic).

## Get Total Line
Get data grouped by hour (data refresh every 5 minutes). Track video playback on any metric performance, so you can know exactly what’s happening on every user’s device and debug more effectively.
See details [here](https://docs.uiza.io/#total-line).

```Cshard
using System;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;
using Uiza.Net.Services;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			UizaConfiguration.SetupUiza(new UizaConfigOptions
			{
				Authorization = "your-ApiKey",
				WorkspaceApiDomain = "your-workspace-api-domain.uiza.co"
			});

			var getTotalLine = UizaServices.Analytic.GetTotalLine(new AnalyticTotalLineParameter()
			{
				StartDate = @"2019-02-28 20:00",
				EndDate = @"2019-03-01 20:00",
				Metric = MetricType.RebufferCount
			});
			Console.WriteLine(string.Format("Get Total Line Success, total record {0}", getTotalLine.Data.Count));
			Console.ReadLine();
		}
		catch (UizaException ex)
		{              
			Console.WriteLine(ex.Message);
			Console.ReadLine();
		}
	}
}
```

## Get Type
Get data base on 4 type of filter: country, device, title, player
See details [here](https://docs.uiza.io/#type).

```Cshard
using System;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;
using Uiza.Net.Services;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			UizaConfiguration.SetupUiza(new UizaConfigOptions
			{
				Authorization = "your-ApiKey",
				WorkspaceApiDomain = "your-workspace-api-domain.uiza.co"
			});

			var getType = UizaServices.Analytic.GetType(new AnalyticTypeParameter()
			{
				StartDate = @"2019-01-01",
				EndDate = @"2019-03-01",
				TypeFilter = TypeFilter.Country
			});
			Console.WriteLine(string.Format("Get Type Success, total record {0}", getType.Data.Count));
			Console.ReadLine();
		}
		catch (UizaException ex)
		{              
			Console.WriteLine(ex.Message);
			Console.ReadLine();
		}
	}
}
```

## Get Line
Get data grouped by hour. Get total view in time range. This help you to draw a line chart to visualize data
See details [here](https://docs.uiza.io/#line).

```Cshard
using System;
using Uiza.Net.Configuration;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;
using Uiza.Net.Services;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			UizaConfiguration.SetupUiza(new UizaConfigOptions
			{
				Authorization = "your-ApiKey",
				WorkspaceApiDomain = "your-workspace-api-domain.uiza.co"
			});

			var getLine = UizaServices.Analytic.GetLine(new AnalyticLineParameter()
			{
				StartDate = @"2019-01-01",
				EndDate = @"2019-03-01",
				Type = LineType.RebufferCount
			});
			Console.WriteLine(string.Format("Get Line Success, total record {0}", getLine.Data.Count));
			Console.ReadLine();
		}
		catch (UizaException ex)
		{              
			Console.WriteLine(ex.Message);
			Console.ReadLine();
		}
	}
}
```

