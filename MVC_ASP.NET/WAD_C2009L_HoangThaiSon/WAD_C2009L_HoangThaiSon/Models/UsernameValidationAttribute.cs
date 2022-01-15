using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_C2009L_HoangThaiSon.Models
{
    public class UsernameValidationAttribute : ValidationAttribute
    {
        public int MinimumLength { get; }
        public int MaximumLength { get; }
        public UsernameValidationAttribute(int minimumLength, int maximumLength)
        {
            MinimumLength = minimumLength;
            MaximumLength = maximumLength;
        }
        public string GetErrorMessage() =>
            $"Username must have between {MinimumLength} and {MaximumLength}" +
                $"No underscore ‘_’, no dot ‘.’ at the beginning or end. No '__'," +
                "'._', '_.', '..' at the middle.";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            string username = ((string)value).Trim();
            if ((username.Length < MinimumLength || username.Length > MaximumLength) ||
                username[0].Equals("_") ||
                username[0].Equals(".") ||
                username.Contains("._") ||
                username.Contains("_.") ||
                username.Contains(".."))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

    }
}