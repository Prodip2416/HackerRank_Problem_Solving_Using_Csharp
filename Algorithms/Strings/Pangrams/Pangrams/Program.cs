using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower().Replace(" ", "");
            int[] arr = new int[26];
            for (int i = 0; (i < s.Length) && (s.Length >= 26); arr[Convert.ToInt16(s[i]) - 97]++, i++) ;
            Console.WriteLine(arr.Min() > 0 ? "pangram" : "not pangram");
        }
    }
}
