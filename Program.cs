using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello mate,im here just to try jenkins");
            justPrint();
            justTakeInt(858);

           //return 0;      //just for testing jenkins
        }

        static void justPrint()
        {
            Console.WriteLine("HELLO");
        }

       static void justTakeInt(int i)
        {
            Console.WriteLine("This is a " + i);
        }
    }
}

