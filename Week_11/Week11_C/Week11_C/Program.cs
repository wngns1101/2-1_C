using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_C
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<Data> list1 = new List<Data>();
            //List<DataEx> list2 = new List<DataEx>(); // 셋다 DataBase 타입 가지고 있음
            //List<DataExWithEmail> list3 = new List<DataExWithEmail>();

            //list1.Add(new Data() { Name = "A", Phone = "000-1111-2222" });
            //list2.Add(new DataEx() { Name = "B", Phone = "000-1111-2222", Address="주소" });
            //list3.Add(new DataExWithEmail() { Name = "C", Phone = "000-1111-2222", Email = "주소" });

            //foreach(var item in list1)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in list3)
            //{
            //   Console.WriteLine(item.Name);
            //}

            List<DataBase> list = new List<DataBase>();
            list.Add(new Data("A") { Phone = "----" });
            list.Add(new DataEx("B") {Phone = "----", Address="000" });
            list.Add(new DataExWithEmail("C") {Phone = "----", Email = "aijfafd" });

            foreach(var item in list) //var DataBase 타입
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Phone);
                if(item is DataEx) //is
                {
                    Console.WriteLine(((DataEx)item).Address);
                }

                var withEmail = item as DataExWithEmail; //as
                if(withEmail != null)
                {
                    Console.WriteLine(withEmail.Address);
                    Console.WriteLine(withEmail.Email);
                }
                
            }

            DataBase d1 = new Data();
            DataBase d2 = new Data();
            Console.WriteLine(d1.Name);
            Console.WriteLine(d2.Name);
            //Console.WriteLine(d1.Address);
            //Console.WriteLine(d2.Address);

            Console.WriteLine(1.ToString());
            Console.WriteLine("1".ToString());
            Console.WriteLine((new Random()).ToString());
            Console.WriteLine(list.ToString());
            Console.WriteLine(d1.ToString());

        }
    }
}
