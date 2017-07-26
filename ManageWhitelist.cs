using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeKeeper
{
    public partial class ManageWhitelist : Form
    {
        public ManageWhitelist()
        {
            InitializeComponent();
            reImportipList();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
            SaveManager.saveIPs();
        }

        private void ipListRemoveButton_Click(object sender, EventArgs e)
        {
            if (ipList.SelectedIndex != -1)
            {
                string selectedItem = (string)ipList.SelectedItem;
                if (selectedItem.Contains("  -  "))
                {
                    //contains both a key and value
                    //data.Split(new string[] { "xx" }, StringSplitOptions.None);
                    string[] split = selectedItem.Split(new string[] { "  -  " }, StringSplitOptions.None);
                    selectedItem = split[0];
                }
                //an item is selected
                if (Program.allowedIPs.ContainsKey(selectedItem))
                {
                    Program.allowedIPs.Remove(selectedItem);
                    reImportipList();
                }
            }
        }

        private void ipListAddButton_Click(object sender, EventArgs e)
        {
            string newIP = ipListAddAddress.Text;
            string newName = ipListAddName.Text;
            if (checkIP(newIP))
            {
                if (!Program.allowedIPs.ContainsKey(newIP))
                {
                    Program.allowedIPs.Add(newIP, newName);
                    reImportipList();
                }
                else
                {
                    MessageBox.Show("Duplicate IP address", "Duplicate IP address", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("INVALID IP ADDRESS", "INVALID IP ADDRESS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void reImportipList()
        {
            ipList.Items.Clear();
            foreach (KeyValuePair<string, string> item in Program.allowedIPs)
            {
                if (item.Value.Length != 0)
                {
                    ipList.Items.Add(item.Key + "  -  " + item.Value);
                }
                else
                {
                    ipList.Items.Add(item.Key);
                }
            }
        }
        private bool checkIP(string ipAddress)
        {
            string[] parts = ipAddress.Split('.');
            if (parts.Length < 4)
            {
                return false;
            }
            else
            {
                foreach (string part in parts)
                {
                    byte checkPart = 0;
                    if (!byte.TryParse(part, out checkPart))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
