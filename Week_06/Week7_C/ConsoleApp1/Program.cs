using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static int Test(int A)
        {
            return 10;
        }

        static int Test(long A)
        {
            return 20;
        }

        static int Test(float A)
        {
            return 30;
        }

        static int Test(double A)
        {
            return 40;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Test(52273));
            Console.WriteLine(Test(52.273));
        }
    }
}
