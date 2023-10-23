using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вашу строку");
            string str=Console.ReadLine();
            string punct = ".,;:!?";
            int i = 0;
            foreach (char item in str)
            {
                if (punct.Contains(item))
                {
                    i++;
                }
            }
            Console.WriteLine(i);
        }
    }
}

