using RPI;
using RPI.Controller;
using RPI.Display;
using RPI.Heart_Rate_Monitor;
using RPI.IO;
using System;

namespace Øvelse4
{
    internal class SevenSegsDisplay
    {
        static void Main(string[] args)
        {
            RPi rpi = new RPi();
            SevenSeg sevenSeg = new SevenSeg(rpi);
            Converter convertBCD = new Converter();

            sevenSeg.Init_SevenSeg();
            sevenSeg.Disp_SevenSeg(80);
            Console.ReadKey();
            sevenSeg.Close_SevenSeg();
        }
    }
}