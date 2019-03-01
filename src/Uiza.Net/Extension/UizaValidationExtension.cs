using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Uiza.Net.Extension
{
    /// <summary>
    ///
    /// </summary>
    internal static class UizaValidationExtension
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
    }
}