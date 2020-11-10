using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class C4_ReverseNnumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Number = int.Parse(Console.ReadLine());
            int reverse = 0;
            while (Number>0)
            {
                int Remainder = Number % 10;
                reverse = (reverse * 10) + Remainder;
                Number = Number / 10;
            }
            Console.WriteLine("Reverse No. is {0}",reverse);
            Console.ReadLine();
        }
    }
}
