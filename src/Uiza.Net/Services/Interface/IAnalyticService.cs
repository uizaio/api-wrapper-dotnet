using Uiza.Net.Parameters;
using Uiza.Net.Response;

namespace Uiza.Net.Services.Interface
{
    /// <summary>
    /// Service Interface
    /// </summary>
    public interface IAnalyticService : IBaseServices
    {
        /// <summary>
        /// Get data grouped by hour (data refresh every 5 minutes). 
        /// Track video playback on any metric performance, so you can know exactly what’s happening on every user’s device and debug more effectively.
        /// About grouped by hour algorithm, Uiza currently support up to 16 days (it means when your time range is lower than 16 days, data response will be grouped by hour. 
        /// Otherwise, it will return and to be grouped by day). 
        /// In case your requested timerange doesn't have data, API won't show it in response.
        /// </summary>
        /// <returns></returns>
        UizaData GetTotalLine(TotalLineParameter param);

        /// <summary>
        /// Get data base on 5 type of filter: country, device, title, player, os
        /// </summary>
        /// <returns></returns>
        UizaData GetType(TypeParameter param);

        /// <summary>
        /// Get data grouped by hour. 
        /// Get data in time range. 
        /// This help you to draw a line chart to visualize data
        /// About grouped by hour algorithm, Uiza currently support upto 16 days (it's mean when your time range is lower than 16 days, data response will be grouped by hour. 
        /// Otherwise, it will return and to be grouped by day). 
        /// In case your requested timerange doesn't have data, API won't show it in response.
        /// </summary>
        /// <returns></returns>
        UizaData GetLine(LineParameter param);
    }
}