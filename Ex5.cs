using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
           string pattern = "abcdefghijklmnopqrstuvwxyz0123456789_";
           str = str.ToLower(); 
           bool result = true;  
           if (Char.IsDigit(str.First()))  
{
    Console.WriteLine("NO");
}
else
{
    for (int i = 0; i < str.Length; i++)        
    {
        result = pattern.Contains(str[i]);
        if (result == false)                     
        {
            break;                             
        }
    }
    if (result)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("NO");
    }
}
Console.ReadKey();
        }
    }
}
