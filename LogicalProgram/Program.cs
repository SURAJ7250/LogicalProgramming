using System;
namespace LogicalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming");
            while (true)
            {
                Console.WriteLine("Select program\n 1. fibonacci series\n 2. perfect number");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Series();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.Number();
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            }
        }
    }
}