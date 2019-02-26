## Category
These below APIs used to take action with your media files (we called Category)
See details [here](https://docs.uiza.io/#category).

## Create Category
Create Category using full URL. Direct HTTP, FTP or AWS S3 link are acceptable.
See details [here](https://docs.uiza.io/#create-category.

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

 var createResult = UizaServices.Category.Create(new CreateCategoryParameter()
{
	Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
	Type = CategoryTypes.Folder
});

Console.WriteLine(string.Format("Create New Category Id = {0} Success", createResult.Data.id));
```

## Retrieve Category
Get detail of Category including all information of Category.
See details [here](https://docs.uiza.io/#retrieve-an-Category).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.Category.Retrieve("Category Id");
Console.WriteLine(string.Format("Get Category Id = {0} Success", result.Data.id));
```
## List all Categories
Get list of Categories including all detail.
See details [here](https://docs.uiza.io/#retrieve-category-list).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var listResult = UizaServices.Category.List(new BaseParameter());
Console.WriteLine(string.Format("Get List Category Success, total record {0}", listResult.MetaData.result));
```

## Update Category
Update Category's information.
See details [here](https://docs.uiza.io/#update-an-Category).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var resultUpdate = UizaServices.Category.Update(new UpdateCategoryParameter()
{
	Id = createResult.Data.id,
	Name = string.Format("Category name {0}", Guid.NewGuid().ToString()),
	Type = CategoryTypes.PlayList
});

Console.WriteLine(string.Format("Update Category Id = {0} Success", resultUpdate.Data.id));
```

## Create Category Relation
Create Category Relation, use for streaming
See details [here](https://docs.uiza.io/#create-category-relation).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var createCategoryRelationResult = UizaServices.Category.CreateRelation(new CategoryRelationParameter()
{
	EntityId = "Entity id",
	MetadataIds = listMetadata
});
Console.WriteLine(string.Format("Create Category Relation Success, total record {0}", createCategoryRelationResult.MetaData.result));
```
See Entity details [here](../docs/Entity.md).
## Delete category relation
Delete category relation, use for streaming
See details [here](https://docs.uiza.io/#delete-category-relation).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var deleteCategoryRelationResult = UizaServices.Category.DeleteRelation(new CategoryRelationParameter()
{
	EntityId = entity.Data.id,
	MetadataIds = listMetadata
});
Console.WriteLine(string.Format("Delete Category Relation Success, total record {0}", deleteCategoryRelationResult.MetaData.result));
```

## Delete Category
Delete Category.
See details [here](https://docs.uiza.io/#delete-an-Category).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var resultDelete = UizaServices.Category.Delete((string)createResult.Data.id);
Console.WriteLine(string.Format("Delete Category Id = {0} Success", resultUpdate.Data.id));
```