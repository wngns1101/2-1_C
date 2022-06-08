using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_C_4
{
    internal class Program
    {
        static void Test1(int a) { a++; }

        static void Test2(ref int a){ a++;}

        static bool IntTryParse(string src, out int dst)
        {
            try {
                dst = int.Parse(src);
                return true;
            } catch {
                dst = 0;
                return false;
            }
        }

        static void Main(string[] args)
        {
            int a = 10; 
            Test1(a); Console.WriteLine(a);
            Test2(ref a); Console.WriteLine(a);


            int result1;
            bool result2;

            result2 = IntTryParse("12삼", out result1);
            Console.WriteLine(result2 + "/" + result1);

            result2 = IntTryParse("123", out result1);
            Console.WriteLine(result2 + "/" + result1);
        }
    }
}
