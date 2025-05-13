using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Simple_delegate
{
    class Action
    {


        public static void Main()
        {
            Action<int> printActionDel = ConsolePrint;
            Action<int> printToPrinter = PrinterPrint;

            printActionDel(10);
            printToPrinter(45);
            Console.Read();
        }
    

        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        public static void PrinterPrint(int i)
        {
            Console.WriteLine("This is being printed to the printer");
        }
    }
}







    
            
            

