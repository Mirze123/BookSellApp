using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Helpers.Results.Concrete
{
    public class ErrorResult : Result
    {
        public ErrorResult() : base(false)
        {
        }

        public ErrorResult(string message) : base(message, false)
        {
        }
    }
}