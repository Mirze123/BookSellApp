using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Helpers.Results.Abstract;
using WebApp.Models.Abstract;

namespace WebApp.Validation.Abstract
{
    public interface IBaseValidation<T> where T : IModel,new()
    {
        IValidationResult Validate(T model);
    }
}
