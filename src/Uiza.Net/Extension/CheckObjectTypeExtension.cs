using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
