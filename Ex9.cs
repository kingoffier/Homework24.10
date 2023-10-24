using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = Console.ReadLine();
            string xy = str + str2;
            string result = string.Empty;
            string number = string.Empty;
            foreach (char item in xy)
            {
                if (!result.Contains(item))
                {
                    result += item;
                }
            }
            foreach (char item in result)
            {
                int count = 0;
                foreach (char symbol in xy)
                {
                    if (item == symbol)
                    {
                        count++;
                    }
                }
                if (count > 1 && Char.IsLetter(item))
                {
                    number += item;
                }

            }
            if (number == string.Empty)
            {
                Console.WriteLine("NO"); 
            }
            Console.WriteLine($"Символы строки {number} встречаются в строке '{str}' на слудующих позициях:");
            foreach (var item in number)
            {
                Console.WriteLine(str.IndexOf(item));
            }
            Console.WriteLine($"Символы строки {number} встречаются в строке '{str2}' на слудующих позициях");
            foreach(var item in number)
            {
                Console.WriteLine(str2.IndexOf(item));
            }
            Console.ReadKey();
        }
    }
}
