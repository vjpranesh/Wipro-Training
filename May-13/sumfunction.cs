using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Simple_delegate
{
    public delegate int SomeOperation(int i, int j);

    class Function
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);
        }
    }
}




    
            
            

