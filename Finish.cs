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
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        int timeleft = 5;
        private void Finish_Load(object sender, EventArgs e)
        {
            timerend.Interval = 1000;
            timerend.Start();
        }

        private void timerend_Tick(object sender, EventArgs e)
        {
            timeleft--;

            if (timeleft <= 0) // 5초 기다리면 화면이 사라진다.
            {
                this.Close();
            }
        }

        
    }
}
