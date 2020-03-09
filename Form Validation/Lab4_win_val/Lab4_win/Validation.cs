using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Validation
    {
        public static bool ContainsBadWords(string temp)
        {
            bool blResult = false;

            string[] strBadwords = 
                {
                    "POOP", "CACA", "PEE", "DOODOO"
                };

            foreach (string strBW in strBadwords)
            if (temp.ToUpper().Contains(strBW))
            {
                blResult = true;
            }

            return blResult;
        }

        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResult;

            if (temp <= DateTime.Now)
            {
                blnResult = false;
            }
            else
            {
                blnResult = true;
            }

            return blnResult;
        }

        //Receives a string and we can let user know if it has a semi-valid email format
        public static bool IsValidEmail(string temp)
        {
            //assume true, but look for bad stuff to make it false
            bool blnResult = true;

            //Look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            //temp = scott@neit.ca
            // length = 13
            // position of last period = 10

            //Look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");

            //check for minimum length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2)    //if it is -1, not found and needs at least 2 chars in front
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsMinimumAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsMinimumAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsMinimumAmount(string temp, int min)
        {
            bool blnResult;

            if (temp.Length >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsExactLength(string temp, int expectedLength)
        {
            bool blnResult;

            int tempLength = temp.Length;

            if (tempLength == expectedLength)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }

        public static bool IsInteger(string temp)
        {
            return Int64.TryParse(temp, out Int64 n);
        }

        public static bool IsValidFacebookURL(string temp)
        {
            bool blnResult;

            if (temp.Contains("facebook.com"))
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;
        }
    }
}
