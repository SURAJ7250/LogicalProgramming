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
                Console.WriteLine("Select program\n 1. fibonacci series\n 2. perfect number\n 3. prime number\n 4. reverse number\n 5. temperature conversion\n 6.MonthlyPayment\n 7.CouponNumbers\n 8.Daysofweek");
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
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.PrimeNumCheck();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Number();
                        break;
                    case 5:
                        TemperatureConversion temperatureConversion = new TemperatureConversion();
                        temperatureConversion.Conversion();
                        break;
                    case 6:
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.Payment();
                        break;
                    case 7:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        couponNumbers.DistinctCouponNumber();
                        break;
                    case 8:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Days();
                        break;
                    default:
                        Console.WriteLine("Select correct option");
                        break;
                }
            }
        }
    }
}
