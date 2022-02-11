using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WAD_C2009L_NguyenVanA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    namespace WAD_C2009L_NguyenVanA.Models
    {
        public class PasswordValidationAttribute : ValidationAttribute
        {
            public int MinimumLength { get; }            
            public PasswordValidationAttribute(int minimumLength)
            {
                MinimumLength = minimumLength;                
            }
            public string GetErrorMessage() =>
                $"Username must have at {MinimumLength} No blank space." +
                $" At least one digit, one upper-case letter, one lower-case letter," +
                $" one special character";
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {

                string username = ((string)value).Trim();
                if (username.Length < MinimumLength ||
                    username.Contains(" ") )
                    
                {
                    return new ValidationResult(GetErrorMessage());
                }

                return ValidationResult.Success;
            }

        }
    }

}