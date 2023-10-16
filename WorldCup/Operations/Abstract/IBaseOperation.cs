using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldCup.Models;

namespace WorldCup.Operations.Abstract
{
    public interface IBaseOperation<T> where T : BaseClass,new()
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetAll();
        T Get(int id);
        int GetNextId();
    }
}