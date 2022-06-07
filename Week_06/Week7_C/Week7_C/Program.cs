using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_C
{
    class OverLoadingTest
    {
        public static int Add(int y)
        {
            return y + y;
        }
        //public static int Add(int x) // 메개변수의 개수 다르면 클래스 사용 가능
        //{
        //   return x + x;
        //}
        public static int Add(int x, int y) //메개변수만 다르다면 클래스 이름 같으면 사용 가능
        {
            return x + y;
        }
        public static int Add(int x, double y)
        {
            return (int)(x + y);
        }
    }
    class Test
    {
        

        public int Power(int x) //static 없으면 instance, instance 메소드는 바로 호출 불가능
        {
            //Console.WriteLine (x* x);
            return x * x;
        }

        public static int Power2(int x) //클래스 메소드
        {
            return x * x;
        }
    }
    internal class Program
    {
        public int Power3(int x) //static 없으면 instance, instance 메소드는 바로 호출 불가능
        {
            //Console.WriteLine (x* x);
            return x * x;
        }

        public static int Power4(int x) //클래스 메소드
        {
            return x * x;
        }

        static void Main(string[] args) // <- 클래스 메소드
        {
            //Power(10); 다른 클래스의 메소드 호출이 바로 불가능
            //Test.Power(10); 인스턴스 메소드는 class 이름으로 호출이 불가능
            Test t = new Test(); //인스턴스 생성 t가 해당 인스턴스를 제어
            t.Power(10);

            //Power2(2); // 다른 클래스에 있으니까 안 됨
            Test.Power2(2);
            //Test t2 = new Test();
            //t2.Power2(2); //인스턴스로는 클래스 메소드 호출 불가

            //Power3(5); //동일 클래스 내라도 클래스 메소드는 인스턴스 메소드 직접 호출 불가
            Program p1 = new Program();
            p1.Power3(5);

            Power4(3); //동일 클랫내의 같은 클래스 메소드는 가능 

            OverLoadingTest.Add(1);
            OverLoadingTest.Add(1, 2);
            OverLoadingTest.Add(1, 2.0);
            OverLoadingTest.Add(1.0, 2.0);

            Console.WriteLine();
            Console.WriteLine(1);
            Console.WriteLine(1.0);
            Console.WriteLine('1');
            Console.WriteLine("1");
        }
    }
}
