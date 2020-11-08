using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class FirstHello
    {
        static void Main(string[] args)
        {
            string firstname = "veera";
            string lastname = "muthu";
            string fullname = firstname + " " + lastname;
            Console.WriteLine("Hello");
            Console.WriteLine(fullname);
            Console.ReadLine();
        }
    }
}
