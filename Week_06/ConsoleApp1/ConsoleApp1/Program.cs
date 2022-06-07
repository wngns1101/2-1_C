using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // static이 붙어 있으면 클래스에서 호출 가능하지만 static이 없으면 클래스에서 호출 불가능
            // console 안에 있는 WriteLine 메소드 호출
            Console.WriteLine(++Product.TotalCount);
            
            Product p1 = new Product();
            p1.Name = "모니터";
            p1.Price = 1000000;

            Product p2 = new Product();
            p2.Name = "키보드";
            p2.Price = 320000;

            Product p3 = new Product();
            p3.Name = "모니터";
            p3.Price = 1000000;

            Product p4 = p2;
            p4.Name = "마우스";
            p4.Price = 100000;

            //클래스와 인스턴스는 초기화 할 필요 없음 == c언어의 전역변수와 똑같음
            //초기화 안 하면 클래스와 인스턴스는 null값이 들어감

            int a = 10 ; //지역변수는 반드시 초기화 해야함
            Console.WriteLine(a);

            Product p5 = new Product();
            Console.WriteLine(p5.Price);
            if(p5.Name == null)
            {
                Console.WriteLine("null");
            } else
            {
                Console.WriteLine("empty");
            }

            // 5-15 code
            Product p6 = new Product() { Name = "펜", Price = 1000 };

            //정적변수
            int b = Product.TotalCount;
            int c = p6.TotalCount;
            //인스턴스변수
            int d = p6.Price;
            int e = Product.Price;

        }
    }
}
