## Storage
You can add your storage (FTP, AWS S3) with UIZA. After synced, you can select your content easier from your storage to create entity.
See details [here](https://docs.uiza.io/#storage).

## Add a storage
You can sync your storage (FTP, AWS S3) with UIZA. After synced, you can select your content easier from your storage to create entity.
See details [here](https://docs.uiza.io/#add-a-storage).

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
			
			var result = UizaServices.Storage.Add(new AddStorageParameter()
			{
				Name = "FTP Uiza",
				Host = "ftp-example.uiza.io",
				Description = "FTP of Uiza, use for transcode",
				StorageType = StorageInputTypes.Ftp,
				UserName = "uiza",
				Password = "=59x@LPsd+w7qW",
				Port = 21
			});
			
			Console.WriteLine(string.Format("Add New Storage Id = {0} Success", createResult.Data.id));
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

## Retrieve a storage
Get information of your added storage (FTP or AWS S3)
See details [here](https://docs.uiza.io/#retrieve-a-storage).

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
			
			var result = UizaServices.Storage.Retrieve("Storage Id");
			
			Console.WriteLine(string.Format("Get Storage Id = {0} Success", result.Data.id));
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

## Update storage
Update storage's information
See details [here](https://docs.uiza.io/#update-storage).

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
			
			var result = UizaServices.Storage.Update(new UpdateStorageParameter()
			{
				Id = "Storage Id",
				Name = "FTP Uiza Update",
				Host = "ftp-example.uiza.io",
				Description = "FTP of Uiza, use for transcode Update",
				StorageType = StorageInputTypes.S3,
				UserName = "uizaUpdate",
				Password = "=59x@LPsd+w7qW",
				Port = 22
			});
			Console.WriteLine(string.Format("Update Storage Id = {0} Success", result.Data.id));
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

## Remove storage
Remove storage that added to Uiza
See details [here](https://docs.uiza.io/#remove-storage).

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
			
			var result = UizaServices.Storage.Remove("Storage Id");
			
			Console.WriteLine(string.Format("Remove Storage Id = {0} Success", result.Data.id));
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

