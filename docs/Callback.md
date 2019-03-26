## Callback
Callback used to retrieve an information for Uiza to your server, so you can have a trigger notice about an entity is upload completed and .
See details [here](https://docs.uiza.io/#callback).

## Create Callback
This API will allow you setup a callback to your server when an entity is completed for upload or public
See details [here](https://docs.uiza.io/#create-a-callback).

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

			var result = UizaServices.Callback.Create(new CreateCallbackParameter()
			{
				Url = "https://callback-url.uiza.co",
				Method = CallbackMethodTypes.Post
			});

			Console.WriteLine(string.Format("Create New Callback Id = {0} Success", result.Data.id));
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

## Retrieve a callback
Retrieves the details of an existing callback.
See details [here](https://docs.uiza.io/#retrieve-a-callback).

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

			var result = UizaServices.Callback.Retrieve("Callback Id");
			
			Console.WriteLine(string.Format("Get Callback Id = {0} Success", result.Data.id));
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

## Update a callback
This API will allow you setup a callback to your server when an entity is completed for upload or public
See details [here](https://docs.uiza.io/#update-a-callback).

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

			var result = UizaServices.Callback.Update(new UpdateCallbackParameter()
			{
				Id = "Callback Id",
				Url = "https://callback-url.uiza.co/update",
				Method = CallbackMethodTypes.Post
			});

			Console.WriteLine(string.Format("Update Callback Id = {0} Success", result.Data.id));
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

## Delete a callback
Delete an existing callback.
See details [here](https://docs.uiza.io/#delete-a-callback).

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

			var result = UizaServices.Callback.Delete("Callback Id");
			Console.WriteLine(string.Format("Delete Callback Id = {0} Success", result.Data.id));
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



