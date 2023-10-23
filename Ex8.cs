using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();
            string xy = str + str2;
            string pattern = "abcdefghijklmnopqrstuvwxyz";
            string result=string.Empty;
            foreach (char item in xy)
            {
                if (Char.IsLetter(item))
                {
                    if(!result.Contains(item))
                    {
                        result += item;
                    }
                }
            }
            foreach(char item in result)
            {
                pattern = pattern.Replace(item.ToString(), string.Empty);
            }
            if(pattern == string.Empty)
            {
                pattern = "()";
            }
           
            Console.WriteLine(pattern.ToUpper());
        }
    }
}
