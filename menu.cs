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
    public partial class menu : Form
    {
        //주문 금액 초기화
        public int totalPrice = 0;

        //timeleft 선언 제한시간 100초의 시간.
        int timeleft = 100;

        public menu()
        {
            InitializeComponent();
        }


        // 체크 박스에 체크 된 음식과 음료 주문 금액의 총 합계가 출력됨
        private void btn_Total_Click(object sender, EventArgs e)
        {
            totalPrice = 0;
            rtb_totalprice.Clear();

            AddItem(cb_CheeseSalmon, num_CS, price_cheesesalmon);
            AddItem(cb_TomatoSalad, num_TS, price_tomatosalad);
            AddItem(cb_HerbChiken, num_HC, price_herbchikensalad);

            AddItem(cb_PrawnSeaFood, num_PSF, price_PrawnSeaFoodtomato);
            AddItem(cb_GreenOnionPepper, num_GOP, price_GreenOnionPeppertomato);
            AddItem(cb_CrabmeatCream, num_CC, price_CrabmeatCream);
            AddItem(cb_Carbonara, num_Car, price_Carbonara);
            AddItem(cb_VongoleOil, num_VO, price_vongoleOil);
            AddItem(cb_GambasOil, num_GBO, price_GambasOil);

            AddItem(cb_GorgonZola, num_GZ, price_GorgonZola);
            AddItem(cb_Margherita, num_Margherita, price_Margherita);
            AddItem(cb_RicotaCalzone, num_RC, price_RicotaCalzone);

            AddItem(cb_Steak, num_Steak, price_Steak);

            AddItem(cb_Americano, num_Americano, price_Americano);
            AddItem(cb_CaffeLatte, num_CaffeLatte, price_CaffeLatte);
            AddItem(cb_Soda, num_Soda, price_Soda);
            AddItem(cb_Ade, num_Ade, price_Ade);
            AddItem(cb_Water, num_Water, price_Water);
                

            textBox1.Text= totalPrice.ToString() + "원";
        }

        //전체 취소(잘못 주문했을 시 누르는 버튼)
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            totalPrice = 0;

            rtb_totalprice.Clear();

            textBox1.Text = "";

            ResetControls(this);

            foreach(Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }

        }

        void ResetControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 1;
                }
                if (c.HasChildren)
                {
                    ResetControls(c);
                }
            }
        }

        //총 금액을 로딩 창으로 보내고 결체 창으로 보낸다.
        private void btn_pay_Click(object sender, EventArgs e)
        {
            Loding2 loding = new Loding2(totalPrice);
            loding.Show();
            this.Close(); // 시간이 100초 다 지나면 자동으로 시작화면이 나오는 것을 막아줌

        }

        // 타이머 설정(시간 지나면 자동으로 처음 화면으로 돌아간다.)
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft--;
            lblTimer.Text = "남은 시간 : " + timeleft + "초";

            if (timeleft <= 0)
            {
                timer1.Stop();

                MessageBox.Show("시간이 초과되었습니다. 시작 화면으로 돌아갑니다.");

                Form1 first = new Form1();
                first.Show();
                this.Close();
            }
        }

        // 시간 설정, NumericUpDown 설정
        private void menu_Load(object sender, EventArgs e)
        {
            timeleft = 100; // 100초의 시간
            timer1.Interval = 1000;
            timer1.Start();

            SetNumeric(num_CS);
            SetNumeric(num_TS);
            SetNumeric(num_HC);

            SetNumeric(num_PSF);
            SetNumeric(num_GOP);
            SetNumeric(num_CC);
            SetNumeric(num_Car);
            SetNumeric(num_VO);
            SetNumeric(num_GBO);

            SetNumeric(num_GZ);
            SetNumeric(num_Margherita);
            SetNumeric(num_RC);

            SetNumeric(num_Steak);

            SetNumeric(num_Americano);
            SetNumeric(num_CaffeLatte);
            SetNumeric(num_Soda);
            SetNumeric(num_Ade);
            SetNumeric(num_Water);
        }

        void SetNumeric(NumericUpDown num)
        {
            num.Minimum = 1;
            num.Maximum = 10;
            num.Value = 1;
        }

        void AddItem(CheckBox cb, NumericUpDown num, Label pricelabel)
        {
            if (cb.Checked)
            {
                int price = int.Parse(pricelabel.Text);
                int count = (int)num.Value;
                int sum = price * count;

                totalPrice += sum;
                rtb_totalprice.AppendText(
                    cb.Text + " x " + count + " = " + sum + "원\n");
            }
        }
    }
}