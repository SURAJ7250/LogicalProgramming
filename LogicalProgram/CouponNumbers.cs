using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CouponNumbers
    {
        public void DistinctCouponNumber()
        {
            int[] arr = new int[10];
            int[] distArr = new int[10];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 11);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j]))
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    distArr[i] = arr[i];
                }
            }
            foreach (var data in distArr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }
    }
}
