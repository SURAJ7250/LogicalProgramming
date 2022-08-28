using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        int firstNum = 0, secondNum = 1, thirdNum = 0;
        public void Series()
        {
            Console.WriteLine("Enter the number to print fibonacci series");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(firstNum + "\n" + secondNum);
            while (num > 0)
            {
                thirdNum = firstNum + secondNum;
                Console.WriteLine(thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
                num--;
            }
        }
    }
}
