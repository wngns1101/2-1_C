using System;
using System.Collections;
using System.Collections.Generic;

namespace Week12_C_3
{
    internal class Program
    {
        public static void Test<T>(T a, T b, T c)//T:형식매개변수
        {
            List<T> list = new List<T>() {
                a, b, c
            };

            Console.WriteLine(typeof(T));
            foreach(var i in list) {
                Console.WriteLine(i);
            }
        }


        static void Main(string[] args)
        {

            Dictionary<string, double> dict
                = new Dictionary<string, double>();

            dict["1.1"] = 1.1; 
            dict.Add("2.2", 2.2);

            foreach(var keyval in dict) {
                Console.WriteLine(keyval.Key + "/" + keyval.Value);
            }

            Program.Test<double>(1.1, 2.2, 3.3);
            Program.Test<int>(1, 2, 3);
            Program.Test<string>("11", "22", "33");


            ArrayList arrList = new ArrayList();
            List<int> list = new List<int>();

            for (int i = 0; i < 3; i++) {
                if (i == 1) {
                    arrList.Add(i.ToString());
                    //list.Add(i.ToString());
                } else {
                    arrList.Add(i);
                }
                list.Add(i);
            }

            int sum1 = 0;
            int sum2 = 0;

            for(int j=0; j < 3; j++) {
                if (arrList[j] is int) {
                    sum1 += (int)arrList[j];
                }
                sum2 += list[j];
            }
        }
    }
}
