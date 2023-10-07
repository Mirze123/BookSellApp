using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SINAM.BIMS.Business.AdminTool.Classes
{
    public class PasswordValidation : IPasswordValidation
    {
        internal string Password { get; private set; }
        internal string ConfirmPassword { get; private set; }

        public PasswordValidationResult ValidatePassword(string password, string confirmPassword)
        {
            return ValidatePassword(password, confirmPassword, new PasswordValidationConfiguration());

        }

        public PasswordValidationResult ValidatePassword(string password, string confirmPassword, PasswordValidationConfiguration configuration)
        {
            Password = password;
            ConfirmPassword = confirmPassword;

            PasswordValidationResult result = ValidatePassword(CheckPasswordsMatchOrNot(configuration),
                                                                    CheckWhiteSpaceValidation(configuration),
                                                                    CheckIsContainUpperCase(configuration),
                                                                    CheckIsContainLowerCase(configuration),
                                                                    CheckIsContainNumber(configuration),
                                                                    CheckIsContainSymbol(configuration),
                                                                    CheckIsValidLength(configuration));

            return result;

        }

        private PasswordValidationResult ValidatePassword(params PasswordValidationResult[] conditions)
        {
            PasswordValidationResult result = new PasswordValidationResult();

            foreach (var condition in conditions)
            {
                if (!condition.Status)
                {
                    result.FailureMessages.Add(condition.Message);
                }
            }

            result.IsValid = result.FailureMessages.Count > 0 ? PasswordValidationStatus.isFailed : PasswordValidationStatus.isValid;

            return result;
        }

        private PasswordValidationResult CheckPasswordsMatchOrNot(PasswordValidationConfiguration configuration)
        {
            if (Password == ConfirmPassword)
            {
                return new PasswordValidationResult(PasswordValidationStatus.isValid);
            }
            else
            {
                return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.PasswordsDoesntMatch);
            }
        }

        private PasswordValidationResult CheckWhiteSpaceValidation(PasswordValidationConfiguration configuration)
        {
            if (!configuration.ContainWhiteSpace)
            {
                string pattern = @"^(?=.*\s)";

                Regex regex = new Regex(pattern, RegexOptions.Multiline);

                var result = regex.Match(Password);
                if (!result.Success)
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isValid);
                }
                else
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.WhiteSpaceFailure);
                }
            }
            return new PasswordValidationResult(PasswordValidationStatus.isValid);

        }

        private PasswordValidationResult CheckIsContainUpperCase(PasswordValidationConfiguration configuration)
        {
            if (configuration.ContainUpperCase)
            {
                string pattern = @"^(?=.*[A-Z])";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var result = regex.Match(Password);
                if (result.Success)
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isValid);
                }
                else
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.DoesNotContainUpperCase);
                }
            }

            return new PasswordValidationResult(PasswordValidationStatus.isValid);

        }

        private PasswordValidationResult CheckIsContainLowerCase(PasswordValidationConfiguration configuration)
        {
            if (configuration.ContainLowerCase)
            {
                string pattern = @"^(?=.*[a-z])";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var result = regex.Match(Password);
                if (result.Success)
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isValid);
                }
                else
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.DoesNotContainLowerCase);
                }
            }
            return new PasswordValidationResult(PasswordValidationStatus.isValid);
        }

        private PasswordValidationResult CheckIsContainNumber(PasswordValidationConfiguration configuration)
        {
            if (configuration.ContainNumber)
            {
                string pattern = @"^(?=.*[0-9])";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var result = regex.Match(Password);
                if (result.Success)
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isValid);
                }
                else
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.DoesNotContainNumber);
                }
            }
            return new PasswordValidationResult(PasswordValidationStatus.isValid);
        }

        private PasswordValidationResult CheckIsContainSymbol(PasswordValidationConfiguration configuration)
        {
            if (configuration.ContainSymbol)
            {
                string pattern = @"^(?=.*[~`!@#$%^&*()--+={}\[\]|\\:;""'<>,.?/_₹])";
                Regex regex = new Regex(pattern, RegexOptions.Multiline);
                var result = regex.Match(Password);
                if (result.Success)
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isValid);
                }
                else
                {
                    return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.DoesNotContainSymbol);
                }
            }
            return new PasswordValidationResult(PasswordValidationStatus.isValid);

        }

        private PasswordValidationResult CheckIsValidLength(PasswordValidationConfiguration configuration)
        {
            if (Password.Length < configuration.MinimumLength)
            {
                return new PasswordValidationResult(PasswordValidationStatus.isFailed, configuration.FailureMessages.LengthLessThan);
            }
            else
            {
                return new PasswordValidationResult(PasswordValidationStatus.isValid);
            }
        }
    }
}
