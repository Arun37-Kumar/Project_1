using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int a = Reverse.FindReverse();
            Console.WriteLine(a);
            Console.ReadLine();
            Human.Work();
            palindrome.Pal();
            Console.ReadLine();
        }
    }
}
