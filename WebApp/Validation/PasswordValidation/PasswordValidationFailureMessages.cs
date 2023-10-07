using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAM.BIMS.Business.AdminTool.Classes
{
    public class PasswordValidationFailureMessages
    {
        private static readonly string passwordsDoesntMatch = "Passwords doesn't match";
        private static readonly string lengthLessThan = "The length of the password should not be less than 10 characters";
        private static readonly string doesNotContainSymbol = "The password must contain 1 special character";
        private static readonly string doesNotContainNumber = "The password must have 1 digit";
        private static readonly string doesNotContainUpperCase = "The password must have 1 capital letter";
        private static readonly string doesNotContainLowerCase = "The password must contain at least 1 lowercase letter";
        private static readonly string whiteSpaceFailure = "Password cannot contain spaces";

        public string PasswordsDoesntMatch { get; set; } = passwordsDoesntMatch;
        public string LengthLessThan { get; set; } = lengthLessThan;
        public string DoesNotContainSymbol { get; set; } = doesNotContainSymbol;
        public string DoesNotContainNumber { get; set; } = doesNotContainNumber;
        public string DoesNotContainUpperCase { get; set; } = doesNotContainUpperCase;
        public string DoesNotContainLowerCase { get; set; } = doesNotContainLowerCase;
        public string WhiteSpaceFailure { get; set; } = whiteSpaceFailure;
    }
}
