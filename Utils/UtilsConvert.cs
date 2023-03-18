namespace webservicedotnet.Utils
{
    public class UtilsConvert
    {
        public static bool IsNumeric(string number)
        {
            double result;
            bool isNumber = double.TryParse(number,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out result);
            return isNumber;    
        }

        public static decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}
