## Category
These below APIs used to take action with your media files (we called Category)
See details [here](https://docs.uiza.io/#category).

## Create Category
Create Category using full URL. Direct HTTP, FTP or AWS S3 link are acceptable.
See details [here](https://docs.uiza.io/#create-category.

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

			var result = UizaServices.Category.Create(new CreateCategoryParameter()
			{
				Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
				Type = CategoryTypes.Folder
			});

			Console.WriteLine(string.Format("Create New Category Id = {0} Success", result.Data.id));
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

## Retrieve Category
Get detail of Category including all information of Category.
See details [here](https://docs.uiza.io/#retrieve-an-Category).

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

			var result = UizaServices.Category.Retrieve("Category Id");
			
			Console.WriteLine(string.Format("Get Category Id = {0} Success", result.Data.id));
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
## List all Categories
Get list of Categories including all detail.
See details [here](https://docs.uiza.io/#retrieve-category-list).

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

			var listResult = UizaServices.Category.List();
			
			Console.WriteLine(string.Format("Get List Category Success, total record {0}", listResult.MetaData.result));
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

## Update Category
Update Category's information.
See details [here](https://docs.uiza.io/#update-an-Category).

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

			var result = UizaServices.Category.Update(new UpdateCategoryParameter()
			{
				Id = "Category Id",
				Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
				Type = CategoryTypes.PlayList
			});

			Console.WriteLine(string.Format("Update Category Id = {0} Success", result.Data.id));
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

## Create Category Relation
Create Category Relation, use for streaming
See details [here](https://docs.uiza.io/#create-category-relation).

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

			var result = UizaServices.Category.CreateRelation(new CategoryRelationParameter()
			{
				EntityId = "Entity id",
				MetadataIds = listMetadata
			});
			Console.WriteLine(string.Format("Create Category Relation Success, total record {0}", result.MetaData.result));
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
See Entity details [here](../docs/Entity.md).
## Delete category relation
Delete category relation, use for streaming
See details [here](https://docs.uiza.io/#delete-category-relation).

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

			var result = UizaServices.Category.DeleteRelation(new CategoryRelationParameter()
			{
				EntityId = "Entity Id",
				MetadataIds = listMetadata
			});
			Console.WriteLine(string.Format("Delete Category Relation Success, total record {0}", result.MetaData.result));
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

## Delete Category
Delete Category.
See details [here](https://docs.uiza.io/#delete-an-Category).

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

			var result = UizaServices.Category.Delete("Category Id");
			Console.WriteLine(string.Format("Delete Category Id = {0} Success", result.Data.id));
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