using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform3_leejuhoon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double kor = double.Parse(tbxKor.Text);
            double eng = double.Parse(tbxEng.Text);
            double mat = double.Parse(tbxMat.Text);

            double sum = kor + eng + mat;
            double avg = sum / 3;

            lblSum.Text = sum.ToString("0.00");
            lblAvg.Text = avg.ToString("F2");

            string msg;
            if(avg < 60)
            {
                msg = "불합격(F)";
            }
            else // avg >=60
            {
                msg = "합격";
                if(avg >= 90)
                {
                    msg = msg + "(A)"; //    "합격(A)"
                }
                else if(avg >= 80)
                {
                    msg = msg + "(B)";
;               }
                else if(avg >= 70)
                {
                    msg += "(C)";
                }
                else
                {
                    msg += "(D)";
                }
            }
            lblResult.Text = msg;
        }
    }
}
