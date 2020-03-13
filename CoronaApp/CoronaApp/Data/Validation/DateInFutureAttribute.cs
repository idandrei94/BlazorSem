using System;
using System.ComponentModel.DataAnnotations;

namespace CoronaApp.Data.Validation
{
    public class DateInFutureAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if(value is DateTime date)
            {
                return DateTime.Now < date;
            }
            return false;
        }
    }
}
