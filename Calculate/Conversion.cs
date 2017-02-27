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
                    resultado = BinarioToHexadecimal(v);
                    break;
                case "HEXADECIMAL - BINARIO":
                    resultado = HexadecimalToBinario(v);
                    break;
                case "HEXADECIMAL - DECIMAL":
                    resultado = HexadecimalToDecimal(v);
                    break;
                case "DECIMAL - HEXADECIMAL":
                    resultado = DecimalToHexadecimal(v);
                    break;
            }
            return resultado;
        }

        static string DecimalToBinario(string v)
        {
            string result = "";
            string aux = v;
            // valor binario 
            result = Convert.ToString(Convert.ToInt32(aux, 10), 2);
            return result;
            //string result = "";
            //Int64 aux = Convert.ToInt64(v); // seteo temporal
            //if (aux > 0)
            //{
            //    while (aux > 0)
            //    {
            //        result = (aux % 2) + result;
            //        aux /= 2;
            //    }
            //}
            //else if (aux < 0)
            //{
            //    result = "INGRESAR SOLO NUMERO POSITIVOS";
            //}
            //else
            //{
            //    result = "0";
            //}
            //return result;
        }

        static string BinarioToDecimal(string v)
        {
            string result = "";
            string aux = v;
            // valor binario 
            result = Convert.ToString(Convert.ToInt32(aux, 2));
            return result;

            // FORMA EXTENDIDA
            //string result = "";
            //Int64 sumatoria = 0;
            //string aux = v;
            //char[] cr = aux.ToArray<char>();
            //int pow  = aux.Length - 1;
            //int lengthNum = aux.Length;
            //for (int a = 0; a < lengthNum; a++)
            //{
            //    if (cr[a] == '1')
            //    {
            //        Console.WriteLine("arra: "+cr[a]);
            //        sumatoria += Convert.ToInt32(Math.Pow(2, pow));             
            //    }
            //    pow--;
            //}
            //result = Convert.ToString(sumatoria);
            //return result;
        }

        static string BinarioToHexadecimal(string v)
        {
            string result = "";
            string aux = v;
            // convierto a binario y luego a hexadecimal
            result = Convert.ToString(Convert.ToInt32(aux, 2), 16).ToUpper();
            return result;


            // OTRA FORMA 
            //Dictionary<int,string> letter = new Dictionary<int, string>();
            //letter.Add(10, "A");
            //letter.Add(11, "B");
            //letter.Add(12, "C");
            //letter.Add(13, "D");
            //letter.Add(14, "E");
            //letter.Add(15, "F");


            //int lengthNum = aux.Length;
            //Console.WriteLine("tam: " + lengthNum);
            //if (lengthNum > 4)
            //{
            //}
            //else {
            //    int val = Convert.ToInt32(BinarioToDecimal(v));
            //    if (val>9)
            //    {
            //        result = letter.ContainsKey(val)?letter[val]:"";
            //    }
            //    else
            //    {
            //        result = Convert.ToString(val);
            //    }
            //}
        }

        static string HexadecimalToBinario(string v)
        {
            string result = "";
            string aux = v;
            result = Convert.ToString(Convert.ToInt64(aux, 16), 2);
            return result;
        }

        static string HexadecimalToDecimal(string v)
        {
            string result = "";
            string aux = v;
            // convierto a hexadecimal y luego a hexadecimal
            result = Convert.ToString(Convert.ToInt64(aux, 16), 10);
            return result;
        }

        static string DecimalToHexadecimal(string v)
        {
            string result = "";
            string aux = v;
            // convierto a hexadecimal y luego a hexadecimal
            result = Convert.ToString(Convert.ToInt64(aux, 10), 16);
            return result;
        }
    }
}
