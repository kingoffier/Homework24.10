using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string result = String.Empty;
            foreach(char item in str)
            {
                if (!result.Contains(item))
                {
                    result += item;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
