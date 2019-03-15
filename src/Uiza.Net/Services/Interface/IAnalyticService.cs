using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    ///
    /// </summary>
    public interface IAnalyticService : IBaseServices
    {
        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetTotalLine(TotalLineParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetType(TypeParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetLine(LineParameter param);
    }
}