using System;
using System.Text.RegularExpressions;

namespace AppDBClient
{
    public class Validate
    {
        public Boolean isFullname(String str)
        {
            //String expression = "^[a-zA-Z\\S][^0-9]+"; // the list of ranges
            if (str == null ) // if they try to enter nothing.
            {
                return true; // if user hit cancel
            }
            else if (str == "")
            {
                return true;
            }
            else
            {
                //!(new Regex(@"^[a-zA-Z\\S][^0-9]+")).IsMatch(str)
                    return !(new Regex(@"^[a-zA-Z\\S][^0-9]+")).IsMatch(str);
            }
        }

        public Boolean isAddress(String add)
        { 
            if (add == null) // if they try to enter nothing.
            {
                return true; // if user hit cancel
            }
            else if (add == "")
            {
                return true;
            }
            else
            {
                //!(new Regex(@"^[a-zA-Z\\S][^0-9]+")).IsMatch(str)
                return !(new Regex(@"[0 - 9a - zA - Z #,-]+")).IsMatch(add);
            }
        }

        //public Boolean isNumeric(String num)
        //{
        //    String expression = "^[1-2]"; // a short cut for all digit 0 to 9
        //    if (num == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return num.matches(expression);
        //    }
        //}
    }
}
