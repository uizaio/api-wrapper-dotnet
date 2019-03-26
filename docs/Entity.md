## Entity
These below APIs used to take action with your media files (we called Entity)
See details [here](https://docs.uiza.io/#video).

## Create entity
Create entity using full URL. Direct HTTP, FTP or AWS S3 link are acceptable.
See details [here](https://docs.uiza.io/#create-entity).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result = UizaServices.Entity.Create(new CreateEntityParameter()
			{
				Name = "Sample Video",
				InputType = EntityInputTypes.S3Uiza,
				URL = ""
			});
			Console.WriteLine(string.Format("Create New Entity Id = {0} Success", result.Data.id));
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

## Retrieve entity
Get detail of entity including all information of entity.
See details [here](https://docs.uiza.io/#retrieve-an-entity).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result = UizaServices.Entity.Retrieve("Entity Id");
			
			Console.WriteLine(string.Format("Get Entity Id = {0} Success", result.Data.id));
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
## List all entities
Get list of entities including all detail.
See details [here](https://docs.uiza.io/#list-all-entities).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result =  UizaServices.Entity.List();
			
			Console.WriteLine(string.Format("Get Entity List Success, total record {0}", result.MetaData.result));
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

## Update entity
Update entity's information.
See details [here](https://docs.uiza.io/#update-an-entity).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
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

## Delete entity
Delete entity.
See details [here](https://docs.uiza.io/#delete-an-entity).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result = UizaServices.Entity.Delete("Entity Id");
			
			Console.WriteLine(string.Format("Delete Entity Id = {0} Success", result.Data.id));
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

## Search entity
Search entity base on keyword entered
See details [here](https://docs.uiza.io/#search-entity).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result = UizaServices.Entity.Search("Sample");
			
			Console.WriteLine(string.Format("Search Success, total record {0}", result.Data.Count));
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

## Publish entity to CDN
Publish entity to CDN, use for streaming
See details [here](https://docs.uiza.io/#publish-entity-to-cdn).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result = UUizaServices.Entity.Publish("Entity Id");
			
			Console.WriteLine(string.Format("Publish Entity Success : entityId = {0} ", result.Data.entityId));
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

## Get status publish
Publish entity to CDN, use for streaming
See details [here](https://docs.uiza.io/#get-status-publish).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result =  UizaServices.Entity.GetStatusPublish("Entity Id");
			
			Console.WriteLine(string.Format("Get Status Publish Success : temp_access_id = {0} ", result.Data.status));
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

## Get AWS upload key
This API will be return the bucket temporary upload storage & key for upload, so that you can push your file to Uiza’s storage and get the link for URL upload & create entity
See details [here](https://docs.uiza.io/#get-aws-upload-key).

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
				Authorization = "your-Authorization",
				AppId = "Your AppId"
			});
			
			var result =  UizaServices.Entity.GetAWSUploadKey();
			
			Console.WriteLine(string.Format("Get AWS Upload Key Success : temp_access_id = {0} ", result.Data.temp_access_id));
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