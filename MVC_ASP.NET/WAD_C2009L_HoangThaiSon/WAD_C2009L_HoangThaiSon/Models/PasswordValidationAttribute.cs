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

    namespace WAD_C2009L_HoangThaiSon.Models
    {
        public class PasswordValidationAttribute : ValidationAttribute
        {
            public int MinimumLength { get; }
            public int MaximumLength { get; }
            public PasswordValidationAttribute(int minimumLength, int maximumLength)
            {
                MinimumLength = minimumLength;
                MaximumLength = maximumLength;
            }
            public string GetErrorMessage() =>
                $"Username must have at {MinimumLength} No blank space." +
                $" At least one digit, one upper-case letter, one lower-case letter," +
                $" one special character";
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {

                string password = ((string)value).Trim();
                if (password.Length < MinimumLength ||
                    password.Contains(" ") ||
                    !password.Any(char.IsDigit) ||
                    !password.Any(char.IsUpper) ||
                    !password.Any(char.IsLower) ||
                    !password.Any(ch => !Char.IsLetterOrDigit(ch))
                    )
                {
                    return new ValidationResult(GetErrorMessage());
                }

                return ValidationResult.Success;
            }

        }
    }

}