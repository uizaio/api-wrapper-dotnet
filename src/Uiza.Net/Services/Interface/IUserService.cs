using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// User Service Interface
    /// </summary>
    public interface IUserService : IBaseServices,
        ICreate<UizaData, CreatUserParameter>,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, UpdateUserParameter>,
        IDelete<UizaData>
    {
        /// <summary>
        /// List All User
        /// </summary>
        /// <returns></returns>
        UizaData List();

        /// <summary>
        /// Change Password
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        UizaData ChangePassword(ChangePasswordParameter param);

        /// <summary>
        /// Logout
        /// </summary>
        /// <returns></returns>
        UizaData Logout();
    }
}