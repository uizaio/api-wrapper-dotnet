using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface IUserService : IBaseServices,
        IRetrieve<UizaData, string>,
        IUpdate<UizaData, UpdateUserParameter>
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData List();

        /// <summary>
        ///
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        UizaData ChangePassword(ChangePasswordParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData Logout();
    }
}