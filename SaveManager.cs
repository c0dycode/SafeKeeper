using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeKeeper
{
    static class SaveManager
    {
        public static void saveIPs()
        {
            string lines = "";
            foreach (KeyValuePair<string, string> split in Program.allowedIPs)
            {
                //save text file
                string line = encodeLine(split.Key, split.Value);
                lines += line + Environment.NewLine;
            }
            File.WriteAllText(Program.ipFileLocation, lines);
        }
        public static void readIPs()
        {
            if (File.Exists(Program.ipFileLocation))
            {
                string[] lines = File.ReadAllLines(Program.ipFileLocation);
                Program.allowedIPs.Clear();
                foreach (string line in lines)
                {
                    KeyValuePair<string, string> Dline = decodeLine(line);
                    Program.allowedIPs.Add(Dline);
                }
            }
        }
        public static KeyValuePair<string, string> decodeLine(string line)
        {
            char seperator = '$';
            string key = "";
            string value = "";
            string[] tokens = line.Split(seperator);
            if (tokens.Length == 2)
            {
                key = tokens[0];
                value = tokens[1];
            }
            else if (tokens.Length == 1)
            {
                key = tokens[0];
            }
            return new KeyValuePair<string, string>(key, value); ;
        }
        public static string encodeLine(string key, string value)
        {
            if (value.Length == 0)
            {
                return key;
            }
            return key + "$" + value;
        }
        public static void saveLog(string lines)
        {
            File.WriteAllText("log.txt", lines);
        }
    }
}
