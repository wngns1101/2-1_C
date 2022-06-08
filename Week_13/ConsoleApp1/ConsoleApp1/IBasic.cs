using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface IBasic
    {
        int TestInstanceMethod(); // 인터페이스 안에는 무조건 public 그래서 public 붙이지 않음 무조건 public이기 때문에

        /// <summary>
        /// 1. public 생략
        /// 2. property가 구현된 것이 아님.
        /// (자동구현 프로퍼티가 아님)
        /// </summary>

        int TestProperty { get; set; }


    }
}
