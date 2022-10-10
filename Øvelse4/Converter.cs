using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
                if (Math.Pow(2, i) <= decimalValue)
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

        internal static int ConvertTwoDigitsToBCD(int value)
        {
            if (value < 0 || value > 99)
            {
                Console.WriteLine($"Value {value} out of bounds");
                return -1;
            }
            else
            {
                int _tens = value / 10;
                int _ones = value % 10;
                string bcd = Convert.ToString(_tens, 2).PadLeft(4, '0') + Convert.ToString(_ones, 2).PadLeft(4, '0');
                return Convert.ToInt16(bcd, 2);

            }
        }

        
        

    internal static int ConvertIntToBCD(int number10)
        {
            int BCD = 0;
            int shift = 0;
            while (number10 > 0)
            {
                BCD |= number10 % 10 << 4 * shift++;
                number10 /= 10;
            }
            return BCD;
        } 
    }
}
