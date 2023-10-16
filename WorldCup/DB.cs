using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldCup.Models;

namespace WorldCup
{
    public static class DB
    {
        public static List<Country> Countries { get; set; }
        public static List<Groups> Groups { get; set; }

        static DB()
        {
            Countries = new List<Country>();
            Groups = new List<Groups>();
        }
    }
}