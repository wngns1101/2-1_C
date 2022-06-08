using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_Homework
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        Car[] cars = new Car[5];
        //List<Car> cars = new List<Car>();
        bool IsEmptyCarNumber()
        {
            bool result = false;
            if (string.IsNullOrEmpty(tbxNumber.Text)) {
                MessageBox.Show("차량번호를 넣으세요.");
                result = true;
            }
            return result;
        }

        int SearchCar(string number)
        {
            int index = -1;
            for (int i = 0; i < cars.Length; i++) {
                if (cars[i] != null && cars[i].CarNumber == number) {
                    index = i;
                }
            }
            return index;
        }

        private void btnArrive_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = String.Empty;

            if (IsEmptyCarNumber()) {
                return;
            }

            if (-1 != SearchCar(tbxNumber.Text)) {
                MessageBox.Show("기존에 주차가 되어있는 차량입니다.");
                return;
            }

            for (int k = 0; k < 5; k++) {
                if (null == cars[k]) {
                    cars[k] = new Car(tbxNumber.Text, DateTime.Now);

                    tbxView.Text = "차량번호:" + cars[k].CarNumber;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += "입차시간:" + cars[k].InTime;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += Environment.NewLine;
                    tbxView.Text += "입차 처리를 완료했습니다.";

                    return;
                }
            }

            MessageBox.Show("풀방");
            #endregion
        }

        private void btnDeparture_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = String.Empty;

            if (IsEmptyCarNumber()) {
                return;
            }

            int i = SearchCar(tbxNumber.Text);
            if (-1 == i) {
                MessageBox.Show("없다!");
                return;
            } else {
                Car car = cars[i];
                DateTime set = car.Out(DateTime.Now);
                int secd = car.Diff(set);
                
                cars[i] = null;
                
                tbxView.Text =  $"차량번호:{car.CarNumber}\r\n";
                tbxView.Text += $"입차시간:{car.InTime}\r\n";
                tbxView.Text += $"출차시간:{car.OutTime}\r\n";
                tbxView.Text += $"시간차:{secd}초 \r\n";
                tbxView.Text += Environment.NewLine;
                tbxView.Text += Environment.NewLine;
                tbxView.Text += "출차차 처리를 완료했습니다.";
                return;
            }
            #endregion
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = "[주차현황]\r\n\r\n";
            for (int i = 0; i < cars.Length; i++) {
                tbxView.Text += $"[{i + 1}] 주차상태 : ";
                tbxView.Text += cars[i] == null ? "-" : cars[i].CarNumber;
                tbxView.Text += Environment.NewLine;
            }
            #endregion
        }


    }
}
