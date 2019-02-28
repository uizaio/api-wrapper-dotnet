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
        UizaData GetTotalLine(AnalyticTotalLineParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetType(AnalyticTypeParameter param);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        UizaData GetLine(AnalyticLineParameter param);
    }
}