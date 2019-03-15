## Live Streaming
These APIs used to create and manage live streaming event.
* When a Live is not start : it's named as `Event`.
* When have an Event , you can start it : it's named as `Feed`.

See details [here](https://docs.uiza.io/#live-streaming).

## Create a live event
These APIs use to create a live streaming and manage the live streaming input (output).
A live stream can be set up and start later or start right after set up.
Live Channel Minutes counts when the event starts.

See details [here](https://docs.uiza.io/#create-a-live-event).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var createResult = UizaServices.Live.Create(new CreateLiveParameter()
{
	Name = Guid.NewGuid().ToString(),
	Mode = "push",
	Description = Guid.NewGuid().ToString(),
	Encode = EncodeTypes.Encode,
	Dvr = DvrTypes.ActiveFeatureRecord,
	LinkStream = new List<string>() { "https://playlist.m3u8" },
	Poster = "//image1.jpeg",
	Thumbnail = "//image1.jpeg",
	ResourceMode = ResourceModes.Single
});

Console.WriteLine(string.Format("Create Live Streaming Success New Id = {0}", createResult.Data.id));

```

## Retrieve a live event
Retrieves the details of an existing event.
You need only provide the unique identifier of event that was returned upon Live event creation.

See details [here](https://docs.uiza.io/#retrieve-a-live-event).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var retrieveResult = UizaServices.Live.Retrieve(new GetLiveParameter()
{
	Id = (string)createResult.Data.id
}
);
Console.WriteLine(string.Format("Get Category Id = {0} Success", retrieveResult.Data.id));
```

## Update a live event
Update the specific Live event by edit values of parameters.

See details [here](https://docs.uiza.io/#update-a-live-event).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var resultUpdate = UizaServices.Live.Update(new UpdateLiveParameter()
{
	Id = createResult.Data.id,
	Name = Guid.NewGuid().ToString(),
	Mode = "pull",
	Encode = EncodeTypes.Encode,
	Dvr = DvrTypes.ActiveFeatureRecord,
	ResourceMode = ResourceModes.Single
});

Console.WriteLine(string.Format("Update Category Id = {0} Success", resultUpdate.Data.id));
```

## Start a live feed
These API use to start a live event that has been create success.
The Live channel minute start count whenever the event start success

See details [here](https://docs.uiza.io/#start-a-live-feed).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var startLiveFeedResult = UizaServices.Live.StartFeed(new StartFeedParameter() { Id = (string)createResult.Data.id });
Console.WriteLine(string.Format("Start Live Feed Success", retrieveResult.Data.id));
```

## List all recorded files
Retrieves list of recorded file after streamed (only available when your live event has turned on Record feature)

See details [here](https://docs.uiza.io/#list-all-recorded-files).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var listResult = UizaServices.Live.ListRecorded((string)retrieveResult.Data.id);
Console.WriteLine(string.Format("Success Get List All Recorded Files, total record {0}", listResult.MetaData != null ? listResult.MetaData.total : 0));
```
API will return a blank array if don't have any Recorded Files and MetaData will be null.

## Get view of live feed
This API use to get a live view status . This view only show when event has been started and being processing.

See details [here](https://docs.uiza.io/#get-view-of-live-feed).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var getViewResult = UizaServices.Live.GetView((string)createResult.Data.id);
Console.WriteLine(string.Format("Get View Live Feed Success", getViewResult.Data.id));
```

## Stop a live feed
Stop live event.
See details [here](https://docs.uiza.io/#stop-a-live-feed).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var stopFeedResult = UizaServices.Live.StopFeed((string)createResult.Data.id);
Console.WriteLine(string.Format("Stop A Live Feed Success", stopFeedResult.Data.entityId));
```


## Convert into VOD
Convert recorded file into VOD entity. After converted, your file can be stream via Uiza's CDN..
See details [here](https://docs.uiza.io/#convert-into-vod).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var convertIntoVODResult = UizaServices.Live.ConvertToVOD((string)createResult.Data.id);
Console.WriteLine(string.Format("Convert VOD Success", convertIntoVODResult.Data.id));
```


## Delete a record file
Delete a recorded file.
See details [here](https://docs.uiza.io/#delete-a-record-file).
```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions	
{	
	ApiKey = "your-ApiKey",	
	ApiBase = "your-workspace-api-domain.uiza.co"	
});	
var deleteRecordFileResult = UizaServices.LiveStreaming.Delete((string)createResult.Data.id);	
Console.WriteLine(string.Format("Delete Live Feed Success", deleteRecordFileResult.Data.id));
```