namespace kio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            welcomeLogo = new Label();
            btn_inter = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(75, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 225);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // welcomeLogo
            // 
            welcomeLogo.AutoSize = true;
            welcomeLogo.BackColor = Color.Transparent;
            welcomeLogo.Font = new Font("바탕체", 18F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeLogo.Location = new Point(-2, 51);
            welcomeLogo.Name = "welcomeLogo";
            welcomeLogo.Size = new Size(437, 24);
            welcomeLogo.TabIndex = 1;
            welcomeLogo.Text = "뚜띠쿠치나에 오신 것을 환영합니다.";
            // 
            // btn_inter
            // 
            btn_inter.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_inter.Location = new Point(75, 365);
            btn_inter.Name = "btn_inter";
            btn_inter.Size = new Size(225, 56);
            btn_inter.TabIndex = 2;
            btn_inter.Text = "가게 안으로 입장하기";
            btn_inter.UseVisualStyleBackColor = true;
            btn_inter.Click += btn_inter_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(441, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(360, 434);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_inter);
            Controls.Add(welcomeLogo);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label welcomeLogo;
        private Button btn_inter;
        private PictureBox pictureBox2;
    }
}
