using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse4
{
    internal class Converter
    {
        internal static string ConvertToByte(byte decimalValue)
        {
            string result = "";
            for (int i = 7; i >= 0; i--)
            { 
                if(Math.Pow(2, i)<= decimalValue)
                {
                    result += "1";
                    decimalValue -= Convert.ToByte(Math.Pow(2, i));
                }
                else
                {
                    result += "0";
                }
                
            }
            return result;
        }
    }
}
