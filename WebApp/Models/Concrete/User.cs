using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Abstract;
using WebApp.Helpers;

namespace WebApp.Models.Concrete
{
    public class User : IModel
    {
        public int ID { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime CreatedDate { get;set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Enums.Roles Role { get; set; }

    }
}