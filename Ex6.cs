using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str=Console.ReadLine();
            string result=string.Empty;
            int i = result.Length;
            foreach(char item in str)
            {
                if (!result.Contains(item))
                {
                    result += item;
                    i++;
                }
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
