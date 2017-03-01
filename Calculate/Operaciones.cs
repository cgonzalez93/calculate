using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    public class Operaciones
    {
        public static string Calculo(string n1, string n2, string operacion) {

            #region VARIABLES
            string resultado = "";
            double val1 = 0;
            double val2 = 0;
            #endregion

            if (n1 != "" || n2 != "")
            {
                val1 = Convert.ToDouble(n1);
                val2 = Convert.ToDouble(n2);
                switch (operacion)
                {
                    case "SUMA":
                        resultado = Convert.ToString((val1 + val2));
                        break;
                    case "RESTA":
                        resultado = Convert.ToString((val1 - val2));
                        break;
                    case "MULTIPLICACION":
                        resultado = Convert.ToString((val1 * val2));
                        break;
                    case "DIVISION":
                        try
                        {
                            resultado = Convert.ToString(val1 / val2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            resultado = "IMPOSIBLE DIVIDIR ENTRE CERO: \nDetalle: "+ex;
                        }
                        break;
                    case "POTENCIA":
                        resultado = Convert.ToString(Math.Pow(val1, val2));
                        break;
                }
            }
            else
            {
                resultado = "HAY CAMPOS VACIOS";
            }


            return resultado;
        }
    }
}
