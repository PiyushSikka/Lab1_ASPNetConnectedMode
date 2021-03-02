using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Lab1_ASPNetConnectedMode.VALIDATOR
{
    public static class Validation
    {
        public static bool IsValidId(string input)
        {
            if (input.Length != 4)
            {
                return false;
            }
            for (int i = 0; i <input.Length; i++)
            {
                if (Char.IsNumber(input[i]) == false)
                {
                    return false;
                }
            }
            return true;

        }
        public static bool IsValidName(string input)
        {
            if (input.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if ((char.IsDigit(input[i]))  || (char.IsWhiteSpace(input[i])))
                {
                    return false;
                }
            }
            return true;
        }
    }
}