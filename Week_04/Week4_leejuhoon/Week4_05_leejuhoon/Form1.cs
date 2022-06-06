using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_05_leejuhoon
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        int index = 0;
        Student[] students = new Student[5];


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (index >= students.Length)
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
            /*
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null) continue; 
                if (students[i].Number == tbxNumber.Text)
                {
                    lblOutput.Text = "동일 학번 입력 불가";
                    return;
                }
            }
            */
            foreach(Student stu in students)
            {
                if (stu == null)
                {
                    continue;
                }
                if(stu.Number == tbxNumber.Text)
                {
                    lblOutput.Text = "동일학번 입력불가!";
                    return;
                }
            }
            Student student = new Student();
            
            student.Name = tbxName.Text;
            student.Number = tbxNumber.Text;
            student.Scores[0] = kor;
            student.Scores[1] = eng;
            student.Scores[2] = mat;

            students[index] = student;

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

            foreach(Student stu in students) //for (int i = 0; i < index; i++)
            { // 학생 0~9
                if(stu == null)
                {
                    continue;
                }

                double sum_stu = 0, avg_stu = 0;

                lblOutput.Text += $"[{stu.Number}]{stu.Name} 학생:";


                for (int j = 0; j < stu.Scores.Length; j++)
                { //과목 0~2
                    lblOutput.Text += $"{stu.Scores[j],8:F1}점 ";
                    sum_stu += stu.Scores[j];
                }
                avg_stu = sum_stu / stu.Scores.Length;
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

    }
}
