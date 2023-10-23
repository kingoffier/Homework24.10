using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string pattern = "0123456789";
            string result = string.Empty;
            foreach (char item in str)
            {
                if (Char.IsDigit(item))
                {
                    if (!result.Contains(item))
                    {
                        result += item;
                    }
                }

            }
            foreach (char item in result)
            {

                pattern = pattern.Replace(item.ToString(), string.Empty);

            }
            if(pattern == string.Empty)
            {
                pattern = "NO";
            }
            Console.WriteLine(pattern);
        }
    }
}
