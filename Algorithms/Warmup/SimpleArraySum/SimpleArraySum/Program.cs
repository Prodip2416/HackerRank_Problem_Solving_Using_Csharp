using System;


namespace SimpleArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
        }
        static int simpleArraySum(int n, int[] ar)
        {
            // Complete this function
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += ar[i];
            }
            return sum;
        }
    }
}
