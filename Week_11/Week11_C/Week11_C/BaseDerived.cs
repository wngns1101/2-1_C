using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11_C
{
    class DataBase : Object
    {
        private static int count = 0;
        protected readonly int Seq;
        
        public string Name { get; set; }
        public string Phone { get; set; }
        
        public DataBase(string name) //번호 자동 할당
        {
            this.Seq = count++;
            this.Name = name;
        }

    }
    class Data : DataBase
    {
        public Data(string name)
            : base(name)
        {
            Console.WriteLine(Seq); //proctectec 여서 접근 가능
        }
    }
    class DataEx:DataBase
    {        
        public string Address { get; set; }

        public DataEx(string name)
            : base(name)
        {

        }
    }
    class DataExWithEmail : DataBase
    {
        public string Address { get; set; }
        public string Email {get; set; }

        public DataExWithEmail(string name)
            : base(name)
        {

        }
    }
}
