using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var n = Double.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(x => Int32.Parse(x));

            Console.WriteLine(a.Count(x => x > 0) / n);
            Console.WriteLine(a.Count(x => x < 0) / n);
            Console.WriteLine(a.Count(x => x == 0) / n);
        }
    }
}
