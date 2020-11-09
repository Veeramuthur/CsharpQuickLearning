using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class C3_swaptwonumbers
    {
        static void Main(string[] args)
        {
            int firstnumber = 7;
            int secondnumber = 2;
            int afterswap;

            afterswap = firstnumber;
            firstnumber = secondnumber;
            secondnumber = afterswap;
            Console.WriteLine("After swap:");
            Console.WriteLine("FirstNumber " + firstnumber);
            Console.WriteLine("SecondNumber " + secondnumber);

            Console.ReadLine();

        }
    }
}
