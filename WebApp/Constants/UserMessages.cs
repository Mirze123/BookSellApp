using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Constants
{
    public static class UserMessages
    {
        public static readonly string UserModelCannotBeNull = "UserModelCannotBeNull";
        public static readonly string UsernameCannotBeNull = "UsernameCannotBeNull";
        public static readonly string UsernameCannotBeLessThan3Symbols = "UsernameCannotBeLessThan3Symbols";
        public static readonly string UserAddedSuccessfully = "UserAddedSuccessfully";
        public static readonly string UserAlreadyExists = "UserAlreadyExists";
        public static readonly string EmailAlreadyExists = "EmailAlreadyExists";
        public static readonly string UserDeletedSuccessfully = "UserDeletedSuccessfully";
        public static readonly string UserUpdatedSuccessfully = "UserUpdatedSuccessfully";
    }
}