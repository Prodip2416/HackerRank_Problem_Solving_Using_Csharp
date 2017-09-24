using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            int sum1 = 0;
            int sum2 = 0;
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
                sum1 += a[a_i][a_i];
                sum2 += a[a_i][(n - 1) - a_i];
            }
          
            int result = Math.Abs(sum1 - sum2);
            Console.WriteLine(result);

           

        }
    }
}
