using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINAM.BIMS.Business.AdminTool.Classes
{
    public class PasswordValidationResult
    {
        internal bool Status { get; }
        internal string Message { get; }

        public bool IsValid { get; set; }
        public List<string> FailureMessages { get; set; }


        public PasswordValidationResult()
        {
            FailureMessages = new List<string>();
        }
        public PasswordValidationResult(bool status)
        {
            Status = status;
        }

        public PasswordValidationResult(bool status, string message) : this(status)
        {
            Message = message;
        }
    }
}
