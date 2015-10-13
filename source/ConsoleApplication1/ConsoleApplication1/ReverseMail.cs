using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ReverseClass
    {

        public string ReverseMail(string email)
        {
            int length = email.Length;
            char[] Arrayemail = new char[length];

            int begin = 0;
            for (int i = length - 1; i >= 0; i--) 
            {
                Arrayemail[begin++] = email[i];
            }

            string result = new string(Arrayemail);
            return result;
        }
    }
}
