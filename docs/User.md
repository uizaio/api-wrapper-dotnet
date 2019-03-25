## User
You can manage user with APIs user. Uiza have 2 levels of user

Admin - This account will have the highest priority, can have permission to create & manage users.

User - This account level is under Admin level. It only manages APIs that relates to this account.

See details [here](https://docs.uiza.io/?#user-management).

## Create an user
Create an user account for workspace
See details [here](https://docs.uiza.io/?#create-an-user).

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

			var result = UizaServices.User.Create(new CreatUserParameter()
			{
				Status = UserStatus.Active,
				UserName = Guid.NewGuid().ToString(),
				Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
				PassWord = curentPW,
				FullName = Guid.NewGuid().ToString(),
				Avatar = "https://static.uiza.io/uiza_logo_128.png"
			});
			Console.WriteLine(string.Format("Create New User Id = {0} Success", result.Data.id));
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

## Retrieve an user
Retrieves the details of an existing user. You need only supply the unique userId that was returned upon user creation.
See details [here](https://docs.uiza.io/?#retrieve-an-user).

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

			var result = UizaServices.User.Retrieve("User Id");
			
			Console.WriteLine(string.Format("Get User Id = {0} Success", result.Data.id));
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

## List all users
Returns a list of your user. The users are returned sorted by creation date, with the most recent user appearing first.

If you use Admin token, you will get all the user. If you use User token, you can only get the information of that user
See details [here](https://docs.uiza.io/?#list-all-users).

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

			var result = UizaServices.User.List();
			Console.WriteLine(string.Format("List User Success, total record {0}", result.Data.Count));
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

## Update an user
Updates the specified user by setting the values of the parameters passed. Any parameters not provided will be left unchanged.
See details [here](https://docs.uiza.io/?#update-an-user).

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

			var result = UizaServices.User.Update(new UpdateUserParameter()
			{
				Id = "User Id",
				Status = UserStatus.Active,
				UserName = Guid.NewGuid().ToString(),
				Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
				PassWord = Guid.NewGuid().ToString()
			});

			Console.WriteLine(string.Format("Update User Id = {0} Success", result.Data.id));
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

## Delete an user
Permanently deletes an user. It cannot be undone. Also immediately cancels all token & information of this user.
See details [here](https://docs.uiza.io/?#delete-an-user).

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

			var result = UizaServices.User.Delete("User Id");
			
			Console.WriteLine(string.Format("Delete User Id = {0} Success", result.Data.id));
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

## Change password
Change password allows Admin or User update their current password.
See details [here](https://docs.uiza.io/?#update-password).

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

			var result = UizaServices.User.ChangePassword(new ChangePasswordParameter()
			{
				Id = "User Id",
				NewPassword = Guid.NewGuid().ToString(),
				OldPassWord = "curent password",
			});

			Console.WriteLine(string.Format("Change Password User Id = {0} Success", result.Data.id));
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

## Log Out
This API use to log out an user. After logged out, token will be removed.
See details [here](https://docs.uiza.io/?#update-password).

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

			var result = UizaServices.User.Logout();
			Console.WriteLine("Logout Success");
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