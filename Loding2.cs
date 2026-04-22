using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kio
{
    public partial class Loding2 : Form
    {
        int timeleft = 2; // 2초의 로딩시간
        int totalPrice; // 메뉴에서 총 가격을 받을 변수를 선언한다.
        public Loding2(int price)
        {
            InitializeComponent();
            totalPrice = price;
        }

        //타이머 시작
        private void Loding2_Load(object sender, EventArgs e)
        {
            timerloding2.Interval = 1000;
            timerloding2.Start();
        }

        //타이머 설정(메뉴에서 받은 총 가격을 결제창으로 보낸다.
        private void timerloding2_Tick(object sender, EventArgs e)
        {
            timeleft--;

            if (timeleft <= 0)
            {
                timerloding2.Stop();

                PaymentForm pay = new PaymentForm(totalPrice);
                pay.Show();

                this.Close();
            }
        }
    }
}
