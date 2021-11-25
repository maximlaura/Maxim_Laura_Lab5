using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Maxim_Laura_Lab5
{
    public class StringNotEmpty : ValidationRule
    { //mostenim din clasa ValidationRule 
      //suprascriem metoda Validate ce returneaza un ValidationResult
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "")
                return new ValidationResult(false, "String cannot be empty");
            return new ValidationResult(true, null);
        }
    } //validator pentru lungime minima a string-ului
    public class StringMinLength : ValidationRule
    { public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3) return new ValidationResult(false, "String must have at least 3 characters!");
            return new ValidationResult(true, null);
        }
    }

    public class StringMaxLenght : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        { 
        string aString = value.ToString();
        if(aString.Length>30) return new ValidationResult(false, "String must have maximum 30 characters!");
            return new ValidationResult(true, null);
        } 
    }

    public class NonNumeric : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == @"^[0-9]+['\s]*$") return new ValidationResult(false, "String cannot have numeric characters");
            return new ValidationResult(true, null);
        }
    }
}
