using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Helpers.Results.Abstract;
using WebApp.Helpers.Results.Concrete;

namespace WebApp.Helpers
{
    public static class BusinessLogics
    {
        public static IResult Execute(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.IsSuccess)
                {
                    return new ErrorResult(logic.Message);
                }
            }

            return new SuccessResult();
        }
    }
}