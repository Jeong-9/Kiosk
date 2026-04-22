using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace kio
{
    public partial class Loding1 : Form
    {
        public Loding1()
        {
            InitializeComponent();
        }

        int timeleft = 2;

        private void timerloding_Tick(object sender, EventArgs e)
        {
            timeleft--;
            

            if (timeleft <= 0)
            {
                timerloding.Stop();

                menu m = new menu();
                m.Show();

                this.Close();
            }

            
        }

        private void Loding1_Load(object sender, EventArgs e)
        {
            timerloding.Interval = 1000;
            timerloding.Start();
        }
    }
}
