using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {

        int num;

        private void Reset()
        {
            txtSec.Focus();
            txtSec.Clear();
            lblRSec.Text = "";
            num = 0;
            btnStart.Enabled = false;
            timer1.Enabled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void txtSec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                num = int.Parse(txtSec.Text);
                lblRSec.Text = "";
            }
            catch
            {
                Reset();
                return;
            }

            if (num < 0)
            {
                Reset();
                return;
            }
            else
            {
                btnStart.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num--;
            lblRSec.Text = num.ToString();
            if (num == 0)
            {
                timer1.Enabled = false;
                btnStart.Enabled = false;
                MessageBox.Show("時間到！", "倒數計時器", MessageBoxButtons.OK);
            }
        }
    }
}
