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
    public partial class Loding3 : Form
    {
        public Loding3()
        {
            InitializeComponent();
        }

        int timeleft = 2; // 2초의 로딩 시간
        private void Loding3_Load(object sender, EventArgs e)
        {
            timerloding3.Interval = 1000;
            timerloding3.Start();
        }

        private void timerloding3_Tick(object sender, EventArgs e)
        {
            timeleft--;

            if (timeleft <= 0)
            {
                timerloding3.Stop();

                Finish done = new Finish();
                done.Show();

                this.Close();
            }
        }
    }
}
