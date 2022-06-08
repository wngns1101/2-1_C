using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_C_1
{
    class Parent
    {
        public int variables = 123;

        public void Method1()
        {
            Console.WriteLine(456);
        }

        public virtual void Method2()//가상함수
        {
            Console.WriteLine(789);
        }
    }

    class Child : Parent //base:Parent, derived class:Child
    {
        public new string variables = "ABC"; //variable hiding(부모 변수 숨김)

        public new int Method1() //method hiding(부모 메소드 숨김)
        {
            Console.WriteLine("DEF");
            return 0;
        }

        public override void Method2() //method overriding(부모 메소드 없앰)
        {
            Console.WriteLine("GHI");            
        }
    }

    internal class Program
    {
        static string name = "인하공업전문대학";
        static void Main(string[] args)
        {
            string name = "컴퓨터정보과";
            Console.WriteLine(name); //static 변수 name shadowing 됨.

            Parent p = new Child();
            Child c = (Child)p;

            Console.WriteLine("1 ----------------------");
            Console.WriteLine(p.variables);
            Console.WriteLine(c.variables);

            Console.WriteLine("2 ----------------------");
            p.Method1();//456
            c.Method1();//DEF

            Console.WriteLine("3 ----------------------");
            p.Method2();//GHI
            c.Method2();//GHI

            Console.WriteLine("4 ----------------------");
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);//dt.ToString()
            Console.WriteLine(p); //p.ToString()
            Console.WriteLine(((object)dt).ToString());
            Console.WriteLine(((object)p).ToString());
            //DateTime의 ToString()은 hiding일까? overriding일까?
        }
    }
}
