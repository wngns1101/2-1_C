using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_week5_leejuhoon
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        int index = 1;       
        Car[] cars = new Car[5];

        private void btnArrive_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbxNumber.Text))
            {
                MessageBox.Show("차량번호를 넣으세요");
                return;
            }
            if (index > cars.Length)
            {
                MessageBox.Show("입력 불가");
                return;
            }
            for (int i = 0; i < cars.Length; i++)
            {
                
                if (cars[i] == null || cars[i].Carnumber == "-")
                {
                    cars[i] = new Car();
                    cars[i].Carnumber = tbxNumber.Text;
                    cars[i].InTime = DateTime.Now;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"차량번호: {cars[i].Carnumber}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"입차시간: {cars[i].InTime}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"입차 처리를 완료했습니다.";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    index++;
                    return;
                }
                if (cars[i].Carnumber == tbxNumber.Text)
                {
                    MessageBox.Show("이미 등록된 차량입니다.");
                    return;
                }
            }
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNumber.Text))
            {
                MessageBox.Show("차량번호를 넣으세요");
                return;
            }

            

            for (int i = 0; i < cars.Length; i++)
            {

                  if (cars[i].Carnumber == tbxNumber.Text)
                {
                    cars[i].OutTime = DateTime.Now;
                    tbxView.Text += $"차량번호: {cars[i].Carnumber}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"입차시간: {cars[i].InTime}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"출차시간: {cars[i].OutTime}";
                    tbxView.Text += Environment.NewLine;
                    cars[i].Carnumber = "-";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"출차 처리를 완료했습니다.";
                    tbxView.Text += Environment.NewLine;
                    return;
                }
                  /*
                if (cars[i] == null || cars[i].Carnumber == "-"){
                    return;
                }
                if(cars[i].Carnumber != tbxNumber.Text)
                {
                    MessageBox.Show("등록된 차량이 없습니다.");
                }
                  */
            }
        }
    
    private void btnView_Click(object sender, EventArgs e)
    {
        tbxView.Clear();

        tbxView.Text += "[주차현황]";
        tbxView.Text += Environment.NewLine;
        tbxView.Text += Environment.NewLine;

        int i = 0;

        while (i < cars.Length)
        {


            if (cars[i] == null)
            {
                return;
            }
            tbxView.Text += $"[{(i+1)}] 주차상태: {cars[i].Carnumber}";
            tbxView.Text += Environment.NewLine;


            if (i == 4)
            {
                break;
            }
            else
            {
                i++;
            }

        }
    }
}
}





