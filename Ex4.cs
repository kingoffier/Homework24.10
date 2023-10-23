using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string number = string.Empty;
            string result = string.Empty;
            foreach (char item in str)
            {
                if (!result.Contains(item))
                {
                    result += item;
                }
            }
            foreach (char item in result)
            {
                int count = 0;
                foreach (char symbol in str)
                {
                    if (item == symbol)
                    {
                        count++;
                    }
                }
                if (count > 1 && Char.IsDigit(item))
                {
                    number += item;
                }

            }
            if (number == string.Empty)
            {
                number = "NO";
            }
        
            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
