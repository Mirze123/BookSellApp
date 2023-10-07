using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Helpers.Results.Abstract
{
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}