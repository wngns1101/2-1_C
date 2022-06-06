using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2_leejuhoon
{
    public partial class FrmMain : Form
    {
        int index = 0;
        Student[] students = new Student[3];

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (index >= students.Length)
            {
                MessageBox.Show("더 이상 입력할 수 없습니다.");
                return;
            }

            //Hw3.
            
            for (int j = 0; j < index; j++)
            {
                
                if (students[j].Number == tbxNumber.Text)
                {
                    MessageBox.Show("학번 중복입니다. 다시 입력해주세요.");
                    return;
                }
            }
            

            Student stu = new Student(); //생성자
            stu.Name = tbxName.Text;
            stu.Number = tbxNumber.Text;
            stu.Score = double.Parse(tbxScore.Text);

            tbxOutput.Text = $"{index+1}번 학생:{stu.Number}/{stu.Name}/{stu.Score}";

            students[index] = stu;

            index++;
        }

        private void btnAllView_Click(object sender, EventArgs e)
        {
            tbxOutput.Clear();
            foreach(Student s in students)
            {
                if(s == null)
                {
                    continue;
                }
                tbxOutput.Text += $"{s.Number}/{s.Name}/{s.Score}";
                tbxOutput.Text += Environment.NewLine;
            }
        }

        private void btnAllViewHw1_Click(object sender, EventArgs e)
        {
            //hw4 for
            tbxOutput.Clear();
            for(int k = 0; k < index; k++)
            {
                if (students[k] == null)
                {
                    continue;
                }
                tbxOutput.Text += $"{students[k].Number}/{students[k].Name}/{students[k].Score}";
                tbxOutput.Text += Environment.NewLine;
            }

        }

        private void btnAllViewHw2_Click(object sender, EventArgs e)
        {
            // while
            tbxOutput.Clear();
            int k = 0;
            while (k < index)
            {
                if (students[k] == null)
                {
                    break;
                }
                tbxOutput.Text += $"{students[k].Number}/{students[k].Name}/{students[k].Score}";
                tbxOutput.Text += Environment.NewLine;
                k++;
            }
        }
    }
}
