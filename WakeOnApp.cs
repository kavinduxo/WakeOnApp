/*
 ------------------------History-----------------------
 KavinduGunathilake     13-04-2023      Initial Version.
 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WakeOnApp
{
    public partial class WakeOnApp : Form
    {
        public WakeOnApp()
        {
            InitializeComponent();
            btnOff.Enabled = false;
            btnOn.Enabled = true;
            dfStatus.Text = "On Sleep!";
        }

        private void btnOn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dfStatus.Text = "Running...";
                btnOn.Enabled = false;
                btnOff.Enabled = true;
                this.TopMost = true;

                awakeTimer.Interval = 60000;
                awakeTimer.Tick += Time_Bomb;
                awakeTimer.Start();

            }
        }

        private void btnOff_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dfStatus.Text = "On Sleep!";
                btnOn.Enabled = true;
                btnOff.Enabled = false;
                awakeTimer.Stop();

                this.TopMost = false;
            }
        }

        private void Time_Bomb(Object sender, EventArgs e)
        {
            awakeTimer.Interval = 60000;

            SendKeys.Send("{F15}");
        }
    }
}
