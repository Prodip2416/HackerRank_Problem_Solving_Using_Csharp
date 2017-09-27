using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static string funnyString(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            int l = (s.Length - 1) - i;
            int a = (int)s[i];
            int b = (int)s[i + 1];
            int c = (int)s[l];
            int d = (int)s[l - 1];

            if (Math.Abs(a - b) != Math.Abs(c - d))
                return "Not Funny";
        }
        return "Funny";
    }

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string s = Console.ReadLine();
            string result = funnyString(s);
            Console.WriteLine(result);
        }
    }
}
