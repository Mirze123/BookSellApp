using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Helpers
{
    public class Enums
    {
        public enum Roles
        {
            Admin,
            User,
            Moderator,
            Anonymous
        }

        public enum Mode
        {
            Insert,
            Update,
            Readonly
        }
    }
}