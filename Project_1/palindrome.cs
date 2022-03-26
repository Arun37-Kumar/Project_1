using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
     class palindrome
    {
        public static void Pal()
        {
            int reverse = 0;
            int remainder = 0;
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int originalNumber = number;
            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }

            if ( reverse == originalNumber)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not Palindrome Number");
            }
            
        }

    }
}
