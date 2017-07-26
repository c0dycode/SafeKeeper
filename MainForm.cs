using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;

namespace SafeKeeper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            String version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            labelVersion.Text = "v" + version;
        }

        private void soloEnable_Click(object sender, EventArgs e)
        {
            soloDisable.Enabled = true;
            soloEnable.Enabled = false;
            whitelistEnable.Enabled = false;
            whitelistDisable.Enabled = false;
            newSessionButton.Enabled = false;
            kickNonWhitelistButton.Enabled = false;
            labelStatus.Text = "Status: enabled";
            statusBar.Invoke(new Action(() => statusBar.Value = 100));
            if (!FirewallManager.blockEnabled)
            {
                FirewallManager.FirewallCreateBlockall();
            }
        }

        private void soloDisable_Click(object sender, EventArgs e)
        {
            soloDisable.Enabled = false;
            soloEnable.Enabled = true;
            whitelistEnable.Enabled = true;
            newSessionButton.Enabled = true;
            kickNonWhitelistButton.Enabled = true;
            labelStatus.Text = "Status: disabled";
            statusBar.Invoke(new Action(() => statusBar.Value = 0));
            if (FirewallManager.blockEnabled)
            {
                FirewallManager.FirewallRemoveBlock();
                FirewallManager.blockEnabled = false;
            }
        }

        private void newSessionButton_Click(object sender, EventArgs e)
        {
            if (FirewallManager.blockEnabled) return;
            newSessionButton.Enabled = false;
            kickNonWhitelistButton.Enabled = false;
            whitelistEnable.Enabled = false;
            whitelistDisable.Enabled = false;
            soloDisable.Enabled = false;
            soloEnable.Enabled = false;
            labelStatus.Text = "Status: creating new session";
            new Thread(delegate () {
                FirewallManager.FirewallCreateBlockall();
                int loopcount = 15;
                int i = 0;
                int totalloops = loopcount * 5;
                while (i < totalloops)
                {
                    i++;
                    Thread.Sleep(200);
                    double progressbarval = i * 100.0 / totalloops;
                    Console.WriteLine(i + " / " + totalloops + " + pbl: " + progressbarval + " pbls: " + i / totalloops);
                    statusBar.Invoke(new Action(() => statusBar.Value = Convert.ToInt32(Math.Floor(progressbarval))));
                }
                statusBar.Invoke(new Action(() => statusBar.Value = 100));
                FirewallManager.FirewallRemoveBlock();
                labelStatus.Invoke(new Action(() => labelStatus.Text = "Status: disabled"));
                newSessionButton.Invoke(new Action(() => newSessionButton.Enabled = true));
                soloDisable.Invoke(new Action(() => soloDisable.Enabled = false));
                soloEnable.Invoke(new Action(() => soloEnable.Enabled = true));
                whitelistDisable.Invoke(new Action(() => whitelistDisable.Enabled = false));
                whitelistEnable.Invoke(new Action(() => whitelistEnable.Enabled = true));
                kickNonWhitelistButton.Invoke(new Action(() => kickNonWhitelistButton.Enabled = true));
                statusBar.Invoke(new Action(() => statusBar.Value = 0));
            }).Start();
        }

        private void kickNonWhitelistButton_Click(object sender, EventArgs e)
        {
            if (FirewallManager.blockEnabled) return;
            newSessionButton.Enabled = false;
            kickNonWhitelistButton.Enabled = false;
            whitelistEnable.Enabled = false;
            whitelistDisable.Enabled = false;
            soloDisable.Enabled = false;
            soloEnable.Enabled = false;
            labelStatus.Text = "Status: kicking all non whitelisted";
            new Thread(delegate () {
                FirewallManager.whitelistEnabled = true;
                FirewallManager.blockEnabled = true;
                FirewallManager.FirewallRemoveBlock();
                FirewallManager.FirewallCreateBlockall();
                int loopcount = 15;
                int i = 0;
                int totalloops = loopcount * 5;
                while (i < totalloops)
                {
                    i++;
                    Thread.Sleep(200);
                    double progressbarval = i * 100.0 / totalloops;
                    Console.WriteLine(i + " / " + totalloops + " + pbl: " + progressbarval + " pbls: " + i / totalloops);
                    statusBar.Invoke(new Action(() => statusBar.Value = Convert.ToInt32(Math.Floor(progressbarval))));
                }
                statusBar.Invoke(new Action(() => statusBar.Value = 100));
                FirewallManager.whitelistEnabled = false;
                FirewallManager.blockEnabled = false;
                FirewallManager.FirewallRemoveBlock();
                labelStatus.Invoke(new Action(() => labelStatus.Text = "Status: disabled"));
                newSessionButton.Invoke(new Action(() => newSessionButton.Enabled = true));
                soloDisable.Invoke(new Action(() => soloDisable.Enabled = false));
                soloEnable.Invoke(new Action(() => soloEnable.Enabled = true));
                whitelistDisable.Invoke(new Action(() => whitelistDisable.Enabled = false));
                whitelistEnable.Invoke(new Action(() => whitelistEnable.Enabled = true));
                kickNonWhitelistButton.Invoke(new Action(() => kickNonWhitelistButton.Enabled = true));
                statusBar.Invoke(new Action(() => statusBar.Value = 0));
            }).Start();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            Form form2 = new ManageWhitelist();
            form2.ShowDialog();
            FirewallManager.FirewallRemoveBlock();
            if (FirewallManager.whitelistEnabled)
            {
                FirewallManager.recreateWhitelist();
            }
            FirewallManager.FirewallCreateBlockall();
        }

        private void whitelistEnable_Click(object sender, EventArgs e)
        {
            if (Program.allowedIPs.Count != 0)
            {
                whitelistDisable.Enabled = true;
                whitelistEnable.Enabled = false;
                soloEnable.Enabled = false;
                newSessionButton.Enabled = false;
                kickNonWhitelistButton.Enabled = false;
                labelStatus.Text = "Status: whitelist enabled";
                statusBar.Invoke(new Action(() => statusBar.Value = 100));
                FirewallManager.whitelistEnabled = true;
                FirewallManager.blockEnabled = true;
                FirewallManager.FirewallRemoveBlock();
                FirewallManager.FirewallCreateBlockall();

            }
            else
            {
                MessageBox.Show("Cannot enable, there's no addresses listed.", "Whitelist error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void whitelistDisable_Click(object sender, EventArgs e)
        {
            whitelistDisable.Enabled = false;
            whitelistEnable.Enabled = true;
            soloEnable.Enabled = true;
            newSessionButton.Enabled = true;
            kickNonWhitelistButton.Enabled = true;
            labelStatus.Text = "Status: disabled";
            statusBar.Invoke(new Action(() => statusBar.Value = 0));
            FirewallManager.whitelistEnabled = false;
            FirewallManager.blockEnabled = false;
            FirewallManager.FirewallRemoveBlock();
        }

        private void creditsButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form3 = new Credits();
            form3.ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            FirewallManager.FirewallRemoveBlock();
        }
    }
}
