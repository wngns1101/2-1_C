using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Test
    {
        const int MAXCOUNT = 10; //+static 인스턴스 만들어 줄 필요 없음
        readonly int ID; // 선언과 동시에 초기화할 필요가 없음, 생성자에서 초기화 가능

        public Test(int id)
        {
            ID = id;
        }

        public void DoTest()
        {

            //const int DATA1;         // const는 무조건 값을 입력해주어야함
            const int DATA = 10;       // 상수: 10, 20, DATA 
            Console.WriteLine(DATA);   // 조회
            //DATA = 20;               // 입력
                                       // CONST는 컴파일이 안 됨 그래서 입력이 안 되는 것
        }
    }
}
