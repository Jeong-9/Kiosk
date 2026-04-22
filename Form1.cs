namespace kio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_inter_Click(object sender, EventArgs e)
        {
            Loding1 nextForm = new Loding1();
            nextForm.Show();
            this.Hide();
        }
    }
}
