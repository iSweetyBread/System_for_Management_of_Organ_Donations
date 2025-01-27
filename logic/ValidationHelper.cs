using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace logic
{
    public static class ValidationHelper
    {
        public static bool IsValidPhone(string text)
        {
            return Regex.IsMatch(text, @"^(\+[0-9]{9})$");
        }
        public static bool IsValidName(string text)
        {
            return Regex.IsMatch(text, @"^[A-Za-z]+$");
        }
        public static bool IsValidID(string text)
        {
            return Regex.IsMatch(text, @"^[0-9]+$");
        }
        public static bool IsValidDate(string text)
        {
            return DateTime.TryParse(text, out _);
        }
        public static bool IsValidStatus(string text)
        {
            return Regex.IsMatch(text, @"^(Wykorzystane|Dostepne|Oczekiwane)$");
        }
        public static bool IsValidType(string text)
        {
            return Regex.IsMatch(text, @"^(A-|A\+|B-|B\-|AB-|AB\+|O-|O\+)$");
        }
        public static bool IsValidNumber(string text)
        {
            return Regex.IsMatch(text, @"^[0-9]+$");
        }
    }
}
