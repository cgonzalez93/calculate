using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculate
{
    public class Validator
    { 
        public static bool IsBinario(string valor)
        {
            string pattern = "^[0-1]+$";
            if (Regex.IsMatch(valor, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool IsHexadeximal(string valor)
        {
            string pattern = "^[0-9a-fA-F]+$";
            if (Regex.IsMatch(valor, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static bool IsDecimal(string valor)
        {
            string pattern = "^[0-9]+$";
            if (Regex.IsMatch(valor, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
