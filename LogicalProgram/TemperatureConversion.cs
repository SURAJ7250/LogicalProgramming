using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class TemperatureConversion
    {
        double f, c;
        public void Conversion()
        {
            Console.WriteLine("choose type of conversion\n 1. Fahrenheit to Celsius\n 2. Celsius to Fahrenheit");
            int conversion = Convert.ToInt32(Console.ReadLine());
            switch (conversion)
            {
                case 1:
                    Console.WriteLine("Enter fahrenheit temp", f);
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("Celsius temperature: " + c);
                    break;
                case 2:
                    Console.WriteLine("Enter celsius temp", c);
                    c = Convert.ToDouble(Console.ReadLine());
                    f = ((9 * c) / 5) + 32;
                    Console.WriteLine("Fahrenheit temperature: " + f);
                    break;
                default:
                    Console.WriteLine("Enter valid conversion");
                    break;
            }
        }
    }
}

