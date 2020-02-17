using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practical2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern, name, country;
            pattern = @"[a-zA-Z]+";
            Match match;
            do
            {
                Console.Write("Enter your name : ");
                name = Console.ReadLine();
                match = Regex.Match(name, pattern);

            } while (!match.Success);

            do
            {
                Console.Write("Enter your country name : ");
                country = Console.ReadLine();
                match = Regex.Match(country, pattern);

            } while (!match.Success);

            Console.WriteLine("Hello " + name + ", Welcome to " + country);
            Console.Read();
        }
    }
}
