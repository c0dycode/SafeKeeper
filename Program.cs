using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeKeeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Console.WriteLine(createRange());

            SaveManager.readIPs();
            FirewallManager.FirewallRemoveBlock();
            //FirewallManager.FirewallRemoveWhitelist();
            String version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            SaveManager.saveIPs();
        }

        public static string ipFileLocation = "ips.txt";
        public static IDictionary<string, string> allowedIPs = new Dictionary<string, string>();

    }
}
