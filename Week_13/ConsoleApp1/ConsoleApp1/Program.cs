using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestClass : IBasic
    {
        public int TestProperty
        {
            get; set;
        }

        public int TestInstanceMethod()
        {
            return 3;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IBasic a = new TestClass(); //부모 - 자식
            TestClass b = new TestClass();  //자식 - 자식
                                            //TestClass c = new IBasic(); //자식 - 부모는 안 됨

            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

            list.RemoveAt(2);  // [2]요소 제거

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

            list.Insert(2, 2);  // 인덱스, 값

            foreach (object obj in list)
                Console.Write("{0}", obj);
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Console.Write("{0}", list[i]);
            Console.WriteLine();
        }
    }
}
