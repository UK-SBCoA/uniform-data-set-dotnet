using System;
using System.ComponentModel.DataAnnotations;
using UDS.Net.Forms.Models;

namespace UDS.Net.Forms.DataAnnotations
{
    public class BirthYearAttribute : ValidationAttribute
    {
        public int Minimum { get; set; } = 1875; // A1 minimum is default
        public int Maximum { get; } = DateTime.Now.Year - 15; // Maximum for A1 or A2 is always current year minus 15
        public bool AllowUnknown { get; set; } = false;

        public string GetErrorMessage()
        {
            if (AllowUnknown)
                return $"Birth year must be between {Minimum} and {Maximum}, or 9999 (unknown).";
            else
                return $"Birth year must be between {Minimum} and {Maximum}.";
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (validationContext.ObjectType.IsSubclassOf(typeof(FormModel)))
            {
                var form = (FormModel)validationContext.ObjectInstance;

                if (form.Status == "2") // TODO fix statuses
                {
                    // Only validate on the server if form is attempting to be completed
                    var year = (int)value;

                    if (AllowUnknown && year == 9999)
                    {
                        return ValidationResult.Success;
                    }

                    if (year < Minimum || year > Maximum)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }
            }

            return ValidationResult.Success;
        }
    }
}

