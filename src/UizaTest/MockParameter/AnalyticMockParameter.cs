using Uiza.Net.Enum;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class AnalyticMockParameter
    {
        public static AnalyticTotalLineParameter GetTotalLineSuccessParameter()
        {
            return new AnalyticTotalLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                Metric = MetricType.RebufferCount
            };
        }

        public static AnalyticTotalLineParameter GetTotalLineFailParameter()
        {
            return new AnalyticTotalLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                Metric = MetricType.RebufferCount
            };
        }

        public static AnalyticLineParameter GetLineSuccessParameter()
        {
            return new AnalyticLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                Type = LineType.PlaybackFailurePercentage
            };
        }

        public static AnalyticLineParameter GetLineFailParameter()
        {
            return new AnalyticLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00"
            };
        }

        public static AnalyticTypeParameter GetTypeSuccessParameter()
        {
            return new AnalyticTypeParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                TypeFilter = TypeFilter.Country
            };
        }

        public static AnalyticTypeParameter GetTypeFailParameter()
        {
            return new AnalyticTypeParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00"
            };
        }
    }
}