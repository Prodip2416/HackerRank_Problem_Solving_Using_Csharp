using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVeryBigSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);
        }
        static long aVeryBigSum(int n, long[] ar)
        {
            Int64 total = 0;

            for (int i = 0; i < n; i++)
            {
                total += ar[i];
            }
            return total;
        }
    }
}
