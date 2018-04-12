using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace AppDBClient
{
    public class Validate
    {
        public Boolean IsFullname(String str)
        {
            if (str == null)
            {
                return true;
            }
            else if (str == "")
            {
                return true;
            }
            else
            {
                return !(new Regex(@"^[a-zA-Z\\S][^0-9]+")).IsMatch(str);
            }
        }

        public Boolean IsAddress(String add)
        {
            if (add == null)
            {
                return true;
            }
            else if (add == "")
            {
                return true;
            }
            else
            {
                return !(new Regex(@"[0 - 9a - zA - Z #,-]+")).IsMatch(add);
            }
        }

        public Boolean IsEmail(String email)
        {
            if (email == null)
            {
                return true;
            }
            else if (email == "")
            {
                return true;
            }
            else
            {
                return !(new Regex
                    (@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*" + "@"+ @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$")
                    ).IsMatch(email);
                // from https://stackoverflow.com/a/6893571
            }
        }

        public Boolean IsPhoneNumber(String num)
        {
            if (num == null)
            {
                return true;
            }
            else if (num == "")
            {
                return true;
            }
            else
            {
                return !(new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")).IsMatch(num);
            }
        }
    }
}
