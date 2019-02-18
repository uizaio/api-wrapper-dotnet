## Entity
These below APIs used to take action with your media files (we called Entity)
See details [here](https://docs.uiza.io/#video).

## Create entity
Create entity using full URL. Direct HTTP, FTP or AWS S3 link are acceptable.
See details [here](https://docs.uiza.io/#create-entity).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.Entity.Create(new CreateEntityParameter()
{
	Name = "Sample Video",
	InputType = EntityInputTypes.S3Uiza,
	URL = ""
});
Console.WriteLine(string.Format("Create New Entity Id = {0} Success", result.Data.id));
```

## Retrieve entity
Get detail of entity including all information of entity.
See details [here](https://docs.uiza.io/#retrieve-an-entity).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.Entity.Retrieve("Entity Id");
Console.WriteLine(string.Format("Get Entity Id = {0} Success", result.Data.id));
```
## List all entities
Get list of entities including all detail.
See details [here](https://docs.uiza.io/#list-all-entities).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result =  UizaServices.Entity.List(new RetrieveListEntitiesParameter() { publishToCdn = EntityPublishStatus.Success });
Console.WriteLine(string.Format("Success Get EntitiesList, total record {0}", result.MetaData.result));
```

## Update entity
Update entity's information.
See details [here](https://docs.uiza.io/#update-an-entity).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result =uizaServices.Entity.Update(new UpdateEntityParameter()
{
	Id = "Entity Id",
	Name = "Sample update",
	Description = "Description update",
	ShortDescription = "ShortDescription update",
	Poster = "/example.com/updatePoster",
	Thumbnail = "/example.com/updateThumbnail"
});
Console.WriteLine(string.Format("Update Entity Id = {0} Success", result.Data.id));
```

## Delete entity
Delete entity.
See details [here](https://docs.uiza.io/#delete-an-entity).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.Entity.Delete("Entity Id");
Console.WriteLine(string.Format("Create New Entity Id = {0} Success", result.Data.id));
```

## Search entity
Search entity base on keyword entered
See details [here](https://docs.uiza.io/#search-entity).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.Entity.SearchEntity("Sample");
  Console.WriteLine(string.Format("Search Success, , total record {0}", result.Data.Count));
```

## Publish entity to CDN
Publish entity to CDN, use for streaming
See details [here](https://docs.uiza.io/#publish-entity-to-cdn).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UUizaServices.Entity.PublishEntity("Entity Id");
Console.WriteLine(string.Format("Publish Entity Success : entityId = {0} ", result.Data.entityId));
```

## Get status publish
Publish entity to CDN, use for streaming
See details [here](https://docs.uiza.io/#get-status-publish).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result =  UizaServices.Entity.GetEntityStatusPublish("Entity Id");
Console.WriteLine(string.Format("Get Status Publish Success : temp_access_id = {0} ", result.Data.status));
```

## Get AWS upload key
This API will be return the bucket temporary upload storage & key for upload, so that you can push your file to Uiza’s storage and get the link for URL upload & create entity
See details [here](https://docs.uiza.io/#get-aws-upload-key).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result =  UizaServices.Entity.GetEntityAWSUploadKey();
Console.WriteLine(string.Format("Get AWS Upload Key Success : temp_access_id = {0} ", result.Data.temp_access_id));
```