using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Cat
    {
        private const double MAX_WEIGHT = 20; //+static
        private static int Count; //인스턴스 변수는 고양이가 만들어져야지 생성됨 고양이의 마릿수는 0도 있어야 하기 때문에 static으로 사용
        private string Name; //인스턴스 변수는 100마리 만들면 name이 100마리 생김, static을 붙이면 100마리를 만들어도 이름이 100마리가 다 똑같음
        private double Weight;

        public static int GetCount() //getter
        {
            return Count;
        }
        public string GetName() //getter
        {
            return Name;
        }
        public double GetWeight() //getter
        {
            return Weight;
        }

        private void SetWeight(double weight) //setter
        {
            this.Weight = weight;
            if(Weight > MAX_WEIGHT)
            {
                this.Weight = MAX_WEIGHT;
            }
        } 

        public void Eat(double feed)
        {
            if (feed > 5)
            {
                feed = 5;
            } else if(feed < 0)
            {
                feed = 0;
            }
            Weight += (feed / 10);

            if(Weight > MAX_WEIGHT)
            {
                Weight = MAX_WEIGHT;
            }
        }

        public Cat() //기본 생성자
        {
            Count++;
        }
        public Cat(double weight)
        {
            Count++;
            this.Weight = weight;
        }
        public Cat(string name, double weight)
        {
            Count++;
            this.Name = name;
            this.Weight = weight;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine($"고양이 수: {Cat.Count}");
            Console.WriteLine($"고양이 수: {Cat.GetCount()}");
            
            //Console.WriteLine($"고양이 이름: {Cat.Name}");

            Cat c1 = new Cat("키티", 3.5);
            //c1.Name = "키티";
            //c1.Weight = 1.5;
            c1.Eat(4.2);
            Console.WriteLine($"이름: {c1.GetName()}");
            Console.WriteLine($"무게: {c1.GetWeight()}");

            Cat c2 = new Cat("고니", 1.2);
            Console.WriteLine($"이름: {c2.Name}");
            Console.WriteLine($"무게: {c2.Weight}");

            Cat c3 = new Cat("나비", 2.3);
            Console.WriteLine($"이름: {c3.Name}");
            Console.WriteLine($"무게: {c3.Weight}");

            Console.WriteLine($"고양이 수: {Cat.GetCount()}");
        }
    }
}
