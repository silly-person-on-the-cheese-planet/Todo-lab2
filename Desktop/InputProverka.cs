using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desktop
{
    internal class InputProverka
    {
        public bool IsProverkaEmail(string email)
        {

            string emailTextPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailTextPattern);
        }


        public bool IsProverkaPass(string pass)
        {
            return pass.Length >= 6;
        }


        public bool IsProverkaName(string name)
        {
            return name.Length >= 3;
        }
    }
}
