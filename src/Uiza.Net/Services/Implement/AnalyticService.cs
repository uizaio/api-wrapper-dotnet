using Uiza.Net.Parameters;
using Uiza.Net.Response;
using Uiza.Net.Services.Interface;
using Uiza.Net.Utility;

namespace Uiza.Net.Services
{
    /// <summary>
    /// Analytic Service
    /// </summary>
    internal class AnalyticService : Service, IAnalyticService
    {
        public UizaData GetLine(LineParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ANALYTIC.LINE);
            return this.GetRequest<UizaData>(Constants.ApiAction.ANALYTIC_LINE, param);
        }
       
        public UizaData GetTotalLine(TotalLineParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ANALYTIC.TOTAL_LINE);
            return this.GetRequest<UizaData>(Constants.ApiAction.ANALYTIC_TOTAL_LINE, param);
        }

        public UizaData GetType(TypeParameter param)
        {
            param.DescriptionLink = DescriptionLinkUtility.GetDescriptionLink(DescriptionLinkConstants.ANALYTIC.TYPE);
            return this.GetRequest<UizaData>(Constants.ApiAction.ANALYTIC_TYPE, param);
        }
    }
}