using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Product
    {
        private static int prodCount; //총 제품의 종류 개수

        private readonly string number = null; //제품번호
        private string name = null; // 제품이름 
        private int price; // 제품가격
        private int stock; //보유수량


        // 변수 초기화 할 필요 없음 자동 초기화 int = 0, string = null
        #region TYPE1
        public Product(string number, string name, int price)
        {
            this.number = number;
            this.name = name;
            this.Price = price; // 대문자 P는 프로퍼티를 거침(필터 기능)
            prodCount++;
        }

        public Product(string nb, string nm, int pr, int st)
            :this(nb, nm, pr)
        {
            this.stock = st;
        }
        #endregion
        #region TYPE2
        /*
        public Product(string number, string name, int price)
            :this(number, name, price, 0)
        {
            //this.number = number;
            //this.name = name;
            //this.price = price;
            //prodCount++;
        }

        public Product(string nb, string nm, int pr, int st)
        {
            this.number = nb;
            this.name = nm;
            this.price = pr;
            this.stock = st;
            prodCount++;
        }
        */
        #endregion
        //public string GetNumber()
        //{
        //    return number;
        //}

        public string Number
        {
            get { return number; }
            //set { number = value; } 읽기 전용이라 겟만 생성
        }

        public string Name
        {
            get { return name; }
            
        }

        public int Price
        {
            get { return price;}
            set {
                if (0 < value && value <= 10_000_000)
                {
                    price = value;
                }
                else
                {
                    price = 0;
                }
            }
        }

        public static int ProdCount
        {
            get { return prodCount; }
        }

        public bool DecreaseStock(int count)
        {
            if(stock >= count) { 
            stock -= count;
            return true;
            } 
            else
            {
                return false;
            }
        }

        public bool IncreaseStock(int count)
        {
            stock += count;
            return true;
        }

    }
}
