using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Car[] cars = new Car[5];

        private void btnArrive_Click(object sender, EventArgs e)
        {
            tbxView.Text = string.Empty;

            if (string.IsNullOrEmpty(tbxNumber.Text))
            {
                MessageBox.Show("차 번호가 입력되지 않았습니다.");
                return;
            }

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null && cars[i].CarNumber == tbxNumber.Text)
                {
                    MessageBox.Show("차량이 중복되었습니다.");
                    return;
                }
            }

            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    cars[i] = new Car();
                    cars[i].CarNumber = tbxNumber.Text;
                    cars[i].InTime = DateTime.Now;

                    tbxView.Text += ("입력 수행");
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"입력된 차: {cars[i].CarNumber}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"입차 시간: {cars[i].InTime}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;

                    return;
                }
            }
            MessageBox.Show("풀방");

        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNumber.Text))
            {
                MessageBox.Show("차 번호가 입력되지 않았습니다.");
                return;
            }
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null && tbxNumber.Text == cars[i].CarNumber)
                { 
                    cars[i].OutTime = DateTime.Now;
                    Car car = cars[i];
                    cars[i] = null;

                    tbxView.Text += ("출차 진행");
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"출차 차량: {car.CarNumber}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += $"나가는 시간: {car.OutTime}";
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    return;
                }
            }
            MessageBox.Show("등록이 안 된 차량입니다. ");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            tbxView.Text = "[주차현황]\r\n\r\n";

            for (int i = 0; i < cars.Length; i++)
            {

                tbxView.Text += $"[{i + 1}] 주차상태 : ";

                tbxView.Text += cars[i] == null ? "-" : cars[i].CarNumber;

                tbxView.Text += Environment.NewLine;

            }
        }
    }
}
