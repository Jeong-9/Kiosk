namespace kio
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            label1 = new Label();
            label2 = new Label();
            totalpay = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            btn_Receipt = new Button();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            rb_disagree = new RadioButton();
            rb_Agree = new RadioButton();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            rb_disagree1 = new RadioButton();
            rb_Agree1 = new RadioButton();
            cbPay = new ComboBox();
            label10 = new Label();
            lbPayInfo = new ListBox();
            btn_Enter = new Button();
            btn_Enter1 = new Button();
            btnPay = new Button();
            pictureBox1 = new PictureBox();
            lblTimer1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "결제할 금액:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(398, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 2;
            label2.Text = "결제방법";
            // 
            // totalpay
            // 
            totalpay.Location = new Point(126, 9);
            totalpay.Name = "totalpay";
            totalpay.Size = new Size(135, 23);
            totalpay.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 4;
            label3.Text = "주문 시 요구사항";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 84);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 119);
            textBox1.TabIndex = 5;
            // 
            // btn_Receipt
            // 
            btn_Receipt.BackColor = Color.Silver;
            btn_Receipt.Location = new Point(260, 84);
            btn_Receipt.Name = "btn_Receipt";
            btn_Receipt.Size = new Size(67, 36);
            btn_Receipt.TabIndex = 6;
            btn_Receipt.Text = "접수하기";
            btn_Receipt.UseVisualStyleBackColor = false;
            btn_Receipt.Click += btn_Receipt_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 206);
            label4.Name = "label4";
            label4.Size = new Size(432, 20);
            label4.TabIndex = 7;
            label4.Text = "이벤트에 응모하시면, 추첨을 통해 무료 음료 쿠폰을 드립니다. ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 227);
            label5.Name = "label5";
            label5.Size = new Size(368, 20);
            label5.TabIndex = 8;
            label5.Text = " 응모를 원하시면, 개인정보동의에 동의를 눌러주세요";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Ivory;
            groupBox1.Controls.Add(rb_disagree);
            groupBox1.Controls.Add(rb_Agree);
            groupBox1.Location = new Point(12, 251);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(215, 41);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "개인정보동의";
            // 
            // rb_disagree
            // 
            rb_disagree.AutoSize = true;
            rb_disagree.Location = new Point(114, 16);
            rb_disagree.Name = "rb_disagree";
            rb_disagree.Size = new Size(61, 19);
            rb_disagree.TabIndex = 11;
            rb_disagree.TabStop = true;
            rb_disagree.Text = "비동의";
            rb_disagree.UseVisualStyleBackColor = true;
            // 
            // rb_Agree
            // 
            rb_Agree.AutoSize = true;
            rb_Agree.Location = new Point(6, 16);
            rb_Agree.Name = "rb_Agree";
            rb_Agree.Size = new Size(49, 19);
            rb_Agree.TabIndex = 10;
            rb_Agree.TabStop = true;
            rb_Agree.Text = "동의";
            rb_Agree.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 309);
            label6.Name = "label6";
            label6.Size = new Size(383, 20);
            label6.TabIndex = 10;
            label6.Text = "뚜디쿠치나의 회원 가입을 원하시면 동의를 눌러주세요.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(-3, 206);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 11;
            label7.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(-3, 309);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 11;
            label8.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 329);
            label9.Name = "label9";
            label9.Size = new Size(620, 20);
            label9.TabIndex = 12;
            label9.Text = "가입 후 스탬프 카드를 드리며, 총 10개를 찍으시면 원하시는 요리 하나를 무료로 드립니다.";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Ivory;
            groupBox2.Controls.Add(rb_disagree1);
            groupBox2.Controls.Add(rb_Agree1);
            groupBox2.Location = new Point(18, 365);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(189, 51);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "회원가입";
            // 
            // rb_disagree1
            // 
            rb_disagree1.AutoSize = true;
            rb_disagree1.Location = new Point(92, 22);
            rb_disagree1.Name = "rb_disagree1";
            rb_disagree1.Size = new Size(61, 19);
            rb_disagree1.TabIndex = 15;
            rb_disagree1.TabStop = true;
            rb_disagree1.Text = "비동의";
            rb_disagree1.UseVisualStyleBackColor = true;
            // 
            // rb_Agree1
            // 
            rb_Agree1.AutoSize = true;
            rb_Agree1.Location = new Point(6, 22);
            rb_Agree1.Name = "rb_Agree1";
            rb_Agree1.Size = new Size(49, 19);
            rb_Agree1.TabIndex = 14;
            rb_Agree1.TabStop = true;
            rb_Agree1.Text = "동의";
            rb_Agree1.UseVisualStyleBackColor = true;
            // 
            // cbPay
            // 
            cbPay.FormattingEnabled = true;
            cbPay.Items.AddRange(new object[] { "신용카드", "무통장입금", "포인트" });
            cbPay.Location = new Point(398, 37);
            cbPay.Name = "cbPay";
            cbPay.Size = new Size(97, 23);
            cbPay.TabIndex = 14;
            cbPay.SelectedIndexChanged += cbPay_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(537, 7);
            label10.Name = "label10";
            label10.Size = new Size(95, 25);
            label10.TabIndex = 15;
            label10.Text = "결제 정보";
            // 
            // lbPayInfo
            // 
            lbPayInfo.FormattingEnabled = true;
            lbPayInfo.ItemHeight = 15;
            lbPayInfo.Location = new Point(537, 37);
            lbPayInfo.Name = "lbPayInfo";
            lbPayInfo.Size = new Size(110, 94);
            lbPayInfo.TabIndex = 16;
            // 
            // btn_Enter
            // 
            btn_Enter.BackColor = Color.Silver;
            btn_Enter.Location = new Point(260, 251);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(68, 42);
            btn_Enter.TabIndex = 17;
            btn_Enter.Text = "응모하기";
            btn_Enter.UseVisualStyleBackColor = false;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // btn_Enter1
            // 
            btn_Enter1.BackColor = Color.Silver;
            btn_Enter1.Location = new Point(244, 370);
            btn_Enter1.Name = "btn_Enter1";
            btn_Enter1.Size = new Size(70, 36);
            btn_Enter1.TabIndex = 18;
            btn_Enter1.Text = "가입하기";
            btn_Enter1.UseVisualStyleBackColor = false;
            btn_Enter1.Click += btn_Enter1_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.Gold;
            btnPay.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.Location = new Point(674, 25);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(83, 45);
            btnPay.TabIndex = 19;
            btnPay.Text = "결제";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // lblTimer1
            // 
            lblTimer1.AutoSize = true;
            lblTimer1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTimer1.ForeColor = Color.Red;
            lblTimer1.Location = new Point(422, 370);
            lblTimer1.Name = "lblTimer1";
            lblTimer1.Size = new Size(173, 30);
            lblTimer1.TabIndex = 21;
            lblTimer1.Text = "남은시간 : 100초";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTimer1);
            Controls.Add(pictureBox1);
            Controls.Add(btnPay);
            Controls.Add(btn_Enter1);
            Controls.Add(btn_Enter);
            Controls.Add(lbPayInfo);
            Controls.Add(label10);
            Controls.Add(cbPay);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btn_Receipt);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(totalpay);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox totalpay;
        private Label label3;
        private TextBox textBox1;
        private Button btn_Receipt;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rb_disagree;
        private RadioButton rb_Agree;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox2;
        private RadioButton rb_disagree1;
        private RadioButton rb_Agree1;
        private ComboBox cbPay;
        private Label label10;
        private ListBox lbPayInfo;
        private Button btn_Enter;
        private Button btn_Enter1;
        private Button btnPay;
        private PictureBox pictureBox1;
        private Label lblTimer1;
        private System.Windows.Forms.Timer timer1;
    }
}