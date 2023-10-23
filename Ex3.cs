using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string result = String.Empty;
            foreach (char item in str)
            {
                if (char.IsDigit(item))
                {
                    if (!result.Contains(item))
                    {
                        result += item;
                    }
                }
            }
            if(result == String.Empty)
            {
                result = "NO";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
