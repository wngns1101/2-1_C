using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_C_2
{
    abstract class Animal //추상 클래스 - 인스턴스 생성 불가 , 자료형으로는 사용 가능
    //sealed class Animal : 파생클래스 생성 불가
    //class Animal : 구상 클래스
    {
        public string Name { get; set; }
        public virtual void Test() { }
        public abstract void Eat();//추상메소드
    }

    class Cat : Animal {
        sealed public override void Test() {
            
        }

        public override void Eat()
        {
            Console.WriteLine("추르 쩝");
        }
    }

    class ExCat : Cat {
        //public override void Test() { } //Cat의 Test()가 sealed 처리되어 override 불가
    }

    class Dog : Animal
    {
        public override string ToString()
        {
            return Name;
        }

        public override void Eat()
        {
            Console.WriteLine("뻐다귀 ~");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>() {//추상클래스는 타입(형)으로는 사용 가능
                new Dog(){Name="개1"},
                new Cat(){Name="냥1"},
                new Cat(){Name="냥2"},
                new Dog(){Name="개2"},
                new Dog(){Name="개3"},
                new Cat(){Name="냥3"},
                //new Animal(){Name = "동물1"} 추상클래스는 인스턴스 생성 불가
            };

            foreach (var ani in animals) {
                Console.WriteLine(ani);
                ani.Eat();
                //Animal의 Eat()는 추상메소드지만
                //이를 상속받아서 만든 derived class에는
                //override한 Eat()가 있는 것을 보장                
            }
        }
    }
}
