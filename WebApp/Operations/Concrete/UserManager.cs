using SINAM.BIMS.Business.AdminTool.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Constants;
using WebApp.Helpers;
using WebApp.Helpers.Database;
using WebApp.Helpers.Extensions;
using WebApp.Helpers.Results.Abstract;
using WebApp.Helpers.Results.Concrete;
using WebApp.Models.Concrete;
using WebApp.Operations.Abstract;
using WebApp.Validation.Abstract;
using WebApp.Validation.Concrete;

namespace WebApp.Operations.Concrete
{
    /// <summary>
    /// İstifadəçi modelinə aid əməliyyatlar sinifi
    /// </summary>
    public class UserManager : IUserOperation
    {
        /// <summary>
        /// Göndərilən istifadəçi modelinin əlavə edilməsi metodu
        /// </summary>
        /// <param name="model">User sinifindən bir instance göndərilməlidir</param>
        /// <returns>
        ///  Geriyə IResult interfeysindən implement olunan hər hansısa bir Result sinifi qaytarıla bilər
        ///  Məsələn SuccessResult,ErrorResult
        /// </returns>
        public IResult Add(User model)
        {

            #region 1.Model Validation Section [...]

            IUserValidation userValidation = new UserValidation();
            var validationResult = userValidation.Validate(model);

            if (!validationResult.IsValid)
            {
                return new ErrorResult(validationResult.Errors.ListToString());
            }

            #endregion 1.Model Validation Section [...]

            #region 2.Business Validation Section [...]

            var businessLogicResult = BusinessLogics.Execute(
                CheckEmailExistsOrNot(model),
                CheckUserExistsOrNot(model));

            if (!businessLogicResult.IsSuccess)
            {
                return new ErrorResult(businessLogicResult.Message);
            }

            #endregion 2.Business Validation Section [...]

            #region 3.Password Validation Section [...]

            IPasswordValidation passwordValidation = new PasswordValidation();
            var passwordValidationResult = passwordValidation.ValidatePassword(model.Password, model.Password);

            if (!passwordValidationResult.IsValid)
            {
                return new ErrorResult(passwordValidationResult.FailureMessages.ListToString());
            }

            #endregion 3.Password Validation Section [...]

            BookAppDB.Users.Add(model);

            return new SuccessResult(UserMessages.UserAddedSuccessfully);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(BookAppDB.Users);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(BookAppDB.Users.FirstOrDefault(x => x.ID == id));
        }

        public IDataResult<int> GetNextId()
        {
            if (!BookAppDB.Users.Any())
            {
                return new SuccessDataResult<int>(DefaultValueConstants.DEFAULT_ID_VALUE);
            }

            return new SuccessDataResult<int>(BookAppDB.Users.Max(x => x.ID) + 1);
        }

        public IResult Remove(User model)
        {
            BookAppDB.Users.Remove(model);
            return new SuccessResult(UserMessages.UserDeletedSuccessfully);
        }

        public IResult Update(User model)
        {
            var oldUser = BookAppDB.Users.Find(x => x.ID == model.ID);
            oldUser = model;
            return new SuccessResult(UserMessages.UserUpdatedSuccessfully);
        }

        private IResult CheckUserExistsOrNot(User user)
        {
            var existenceUser = BookAppDB.Users.SingleOrDefault(x => x.Username.ToLower() == user.Username.ToLower());
            if (existenceUser != null)
            {
                return new ErrorResult(UserMessages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

        private IResult CheckEmailExistsOrNot(User user)
        {
            var existenceUser = BookAppDB.Users.SingleOrDefault(x => x.Email.ToLower() == user.Email.ToLower());
            if (existenceUser != null)
            {
                return new ErrorResult(UserMessages.EmailAlreadyExists);
            }
            return new SuccessResult();
        }




    }
}