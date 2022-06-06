using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_04_leejuhoon
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        double[,] scores = new double[10, 3];
        int index = 0;
        string[] numbers = new string[10];
        string[] names = new string[10];


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (index >= scores.GetLength(0))
            {
                lblOutput.Text = "입력 불가";
                return;
            }
            if (string.IsNullOrEmpty(tbxNumber.Text))
            {
                lblOutput.Text = "학번을 반드시 넣어주세요";
                tbxNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tbxName.Text))
            {
                lblOutput.Text = "이름을 반드시 넣어주세요";
                tbxName.Focus();
                return;
            }

            double kor, eng, mat;
            if (false == (double.TryParse(tbxKor.Text, out kor))
                || false == (double.TryParse(tbxEng.Text, out eng))
                || false == (double.TryParse(tbxMat.Text, out mat)))
            {
                lblOutput.Text = "숫자를 넣어주세요";
                return;
            }

            if (kor < 0.0 || kor > 100.0 || eng < 0.0 || eng > 100.0 || mat < 0.0 || mat > 100.0)
            {
                lblOutput.Text = "0~100 사이의 정수를 넣어주세요";
                return;
            }
            for(int i = 0; i < index; i++)
            {
                if (numbers[i] == tbxNumber.Text)
                {
                    lblOutput.Text = "동일 학번 입력 불가";
                    return;
                }
            }
            names[index] = tbxName.Text;
            numbers[index] = tbxNumber.Text;
            scores[index, 0] = kor;
            scores[index, 1] = eng;
            scores[index, 2] = mat;

            lblOutput.Text = $"[{tbxNumber.Text}]{tbxName.Text}";
            lblOutput.Text += Environment.NewLine;
            lblOutput.Text += $"국어:{kor} 영어:{eng} 수학:{mat}이 입력완료!";
            
            index++;
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

            for (int i = 0; i < index; i++)
            { // 학생 0~9
                double sum_stu = 0, avg_stu = 0;

                lblOutput.Text += $"[{numbers[i]}]{names[i]} 학생:";


                for (int j = 0; j < scores.GetLength(1); j++)
                { //과목 0~2
                    lblOutput.Text += $"{scores[i, j],8:F1}점 ";
                    sum_stu += scores[i, j];
                }
                avg_stu = sum_stu / scores.GetLength(1);
                lblOutput.Text += $"평군:{avg_stu,8:F1}";
                lblOutput.Text += Environment.NewLine;

                sum += avg_stu;
                if (max < avg_stu)
                {
                    max = avg_stu;
                }
                if (min > avg_stu)
                {
                    min = avg_stu;
                }

            }
            avg = sum / index;
            lblOutput.Text += $"전체평균:{avg:F2} 최고점:{max:F2} 최저점:{min:F2}";
        }

        private void tbxKor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
