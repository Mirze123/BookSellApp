using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Constants;
using WebApp.Helpers.Database;
using WebApp.Helpers.Results.Abstract;
using WebApp.Helpers.Results.Concrete;
using WebApp.Models.Concrete;
using WebApp.Operations.Abstract;

namespace WebApp.Operations.Concrete
{
    public class CountryManager : ICountryOperation
    {
        public IResult Add(Country model)
        {
            BookAppDB.Countries.Add(model);
            return new SuccessResult(CommonMessages.DataAddedSuccessfully);
        }

        public IDataResult<List<Country>> GetAll()
        {
           return new SuccessDataResult<List<Country>>(BookAppDB.Countries);
        }

        public IDataResult<Country> GetById(int id)
        {
            return new SuccessDataResult<Country>(BookAppDB.Countries.SingleOrDefault(x => x.ID == id));
        }

        public IDataResult<int> GetNextId()
        {
            if (!BookAppDB.Countries.Any())
            {
                return new SuccessDataResult<int>(DefaultValueConstants.DEFAULT_ID_VALUE);
            }

            return new SuccessDataResult<int>(BookAppDB.Countries.Max(x => x.ID) + 1);
        }

        public IResult Remove(Country model)
        {
            BookAppDB.Countries.Remove(model);
            return new SuccessResult(CommonMessages.DataDeletedSuccessfully);
        }

        public IResult Update(Country model)
        {

            var oldModel = BookAppDB.Countries.Find(x => x.ID == model.ID);
            oldModel = model;
            return new SuccessResult(CommonMessages.DataUpdatedSuccessfully);
        }
    }
}