
using Øvelse4;

namespace Emma
{
    internal class Program
    {
        public static void Main()
        {
            byte inp = 0;
            Console.WriteLine($"Converting {inp} to binary {Converter.ConvertToByte(inp)}");

            inp = 255;

            Console.WriteLine($"Converting {inp} to binary {Converter.ConvertToByte(inp)}");
        }
    }
}
