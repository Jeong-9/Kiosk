using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace kio
{
    public partial class PaymentForm : Form
    {
        int receivedPrice;

        public PaymentForm(int totalPrice) // 메뉴 폼에서 총 가격을 받아온다.
        {
            InitializeComponent();
            receivedPrice = totalPrice;
            totalpay.Text = receivedPrice + "원";
        }

        //timeleft
        int timeleft = 100;

        //시간 설정
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            timeleft = 100; // 100초의 시간
            timer1.Interval = 1000;
            timer1.Start();
        }

        //주문 시 요구 사항 접수하기
        private void btn_Receipt_Click(object sender, EventArgs e)
        {
            string strText = textBox1.Text + "\n라고 요구사항이 접수되었습니다.";
            MessageBox.Show(strText);
        }

        private bool btnEnterclick = false;
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            if (rb_Agree.Checked == true)
            {
                MessageBox.Show("개인정보에 동의하셨습니다. 추첨 결과는 추후 공지하겠습니다.");
                btnEnterclick = true;
            }

            else if (rb_disagree.Checked == true)
            {
                MessageBox.Show("개인 정보에 동의하지 않으셨습니다.");
                btnEnterclick = true;
            }

            else
                MessageBox.Show("이벤트 응모 선택을 눌러주세요");
        }

        private bool btnEnter1click = false;
        private void btn_Enter1_Click(object sender, EventArgs e)
        {
            if (rb_Agree1.Checked == true)
            {
                MessageBox.Show("뚜띠쿠치나 회원가입을 축하합니다. 스탬프 카드는 계산대 직원이 제공해주니 참고해주십시오.");
                btnEnter1click = true;
            }
            else if (rb_disagree1.Checked == true)
            {
                MessageBox.Show("회원가입에 동의하지 않으셨습니다.");
                btnEnter1click = true;
            }
            else
                MessageBox.Show("회원가입 동의여부를 선택해주세요");
        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayInfo.Items.Clear();

            if (cbPay.SelectedIndex == 0)
            {
                lbPayInfo.Items.Add("일시불");
                lbPayInfo.Items.Add("3개월 할부");
                lbPayInfo.Items.Add("6개월 할부");
            }
            else if (cbPay.SelectedIndex == 1)
            {
                lbPayInfo.Items.Add("국민 은행");
                lbPayInfo.Items.Add("농협 은행");
                lbPayInfo.Items.Add("신한 은행");
                lbPayInfo.Items.Add("기업 은행");
                lbPayInfo.Items.Add("하나 은행");
            }

            else if (cbPay.SelectedIndex == 2)
            {
                lbPayInfo.Items.Add("마이신한포인트");
                lbPayInfo.Items.Add("삼성카드 포인트");
                lbPayInfo.Items.Add("M 포인트");
                lbPayInfo.Items.Add("L.POINT");
                lbPayInfo.Items.Add("모두우리 포인트");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cbPay.Text == "" || lbPayInfo.Text == "")
            {
                MessageBox.Show("결제방법 및 정보를 다시 확인해 주세요");
                return;
            }

            if (!btnEnterclick || !btnEnter1click)
            {
                MessageBox.Show("이벤트 응모 선택과 회원가입 동의 여부를 확인해주세요");
                return;
            }

            string str = cbPay.Text + "(으)로 " + lbPayInfo.Text + "결제방법을" + "\n선택하셨습니다." + "\n 결제 금액은 " + totalpay.Text + "입니다.";

            MessageBox.Show(str);

            Loding3 load = new Loding3();
            load.Show();
            this.Close();//결제창 닫기

        }

        //타이머 설정
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft--;
            lblTimer1.Text = "남은 시간 : " + timeleft + "초";

            if (timeleft <= 0)
            {
                timer1.Stop();

                MessageBox.Show("시간이 초과되었습니다. 시작 화면으로 돌아갑니다.");

                Form1 first = new Form1();
                first.Show();
                this.Close();
            }
        }
    }
}
