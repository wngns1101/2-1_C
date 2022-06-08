using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Homework
{
    internal class Car
    {
        private readonly string carNumber;
        public string CarNumber
        {
            get { return carNumber; }
        }
        private DateTime inTime;
        public DateTime InTime
        {
            get { return inTime; }
        }
        private DateTime outTime;
        public DateTime OutTime
        {
            get { return outTime; }
        }

        public Car(String x, DateTime y)
        {
            carNumber = x;
            inTime = y;
        }

        public DateTime Out(DateTime x)
        {
            outTime = x;
            return outTime;
        }

        public int Diff(DateTime x)
        { 
            TimeSpan timeSpan = x - inTime;
            int secd = timeSpan.Seconds;
            return secd;
        }
    }
}
