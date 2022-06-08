using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{
    internal class ShortTermCar
       : Car
    {
        public ShortTermCar(string carnumber) : base(carnumber)
        {
            
        }

        public override int GetPrice()
        {
            int cal = Diff() * 10;
            return cal;
        }
    }
}
