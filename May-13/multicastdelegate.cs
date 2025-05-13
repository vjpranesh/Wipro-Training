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
        // define tow methods that have the same signature as CustomDel
        static void Hello(string s)
        {
            Console.WriteLine($" Hello, {s}!");
        }
        static void Goodbye(string s)
        {
            Console.WriteLine($" Goodbye, {s} !");
        }
        static void Main()
        {
            // declare instances of the custom delegate
            CustomDel hiDel, byeDel, multiDel;

            hiDel = Hello;

            //create the delegate object byeDel that reference the 
            //method Goodbye

            byeDel = Goodbye;

            // the two delegates, hiDel and byeDel are combined to form multiDel

            //MULTICAST DELEGATE 
            multiDel = hiDel + byeDel;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");

            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");

            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
        }
    }
}

