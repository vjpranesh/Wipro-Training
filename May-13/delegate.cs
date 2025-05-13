using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_delegate
{
    delegate void CustomDel(string s);

    class TestClass
    {
        static void Hello(string s)
        {
            Console.WriteLine($" Hello, {s}!");
        }
        static void Main()
        {
            CustomDel hiDel;

            hiDel = Hello;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
        }
    }
}

