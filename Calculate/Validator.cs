using System.Text.RegularExpressions;
namespace Calculate
{
    public class Validator
    {
        #region CONSTANTES
        const string patternBinario = "^[0-1]+$";
        const string patternHexdecimal = "^[0-9a-fA-F]+$";
        const string patternDecimal = "^[0-9]+$";
        #endregion
        #region METODOS DE VALIDACIONES
        public static bool IsBinario(string valor)
        {
            return Regex.IsMatch(valor, patternBinario);
        }

        public static bool IsHexadeximal(string valor)
        {
            return Regex.IsMatch(valor, patternHexdecimal);
        }
        
        public static bool IsDecimal(string valor)
        {
            return Regex.IsMatch(valor, patternDecimal);
        }
        #endregion
    }
}
