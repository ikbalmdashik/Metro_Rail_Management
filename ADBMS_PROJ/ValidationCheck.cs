using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADBMS_PROJ
{
    public static class ValidationCheck
    {
        /// <summary>
        /// Checks if a string is null, empty, or whitespace only.
        /// </summary>
        public static bool IsNullOrWhiteSpace(string input)
        {
            return string.IsNullOrWhiteSpace(input);
        }

        /// <summary>
        /// Validates full name. Allows only letters and spaces, length between 2 and 50.
        /// </summary>
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Za-z\s]{2,50}$");
        }

        /// <summary>
        /// Validates email format using standard pattern.
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Validates password strength.
        /// Requires at least 8 characters, one uppercase, one lowercase, and one digit.
        /// </summary>
        public static bool IsStrongPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }

        /// <summary>
        /// Compares password and confirm password.
        /// </summary>
        public static bool DoPasswordsMatch(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        /// <summary>
        /// Validates phone number (optional example: 10–15 digits, no letters).
        /// </summary>
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10,15}$");
        }
    }

}
