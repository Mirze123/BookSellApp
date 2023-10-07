using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Constants;
using WebApp.Helpers.Results.Abstract;
using WebApp.Helpers.Results.Concrete;
using WebApp.Models.Concrete;
using WebApp.Validation.Abstract;

namespace WebApp.Validation.Concrete
{
    public class UserValidation : IUserValidation
    {
        private List<string> ErrorMessages = new List<string>();
        public IValidationResult Validate(User model)
        {


            #region 1.Göndərilən modelin null olub olmadığı yoxlanılır

            if (model is null)
            {
                ErrorMessages.Add(UserMessages.UserModelCannotBeNull);
            }

            #endregion

            #region 2.Modeldə username-in boş olub olmadığı yoxlanır

            if (string.IsNullOrWhiteSpace(model.Username))
            {
                ErrorMessages.Add(UserMessages.UsernameCannotBeNull);
            }

            #endregion

            #region 3.Modeldə username 3 simvoldan aşağı ola bilməz

            if (model.Username.Length < 3)
            {
                ErrorMessages.Add(UserMessages.UsernameCannotBeLessThan3Symbols);
            }

            #endregion

            if (ErrorMessages.Any())
            {
                return new ValidationResult(ErrorMessages, false);
            }

            return new ValidationResult(true);
        }
    }
}