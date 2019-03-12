using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Uiza.Net.UizaHandleException;

namespace Uiza.Net.Extension
{
    /// <summary>
    ///
    /// </summary>
    internal static class UizaExtension
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        internal static IList<ValidationResult> GetValidationErrors(this object model)
        {
            var result = new List<ValidationResult>();
            var validationContext = new ValidationContext(model);
            Validator.TryValidateObject(model, validationContext, result, true);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        internal static string FormatUrl(this string url)
        {
            Uri uriResult;
            var result = Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                 && Uri.CheckSchemeName(uriResult.Scheme);
            if (!result)
                return string.Empty;

            var localPath = uriResult.LocalPath;
            while (localPath.Contains("//"))
            {
                localPath = localPath.Replace("//", "/");
            }

            return uriResult.OriginalString.Replace(uriResult.LocalPath, localPath);
        }
    }
}