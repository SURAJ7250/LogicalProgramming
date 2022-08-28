using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class PerfectNumber
    {
        int numCheck = 0;
        public void Number()
        {
            Console.WriteLine("Enter the number to check either its perfect num or not");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    numCheck += i;
                }
            }
            if (numCheck == num)
                Console.WriteLine("It is a perfect number");
            else
                Console.WriteLine("It is not a perfect number");
        }
    }
}