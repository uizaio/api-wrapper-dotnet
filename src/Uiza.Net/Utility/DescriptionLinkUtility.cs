namespace Uiza.Net.Utility
{
    internal static class DescriptionLinkUtility
    {
        internal static string GetDescriptionLink(string apiName)
        {
            return string.Format("{0}#{1}", DescriptionLinkConstants.BASE_DESCRIPTION_LINK, apiName);
        }
    }
}