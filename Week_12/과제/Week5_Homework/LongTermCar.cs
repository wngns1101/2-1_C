using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{
    internal class LongTermCar
        : Car
    {
        private DateTime _estimatedTime;
        public DateTime EstimatedTime
        {
            get { return _estimatedTime; }
        }
        public LongTermCar(string carnumber, int term) : base(carnumber)
        {
            _estimatedTime = (DateTime.Now).AddSeconds(term);
        }

        public override string ToString() // => base.ToString() + "*장기주차"; 
            {
            return base.ToString() + "\r\n*장기주차";
            }
        public override int Diff()
        {

            int seconds = 0;

            if(OutTime >= InTime)
            {
                if(EstimatedTime <= OutTime)
                {
                    seconds = (int)(OutTime - InTime).Seconds;
                } else
                {
                    seconds = (int)(EstimatedTime - InTime).Seconds;
                }
            } else
            {
                if(EstimatedTime >= DateTime.Now)
                {
                    seconds = (EstimatedTime - InTime).Seconds;
                }
                else
                {
                    seconds = (DateTime.Now - InTime).Seconds;
                }
            }

            return seconds;
            
            /*
            int cal = 0;
            if (OutTime >= InTime)
            {
                if (OutTime > EstimatedTime)
                {
                    cal = (int)(OutTime - InTime).TotalSeconds;
                } 
                if (EstimatedTime > OutTime)
                {
                    cal = (int)(EstimatedTime - OutTime).TotalSeconds;
                }
                
            }
            else
            {
                if (DateTime.Now > EstimatedTime)
                {
                    cal = (int)(DateTime.Now - InTime).TotalSeconds;
                }
                if (EstimatedTime > DateTime.Now)
                {
                    cal = (int)(EstimatedTime - DateTime.Now).TotalSeconds;
                }
            }

            return cal;
            */
        }

        public override int GetPrice()
        {
            return Diff() * 8;
        }
    }
}
