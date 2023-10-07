using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Helpers.Results.Abstract;

namespace WebApp.Helpers.Results.Concrete
{
    public abstract class Result : IResult
    {
        public string Message { get; }

        public bool IsSuccess { get; }

        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public Result(string message, bool isSuccess):this(isSuccess)
        {
            Message = message;
        }
    }
}