using System.ComponentModel.DataAnnotations;

namespace WAD_C2009L_HoangThaiSon1.Models
{
    public class IsNumbericAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                decimal val;
                var isNumeric = decimal.TryParse(value.ToString(), out val);

                if (!isNumeric)
                {
                    return new ValidationResult("Must be numeric");
                }
            }
            return ValidationResult.Success;
        }
    }
}