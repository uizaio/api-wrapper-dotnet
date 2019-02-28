## User
You can manage user with APIs user. Uiza have 2 levels of user

Admin - This account will have the highest priority, can have permission to create & manage users.

User - This account level is under Admin level. It only manages APIs that relates to this account.

See details [here](https://docs.uiza.io/?#user-management).

## Create an user
Create an user account for workspace
See details [here](https://docs.uiza.io/?#create-an-user).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
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
```

## Retrieve an user
Retrieves the details of an existing user. You need only supply the unique userId that was returned upon user creation.
See details [here](https://docs.uiza.io/?#retrieve-an-user).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.User.Create(new CreatUserParameter()
{
	Status = UserStatus.Active,
	UserName = Guid.NewGuid().ToString(),
	Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
	PassWord = Guid.NewGuid().ToString();,
	FullName = Guid.NewGuid().ToString(),
	Avatar = "https://static.uiza.io/uiza_logo_128.png"
});

var retrieveResult = UizaServices.User.Retrieve((string)result.Data.id);
Console.WriteLine(string.Format("Get User Id = {0} Success", retrieveResult.Data.id));
```

## List all users
Returns a list of your user. The users are returned sorted by creation date, with the most recent user appearing first.

If you use Admin token, you will get all the user. If you use User token, you can only get the information of that user
See details [here](https://docs.uiza.io/?#list-all-users).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var listResult = UizaServices.User.List();
Console.WriteLine(string.Format("List User Success, total record {0}", listResult.Data.Count));
```

## Update an user
Updates the specified user by setting the values of the parameters passed. Any parameters not provided will be left unchanged.
See details [here](https://docs.uiza.io/?#update-an-user).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.User.Create(new CreatUserParameter()
{
	Status = UserStatus.Active,
	UserName = Guid.NewGuid().ToString(),
	Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
	PassWord = Guid.NewGuid().ToString();,
	FullName = Guid.NewGuid().ToString(),
	Avatar = "https://static.uiza.io/uiza_logo_128.png"
});

var updateResult = UizaServices.User.Update(new UpdateUserParameter()
{
	Id = (string)result.Data.id,
	Status = UserStatus.Active,
	UserName = Guid.NewGuid().ToString(),
	Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
	PassWord = Guid.NewGuid().ToString()
});

Console.WriteLine(string.Format("Update User Id = {0} Success", updateResult.Data.id));
```

## Delete an user
Permanently deletes an user. It cannot be undone. Also immediately cancels all token & information of this user.
See details [here](https://docs.uiza.io/?#delete-an-user).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var result = UizaServices.User.Create(new CreatUserParameter()
{
	Status = UserStatus.Active,
	UserName = Guid.NewGuid().ToString(),
	Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
	PassWord = Guid.NewGuid().ToString();,
	FullName = Guid.NewGuid().ToString(),
	Avatar = "https://static.uiza.io/uiza_logo_128.png"
});

var deleteResult = UizaServices.User.Delete((string)result.Data.id);
Console.WriteLine(string.Format("Delete User Id = {0} Success", deleteResult.Data.id));
```

## Update password
Update password allows Admin or User update their current password.
See details [here](https://docs.uiza.io/?#update-password).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var curentPW = Guid.NewGuid().ToString();
var result = UizaServices.User.Create(new CreatUserParameter()
{
	Status = UserStatus.Active,
	UserName = Guid.NewGuid().ToString(),
	Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
	PassWord = curentPW,
	FullName = Guid.NewGuid().ToString(),
	Avatar = "https://static.uiza.io/uiza_logo_128.png"
});

var changePWResult = UizaServices.User.ChangePassword(new ChangePasswordParameter()
{
	Id = (string)result.Data.id,
	NewPassword = Guid.NewGuid().ToString(),
	OldPassWord = curentPW,
});

Console.WriteLine(string.Format("Change Password User Id = {0} Success", changePWResult.Data.id));
```

## Log Out
This API use to log out an user. After logged out, token will be removed.
See details [here](https://docs.uiza.io/?#update-password).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var logOutResult = UizaServices.User.Logout();
Console.WriteLine("Logout Success");
```