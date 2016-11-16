using Lesson10.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lesson10.Models
{
    public class Interviewee : IValidatableObject
    {

        public string Name { get; set; }

        public string Address { get; set; }

        [RegularExpression(@"\d{4}")]
        public string Zip { get; set; }

        public string City { get; set; }

        [RegularExpression(@"\+{0,1}[\d\s]{8,14}")]
        public string Phone { get; set; }

        [RegularExpression(@"\S+@\S+\.\S{2,3}")]
        public string Email { get; set; }

        [FutureDate()]
        [DataType(DataType.Date)]
        public DateTime FirstInterviewDate { get; set; }

        [FutureDate()]
        [DataType(DataType.Date)]
        public DateTime SecondInterviewDate { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (SecondInterviewDate < FirstInterviewDate)
            {
                errors.Add(new ValidationResult("The second interview date must be after the first interview date.", new string[] { "SecondInterviewDate" }));
            }

            return errors;
        }
    }
}