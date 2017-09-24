using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_input= Console.ReadLine().Split(' ');
            long[] myArray = Array.ConvertAll(arr_input, Int64.Parse);
            long minSum = myArray.Sum() - myArray.Max();
            long maxSum = myArray.Sum() - myArray.Min();
            Console.WriteLine("{0} {1}", minSum, maxSum);

        }
    }
}
