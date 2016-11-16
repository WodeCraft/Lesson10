using System;
using System.ComponentModel.DataAnnotations;

namespace Lesson10.Infrastructure
{
    public class FutureDateAttribute : ValidationAttribute
    {

        public FutureDateAttribute()
        {
            ErrorMessage = "The date must be after today.";
        }

        public override bool IsValid(object value)
        {
            // Jes' implementation
            //DateTime dt;
            //return (DateTime.TryParse(value.ToString(), out dt) && (DateTime)value > DateTime.Now);

            return (value.GetType() == typeof(DateTime) && (DateTime)value > DateTime.Now);
        }

    }
}