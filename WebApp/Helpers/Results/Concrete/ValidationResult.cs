using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Helpers.Results.Abstract;

namespace WebApp.Helpers.Results.Concrete
{
    public class ValidationResult : IValidationResult
    {
        public bool IsValid { get; }

        public List<string> Errors { get; }

        public ValidationResult(List<string> errors,bool isValid):this(isValid)
        {
            Errors = errors;
        }

        public ValidationResult(bool isValid)
        {
            IsValid = isValid;
        }
    }
}