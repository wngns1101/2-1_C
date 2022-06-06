using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_03_leejuhoon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //3*10

        //double[] kor = new double[10];
        //double[] eng = new double[10];
        //double[] mat = new double[10];

        double[,] scores = new double[10, 3];
        int index = 0;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (index >= scores.GetLength(0)) //scores.Getlength(0) == 10
            {
                lblOutput.Text = "더 이상 입력을 할 수가 없습니다";
                return;
            }

            double kor, eng, mat;

            if (false == double.TryParse(tbxKor.Text, out kor)
              || false == double.TryParse(tbxEng.Text, out eng)
              || false == double.TryParse(tbxMat.Text, out mat))
            {
                lblOutput.Text = "숫자를 입력하세요!!!!";
                return;
            }

            if (kor < 0.0 || kor > 100.0
                || eng < 0.0 || eng > 100.0
                || mat < 0.0 || eng > 100.0) {
                lblOutput.Text = "0~100 사이의 점수를 넣어줘!";
                return;
            }

            scores[index, 0] = kor;
            scores[index, 1] = eng;
            scores[index, 2] = mat;

            index++;

            lblOutput.Text = $"국어:{kor} 영어:{eng} 수학:{mat}이 입력완료";
        }
            
                
        private void btnView_Click(object sender, EventArgs e)
        {
            lblOutput.Text = String.Empty;
            if (index == 0)
            {
                lblOutput.Text = "조회할 내용이 없음 ";
                return;
            }
            double sum = 0.0, avg = 0.0;
            double max = 0.0, min = 0.0;

            lblOutput.Text = $"총 입력 학생 수: {index}";
            lblOutput.Text += Environment.NewLine;

            for(int i = 0; i < index; i++) { // 학생 0~9
                double sum_stu = 0, avg_stu = 0;

                lblOutput.Text += $"{i + 1}번 학생";
                

                for (int j=0; j < scores.GetLength(1); j++) { //과목 0~2
                    lblOutput.Text += $"{scores[i, j],8:F1}점 ";
                    sum_stu += scores[i, j];
                }
                avg_stu = sum_stu / scores.GetLength(1);
                lblOutput.Text += $"평군:{avg_stu,8:F1}";
                lblOutput.Text += Environment.NewLine;

                sum += avg_stu;
                if(max < avg_stu)
                {
                    max = avg_stu;
                }
                if(min > avg_stu)
                {
                    min = avg_stu;
                }
                
            }
            avg = sum / index;
            lblOutput.Text += $"전체평균:{avg:F2} 최고점:{max:F2} 최저점:{min:F2}";
        }
    }
}
