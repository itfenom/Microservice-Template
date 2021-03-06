﻿using System.Collections.Generic;
using Calabonga.AspNetCore.Micro.Web.Infrastructure.Validations.Base;

namespace Calabonga.AspNetCore.Micro.Web.Extensions
{
    /// <summary>
    /// Entity Validator Extensions
    /// </summary>
    public static class EntityValidatorExtensions
    {
        /// <summary>
        /// Returns validator from validation results
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static ValidationContext GetResult(this List<ValidationResult> source)
        {
            return new ValidationContext(source);
        }

    }
}