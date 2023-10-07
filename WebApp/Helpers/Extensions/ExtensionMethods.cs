using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApp.Helpers.Extensions
{
    public static class ExtensionMethods
    {
        public static string ListToString(this List<string> errors)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string error in errors)
            {
                sb.Append(error);
                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}