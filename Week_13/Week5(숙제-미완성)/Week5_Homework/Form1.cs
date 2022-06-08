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

        const int MAX_COUNT = 5;
        List<Car> cars = new List<Car>();

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
            for (int i = 0; i < cars.Count; i++) {
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

            if (cars.Count == MAX_COUNT) {
                MessageBox.Show("풀방");
                return;
            }

            //1번 
            Car car = null;
            if (rbtnShortTerm.Checked) {
                car = new ShortTermCar(tbxNumber.Text);
            } else if (rbtnFree.Checked) {
                car = new FreeCar(tbxNumber.Text);
            } else {
                try
                {
                    car = new LongTermCar(tbxNumber.Text, int.Parse(tbxTerm.Text));
                } catch
                {
                    MessageBox.Show("기간을 반드시 넣어주세요");
                }
            }

            cars.Add(car);

            tbxView.Text = car.ToString();
            tbxView.Text += Environment.NewLine;
            tbxView.Text += "입차 처리를 완료했습니다.";

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
            }
            var car = cars[i];
            car.Out();
            cars.RemoveAt(i);

            tbxView.Text = car.ToString();

            //2번
            /*
            if (rbtnShortTerm.Checked)
            {
                tbxView.Text += $"\r\n주차료:{ShortTermCar.GetPrice()}원";
            } else if (rbtnLongTerm.Checked){
                tbxView.Text += $"\r\n주차료:{LongTermCar.GetPrice()}원";
            } else{
                tbxView.Text += "무료 차량 입니다.";
            }
            */
            //LongTermCar longTermCar = (LongTermCar)car;

            try
            {
                IPayable car1 = (IPayable)car;
                if (rbtnShortTerm.Checked)
                {
                    tbxView.Text += $"\r\n주차료:{car1.GetPrice()}원";
                }
                else if (rbtnLongTerm.Checked)
                {
                    tbxView.Text += $"\r\n주차료:{car1.GetPrice()}원";
                }
            }
            catch
            {
                tbxView.Text = "주차료 0원";
            }
                
            
            tbxView.Text += "출차 처리를 완료했습니다.";

            #endregion
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            #region code
            tbxView.Text = "[주차현황]\r\n\r\n";
            for (int i = 0; i < cars.Count; i++) {
                tbxView.Text += $"[{i + 1}] 주차상태 : ";
                tbxView.Text += cars[i];
                tbxView.Text += Environment.NewLine;
            }
            #endregion
        }

        private void rbtnType_CheckedChanged(object sender, EventArgs e)
        {
            pnlTermData.Visible = rbtnLongTerm.Checked;
        }

    }
}
