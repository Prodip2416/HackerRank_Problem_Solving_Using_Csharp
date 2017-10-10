using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SuperReducedString
{
    class Program
    {
        static string super_reduced_string(string s)
        {
            var chars = s.ToList();
            string answer = "";
            for (int i = 0; i < chars.Count() - 1; i++)
            {
                if (chars.ElementAtOrDefault(i) == chars.ElementAtOrDefault(i + 1))
                {
                    chars.RemoveAt(i + 1);
                    chars.RemoveAt(i);
                    i -= 2;

                }
            }
            foreach (var item in chars)
            {
                answer += item;
            }
            if (string.IsNullOrEmpty(answer))
            {
                return "Empty String";
            }
            else
            {
                return answer;
            }


        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);

        }
    }
}
