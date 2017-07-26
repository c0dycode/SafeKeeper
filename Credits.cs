using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SafeKeeper
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://linustechtips.com/main/profile/463571-leonfagan71/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.freepik.com/free-photos-vectors/logo");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
