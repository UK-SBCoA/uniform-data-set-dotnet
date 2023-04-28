using System;
using System.ComponentModel.DataAnnotations;
using UDS.Net.Forms.Models;

namespace UDS.Net.Forms.DataAnnotations
{
    public class BirthMonthAttribute : ValidationAttribute
    {
        public bool AllowUnknown { get; set; } = false;

        public string GetErrorMessage()
        {
            if (AllowUnknown)
                return "Birth year must be within 1 and 12, or 99 (unknown).";
            else
                return "Birth year must be within 1 and 12.";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (validationContext.ObjectType.IsSubclassOf(typeof(FormModel)))
            {
                var form = (FormModel)validationContext.ObjectInstance;

                if (form.Status == "2") // TODO fix statuses
                {
                    // Only validate on the server if form is attempting to be completed
                    var month = (int)value;

                    if (AllowUnknown && month == 99)
                    {
                        return ValidationResult.Success;
                    }

                    if (month < 1 || month > 12)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}

