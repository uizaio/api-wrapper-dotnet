using System;
using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class UserMockParamter
    {
        internal static CreatUserParameter CreateUserParameter()
        {
            return new CreatUserParameter()
            {
                Status = UserStatus.Active,
                UserName = Guid.NewGuid().ToString(),
                Email = string.Format("{0}@gmail.com", Guid.NewGuid().ToString()),
                PassWord = Guid.NewGuid().ToString(),
                FullName = Guid.NewGuid().ToString(),
                Avatar = "https://static.uiza.io/uiza_logo_128.png"
            };
        }

        internal static UpdateUserParameter UpdateUserParameter()
        {
            return new UpdateUserParameter()
            {
                Status = UserStatus.Active,
                UserName = Guid.NewGuid().ToString(),
            };
        }

        internal static ChangePasswordParameter ChangePasswordParameter()
        {
            return new ChangePasswordParameter()
            {
                NewPassword = Guid.NewGuid().ToString(),
                OldPassWord = Guid.NewGuid().ToString(),
                Id = Guid.NewGuid().ToString(),
            };
        }
    }
}