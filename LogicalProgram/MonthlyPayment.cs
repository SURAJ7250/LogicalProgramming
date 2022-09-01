using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class MonthlyPayment
    {
        double P, Y, R, n, r, payment;
        public void Payment()
        {
            Console.WriteLine("Enter principle amount", P);
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number of year", Y);
            Y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter rate of interest", R);
            R = Convert.ToDouble(Console.ReadLine());
            n = (12 * Y);
            Console.WriteLine("Number: " + n);
            r = R / (12 * 100);
            Console.WriteLine("rate: " + r);
            payment = ((P * r) / (1 - Math.Pow(1 + r, -n)));
            Console.WriteLine("Monthly Payment: " + payment);
        }
    }
}
