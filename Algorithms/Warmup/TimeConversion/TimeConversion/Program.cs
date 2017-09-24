using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
        static string timeConversion(string s)
        {
            DateTime dateTime = DateTime.ParseExact(s, "hh:mm:sstt",
    System.Globalization.CultureInfo.InvariantCulture);

        
            return dateTime.ToString("HH:mm:ss");
        }
    }
}
