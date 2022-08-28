using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PrimeNumber
    {
        int count = 0;
        public void PrimeNumCheck()
        {
            Console.WriteLine("Enter the number to check either it is prime number or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    count++;
            }
            if (count == 2)
                Console.WriteLine("It is a prime number");
            else
                Console.WriteLine("It is not a prime number");
        }
    }
}