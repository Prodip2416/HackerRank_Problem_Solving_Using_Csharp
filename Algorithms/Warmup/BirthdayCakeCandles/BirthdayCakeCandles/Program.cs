using System;
using System.Linq;

namespace BirthdayCakeCandles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
        static int birthdayCakeCandles(int n, int[] ar)
        {
            int max = ar.Max();
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (max == ar[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
