using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    /// <summary>
    ///
    /// </summary>
    internal class AnalyticService : Service, IAnalyticService
    {
        public UizaData GetLine(AnalyticLineParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ANALYTIC.LINE);
            return this.GetRequest<UizaData>(Constants.ApiAction.ANALYTIC_LINE, param);
        }

        public UizaData GetTotalLine(AnalyticTotalLineParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ANALYTIC.TOTAL_LINE);
            return this.GetRequest<UizaData>(Constants.ApiAction.ANALYTIC_TOTAL_LINE, param);
        }

        public UizaData GetType(AnalyticTypeParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ANALYTIC.TYPE);
            return this.GetRequest<UizaData>(Constants.ApiAction.ANALYTIC_TYPE, param);
        }
    }
}