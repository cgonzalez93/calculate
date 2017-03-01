using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Conversion
    {
        public static string Calculo(string v, string operacion)
        {
            string resultado = "";
            switch (operacion)
            {
                case "DECIMAL - BINARIO":
                    resultado = DecimalToBinario(v);
                    break;
                case "BINARIO - DECIMAL":
                    resultado = BinarioToDecimal(v);
                    break;
                case "BINARIO - HEXADECIMAL":
                    resultado = BinarioToHexadecimal(v).ToUpper();
                    break;
                case "HEXADECIMAL - BINARIO":
                    resultado = HexadecimalToBinario(v);
                    break;
                case "HEXADECIMAL - DECIMAL":
                    resultado = HexadecimalToDecimal(v);
                    break;
                case "DECIMAL - HEXADECIMAL":
                    resultado = DecimalToHexadecimal(v).ToUpper();
                    break;
            }
            return resultado;
        }
        #region METODOS DE CONVERSION
        static string DecimalToBinario(string v)
        {
            return Validator.IsDecimal(v) ? Convert.ToString(Convert.ToInt64(v, 10), 2) : "INGRESE NUM. DECIMAL";
        }

        static string BinarioToDecimal(string v)
        {
            return Validator.IsBinario(v)? Convert.ToString(Convert.ToInt32(v, 2)):"INGRESE NUM. BINARIO";
        }

        static string BinarioToHexadecimal(string v)
        {
            return Validator.IsBinario(v) ? Convert.ToString(Convert.ToInt64(v, 2), 16).ToUpper() : "INGRESE NUM. BINARIO";
        }

        static string HexadecimalToBinario(string v)
        {
            return Validator.IsHexadeximal(v) ? Convert.ToString(Convert.ToInt64(v, 16), 2) : "INGRESE NUM. HEXADECIMAL";
        }

        static string HexadecimalToDecimal(string v)
        {
            return Validator.IsHexadeximal(v) ? Convert.ToString(Convert.ToInt64(v, 16), 10) : "INGRESE NUM. HEXADECIMAL";
        }

        static string DecimalToHexadecimal(string v)
        {
            return Validator.IsDecimal(v) ? Convert.ToString(Convert.ToInt64(v, 10), 16) : "INGRESE NUM. DECIMAL";
        }
        #endregion
    }
}
