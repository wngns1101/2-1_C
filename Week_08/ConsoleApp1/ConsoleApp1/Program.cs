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
            Product[] arrProd = new Product[3];
            List<Product> listProd = new List<Product>();

            for(int i = 0; i < arrProd.Length; i++) //length는 배열만 쓴다
            {
                arrProd[i] = new Product(i.ToString(), "1", 2);
            }
            for (int i = 0; i < 3; i++)
            {
                listProd.Add(new Product(i.ToString(), "2", 3));//추가
                //listProd.Insert(0, new Product(i.ToString(), "2", 3));//삽입
            }

            //데이터 확인
            for(int i=0; i < arrProd.Length; i++)
            {
                Console.WriteLine(arrProd[i]);
            }
            for(int i = 0; i < listProd.Count; i++)
            {
                Console.WriteLine(listProd[i]);
            }

            //데이터 삭제
            for(int i =0; i < arrProd.Length; i++)
            {
                arrProd[i] = null;
            }

            //for (int i = 0; i < listProd.Count; i++)// count는 현재의 갯수 가변길이라 지우면서 카운트의 개수가 줄어둠
            //{
            //    //Remove/RemveAt()
            //    listProd.RemoveAt(i);
            //}

            var count = listProd.Count;
            for(int i=0; i<count; i++)
            {
                listProd.RemoveAt(0);
            }
            
            Product p1 = new Product("A1234", "노트북", 1_200_000);
            Product p2 = new Product("A1235", "키보드", 220_200, 100);
            
            p1.Price = 130_000;
            //p1.SetPrice(130_000); //인터럽트: 호출 했을 때 메인이 멈추는 것을 의미
            
            Console.WriteLine(p1.Price);
            Console.WriteLine(Product.ProdCount);
            
            if (p2.DecreaseStock(100000))
            {
                Console.WriteLine("판매완료");
            } else {
                Console.WriteLine("판매불가");
            }

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
        }
    }
}
