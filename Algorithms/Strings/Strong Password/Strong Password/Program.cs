using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Strong_Password
{
    class Program
    {

        public static int MinimumNumber(string password)
        {
            var match = password.IndexOfAny(new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+' }) != -1;
            int count = 0;
            if (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit) && password.Length > 6 && match == true)
            {
                count = 0;
            }
            else
            {
                if (String.IsNullOrEmpty(password))
                {
                    count = 6;
                }
                else
                {
                    if (!password.Any(char.IsLower))
                    {
                        count++;
                    }
                    if (!password.Any(char.IsUpper))
                    {
                        count++;
                    }
                    if (!password.Any(char.IsDigit))
                    {
                        count++;
                    }
                    if (match == false)
                    {
                        count++;
                    }

                }
                if (password.Length < 6)
                {
                    int wcount = 6 - password.Length;
                    count = wcount > count ? wcount : count;
                }
            }
            return count;
        }

        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();
            int answer = MinimumNumber(password);
            Console.WriteLine(answer);
            Console.ReadLine();
        }

    }
}
