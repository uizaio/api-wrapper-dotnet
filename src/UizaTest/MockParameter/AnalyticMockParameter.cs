using Uiza.Net.Enums;
using Uiza.Net.Parameters;

namespace UizaTest.MockParameter
{
    public static class AnalyticMockParameter
    {
        public static TotalLineParameter GetTotalLineSuccessParameter()
        {
            return new TotalLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                Metric = MetricType.RebufferCount
            };
        }

        public static TotalLineParameter GetTotalLineFailParameter()
        {
            return new TotalLineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                Metric = MetricType.RebufferCount
            };
        }

        public static LineParameter GetLineSuccessParameter()
        {
            return new LineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                Type = LineType.PlaybackFailurePercentage
            };
        }

        public static LineParameter GetLineFailParameter()
        {
            return new LineParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00"
            };
        }

        public static TypeParameter GetTypeSuccessParameter()
        {
            return new TypeParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00",
                TypeFilter = TypeFilter.Country
            };
        }

        public static TypeParameter GetTypeFailParameter()
        {
            return new TypeParameter()
            {
                StartDate = @"2018-11-01 20:00",
                EndDate = @"2018-11-19 20:00"
            };
        }
    }
}