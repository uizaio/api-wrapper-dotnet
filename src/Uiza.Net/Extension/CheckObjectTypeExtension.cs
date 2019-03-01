using Newtonsoft.Json.Linq;

namespace Uiza.Net.Extension
{
    internal static class CheckJsonTypeExtension
    {
        public static bool IsJArray(this object o)
        {
            if (o == null) return false;
            return o is JArray;
        }
    }
}