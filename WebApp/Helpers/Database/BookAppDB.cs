using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models.Concrete;

namespace WebApp.Helpers.Database
{
    public static class BookAppDB
    {
        public static List<User> Users { get; set; }

        static BookAppDB()
        {
            Users = new List<User>();
        }
    }
}