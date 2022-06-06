using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_01_leejuhoon
{

    class UserInt
    {
        public int Number;

    }
    internal class Program
    {
        static void Main(string[] args) //프로그램 진입전. entry point
        {
            int[] arrInt = new int[4]; //value
            UserInt[] arrUserInt = new UserInt[4]; //reference

            //for(int i=0; i<arrInt.Length; i++)
            //{
            //    Console.WriteLine(arrInt[i]);
            //}
            
            for (int i = 0; i < arrUserInt.Length; i++)
            {
                Console.WriteLine(arrUserInt[i].Number);
            }

        }
    }
}
