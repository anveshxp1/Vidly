using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Minimum18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            
            if (customer.BirthDay == null)
                return new ValidationResult("Birthdate is required for membership.");

            var age = DateTime.Today.Year - customer.BirthDay.Value.Year;
            return (age > 18) 
                ? ValidationResult.Success 
                : new ValidationResult ("Customer must be atleast 18 years to go on a membership.");
        }
    }
}