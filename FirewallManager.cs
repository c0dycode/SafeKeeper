using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;

namespace SafeKeeper
{
    static class FirewallManager
    {
        static readonly Ping pingSender = new Ping();
        static PingOptions _options = new PingOptions { DontFragment = true };

        public static bool whitelistEnabled = false;
        public static bool blockEnabled = false;
        
        public static void FirewallRemoveBlock()
        {
            Debug.WriteLine("PING");
            try
            {
                Type tNetFwPolicy2 = Type.GetTypeFromProgID("HNetCfg.FwPolicy2");
                INetFwPolicy2 fwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(tNetFwPolicy2);
                fwPolicy2.Rules.Remove("SafeKeeperbyDigitalArc-BLOCKOUT");
                fwPolicy2.Rules.Remove("SafeKeeperbyDigitalArc-BLOCKIN");
                blockEnabled = false;

            }
            catch (Exception r)
            {
                Console.WriteLine("Error delete rule from firewall");
            }
        }
        

        public static void FirewallCreateBlockall()
        {
            //outbound rule
            INetFwRule blockout = (INetFwRule)Activator.CreateInstance(
            Type.GetTypeFromProgID("HNetCfg.FWRule"));
            blockout.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            blockout.Description = "BLOCKING THE PORT 6672 WHEN OUTBOUND";
            blockout.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            blockout.Enabled = true;
            blockout.InterfaceTypes = "All";
            blockout.Name = "SafeKeeperbyDigitalArc-BLOCKOUT";
            blockout.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            blockout.LocalPorts = "6672";
            if (whitelistEnabled)
            {
                string range = createRange();
                Console.WriteLine(range);
                blockout.RemoteAddresses = range;
                //blockout.RemoteAddresses
            }
            //inbound rule
            INetFwRule blockin = (INetFwRule)Activator.CreateInstance(
            Type.GetTypeFromProgID("HNetCfg.FWRule"));
            blockin.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            blockin.Description = "BLOCKING THE PORT 6672 WHEN INBOUND";
            blockin.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            blockin.Enabled = true;
            blockin.InterfaceTypes = "All";
            blockin.Name = "SafeKeeperbyDigitalArc-BLOCKIN";
            blockin.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            blockin.LocalPorts = "6672";
            if (whitelistEnabled)
            {
                blockin.RemoteAddresses = createRange();
            }
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
                Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
            firewallPolicy.Rules.Add(blockout);
            firewallPolicy.Rules.Add(blockin);
            blockEnabled = true;
        }

        private static string allowedIPSString()
        {
            ICollection<string> set = Program.allowedIPs.Keys;
            string result = string.Join<string>(",", set);
            return result;
        }

        public static void recreateWhitelist()
        {
            new Thread(delegate () {
                FirewallRemoveBlock();
                FirewallCreateBlockall();
            }).Start();
        }

        public static string createRange()
        {
            string log = "";
            byte[] lastIp = IPAddress.Parse("0.0.0.0").GetAddressBytes();
            List<string> ipAddresses = orderIPList(Program.allowedIPs.Keys);

            
            foreach (string ip in ipAddresses)
            {
                byte[] ipoce = IPAddress.Parse(ip).GetAddressBytes();
                if (ipoce[0] == lastIp[0] && ipoce[1] == lastIp[1] && ipoce[2] == lastIp[2])
                {
                    //maybe next, end array and 
                    if (lastIp[3] + 1 == ipoce[3])
                    {
                        lastIp = ipoce;
                        continue;
                    }
                    else if (lastIp[3] - 1 == ipoce[3])
                    {
                        lastIp = ipoce;
                        continue;
                    }
                    else if (lastIp[3] == ipoce[3])
                    {
                        lastIp = ipoce;
                        continue;
                    }
                }
                log += "" + dispByteIP(lastIp, 1) + "-" + dispByteIP(ipoce, -1) + ",";
                lastIp = ipoce;
            }
            byte[] ipce = IPAddress.Parse("254.254.254.254").GetAddressBytes();
            log += "" + dispByteIP(lastIp, 1) + "-" + dispByteIP(ipce, 0) + "";
            return log;
        }
        private static List<string> orderIPList(ICollection<string> data)
        {
            List<string> tempList = new List<string>();
            // If the IP is not an IP yet, resolve it via pinging
            foreach (var ip in data)
            {
                if (ip.Any(Char.IsLetter))
                {
                    try
                    {
                        var reply = pingSender.Send(ip, 5);
                        tempList.Add(reply.Address.ToString());
                    }
                    catch (PingException)
                    {
                        // Ignore non-pingable hostnames and continue
                        continue;
                    }
                }
                else
                    tempList.Add(ip);
            }

            var orderedList = tempList.Select(x => x).OrderBy(x => x).Select(x => x).ToList();
            //List<string> sortedIps = data
            //    .Select(Version.Parse)
            //    .OrderBy(arg => arg)
            //    .Select(arg => arg.ToString())
            //    .ToList();
            //return sortedIps;
            return orderedList;
        }
        private static string dispByteIP(byte[] ip, int ls)
        {
            string ret = ip[0] + "." + ip[1] + "." + ip[2] + "." + (ip[3] + ls);
            return ret;
        }
    }
}
