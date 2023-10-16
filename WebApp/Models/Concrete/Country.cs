using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Abstract;

namespace WebApp.Models.Concrete
{
    public class Country : IModel
    {
        public int ID { get;set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdateDate { get;set; }
        public DateTime CreatedDate { get; set; }
    }
}