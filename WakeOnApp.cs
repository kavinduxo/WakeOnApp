/*
MIT License

Copyright (c) [2023] [KavinduGunathilake]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


 ------------------------History-----------------------
 KavinduGunathilake     13-04-2023      Initial Version.
 ------------------------------------------------------
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
            dfStatus.Text = Properties.Resources.OffStatus;
        }

        private void btnOn_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dfStatus.Text = Properties.Resources.OnStatus;
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
                dfStatus.Text = Properties.Resources.OffStatus;
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

        private void WakeOnApp_Load(object sender, EventArgs e)
        {
            Icon applicationIcon = new Icon(Properties.Resources.wakeonapp_icon, Properties.Resources.wakeonapp_icon.Size);

            this.Icon = applicationIcon;
        }
    }
}
