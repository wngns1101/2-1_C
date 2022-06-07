using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Zoo
    {

    }

    class Animal
    {
        public int Age
        {
            get;
            protected set; //내 코드를 공유하는 사람한테만 접근 허용
        }


        public void Eat() { Console.WriteLine("촵촵"); }
        public void Sleep() { Console.WriteLine("zzzz"); }

        public Animal()
        {
            Age = 0;
        }
    }

    class Cat
    {
        public int Age
        {
            get;
            private set;
        }

        public void Eat() { Console.WriteLine("촵촵"); }
        public void Sleep() { Console.WriteLine("zzzz"); }
        public void Meow() { Console.WriteLine("냥"); }

        public Cat()
        {
            Age = 0;
        }
    }
}

    class Dog: Animal
    {

        private double weight
        {
            get;
            set;
        }

        public void Bark() { Console.WriteLine("왈왈"); }

        public Dog()
        {
            Age = 0;
        }
    }

    class Cat
    {
        public int Age
        {
            get;
            private set;
        }

        public void Eat() { Console.WriteLine("촵촵"); }
        public void Sleep() { Console.WriteLine("zzzz"); }
        public void Meow() { Console.WriteLine("냥"); }

        public Cat()
        {
            Age = 0;
        }
    }
}
