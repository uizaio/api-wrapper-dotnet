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
Console.WriteLine(string.Format("Success Get List Category, total record {0}", listResult.MetaData.result));
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

var deleteCategoryRelationResult = UizaServices.Category.DeleteCategoryRelation(new CategoryRelationParameter()
{
	EntityId = entity.Data.id,
	MetadataIds = listMetadata
});
Console.WriteLine(string.Format("Delete Success Category Relation, total record {0}", deleteCategoryRelationResult.MetaData.result));
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

var createCategoryRelationResult = UizaServices.Category.CreateCategoryRelation(new CategoryRelationParameter()
{
	EntityId = entity.Data.id,
	MetadataIds = listMetadata
});
Console.WriteLine(string.Format("Create Success Category Relation, total record {0}", createCategoryRelationResult.MetaData.result));
```

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

var deleteCategoryRelationResult = UizaServices.Category.DeleteCategoryRelation(new CategoryRelationParameter()
{
	EntityId = entity.Data.id,
	MetadataIds = listMetadata
});
Console.WriteLine(string.Format("Delete Success Category Relation, total record {0}", deleteCategoryRelationResult.MetaData.result));
```