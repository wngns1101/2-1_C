using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_06_Special
{
    internal class Student
    {
        #region Variable
        public string Name;
        public string Number;
        public double[] Scores = new double[3];
        #endregion Variable

        #region Method
        public double Average()
        {
            double sum = 0;
           /*
            for(int i=0; i< Scores.Length; i++)
            {
                sum += Scores[i];
            }
           */
           foreach(double data in Scores)
            {
                sum += data;
            }
            double avg = sum / Scores.Length;
            return avg;
        }
        #endregion Method




    }
}
