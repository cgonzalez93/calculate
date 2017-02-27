using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Conversion
    {
        public static string Calculo(Int64 v, string operacion) {
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
                    resultado = "";
                    break;
                case "HEXADECIMAL - BINARIO":
                    try
                    {
                        resultado = "";
                    }
                    catch (DivideByZeroException ex)
                    {
                        resultado = "IMPOSIBLE DIVIDIR ENTRE CERO";
                    }
                    break;
                case "HEXADECIMAL - DECIMAL":
                    resultado = "";
                    break;
                case "DECIMAL - HEXADECIMAL":
                    resultado = "";
                    break;
            }
            return resultado;
        }

        static string DecimalToBinario(Int64 v) {
            string result = "";
            Int64 aux = v; // seteo temporal
            if (aux > 0)
            {
                while (aux > 0)
                {
                    if ((aux % 2) == 0)
                    {
                        result += "0" + result;
                    }
                    else
                    {
                        result += "1" + result;
                    }
                    aux = (aux / 2);
                }
            }
            else if (aux < 0)
            {
                result = "INGRESAR SOLO NUMERO POSITIVOS";
            }
            else {
                result = "0";
            }            
            return result;
        }

        static string BinarioToDecimal(Int64 v)
        {
            string result = "";
            Int64 sumatoria = 0;
            string aux = Convert.ToString(v);
            char[] cr = aux.ToArray<char>();
            int pow  = aux.Length - 1;
            int lengthNum = aux.Length;
            for (int a = 0; a < lengthNum; a++)
            {
                if (cr[a] == '1')
                {
                    sumatoria += Convert.ToInt32(Math.Pow(2, pow));             
                }
                pow--;
            }
            result = Convert.ToString(sumatoria);
            return result;
        }
    }
}
