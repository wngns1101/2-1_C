using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_02_leejuhoon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;
        double[] scores = new double[10];

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //배열에 들어갈 수 있는 공간이 있는지 확인
            if (index >= scores.Length)
            {
                lblOutput.Text = "더 이상 입력할 수 없어!";
                return;
            }
            //string형태의 점수를 double형태를 변환해야.
            //tbxScore.Text == String type
            //scores배열 == double type

            double cnvdata = double.Parse(tbxScore.Text);
            //점수의 범위를 비교
            if (cnvdata < 0.0 || cnvdata > 100.0)
            {
                lblOutput.Text = "0~100사이의 점수만 입력하세요.";
                return;
            }
            scores[index++] = cnvdata;
            lblOutput.Text = $"{cnvdata}점을 입력했습니다";
            //index++;

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lblOutput.Text = String.Empty;
            //조회할 내용이 있는지 확인
            if(index == 0)
            {
                lblOutput.Text = "조회할 내용이 없습니다";
                return;
            }

            
            //성적의 max. 성적 min

            
            lblOutput.Text = "총 입력수:" + index + "명" + Environment.NewLine;
            double max = 0.0;
            double min = 100;
            
            double sum = 0; 
            for (int i = 0; i < index; i++)
            {
                sum += scores[i]; 
                if(max < scores[i])
                {
                    max = scores[i];
                }
                if(min > scores[i])
                {
                    min = scores[i];
                }
                lblOutput.Text += $"{i+1}번: {scores[i]}점";
                lblOutput.Text += Environment.NewLine;
            }
            lblOutput.Text += $"평균:{sum / index}";
            lblOutput.Text += Environment.NewLine;
            lblOutput.Text += $"최고점:{max}점/ 최저점:{min}점";
        }
    }
}
