using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 3 == 0 || i % 3 == 2)
                {
                    if (s[i] != 'S') count++;
                }
                else
                {
                    if (s[i] != 'O') count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
