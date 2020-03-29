using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp.Utilities
{
    class Channel
    {
        public int idx;
        public int zeroVal;
        public int maxVal;
        public int minVal;
        public Channel(int idx)
        {
            this.idx = idx;
            zeroVal = 85;
            maxVal = 180;
            minVal = 0;
        }
    }
    class CentralClass
    {
        private static CentralClass _instance;
        private Timer timer;
        public string mainBoardIP;
        public bool isConnected;
        public List<Channel> channels;
        public static CentralClass getInstance()
        {
            if (_instance == null)
            {
                _instance = new CentralClass();
            }
            return _instance;
        }

        private CentralClass()
        {
            mainBoardIP = "192.168.4.1";
            channels = new List<Channel>();
            channels.Add(new Channel(0));
            channels.Add(new Channel(1));
            channels.Add(new Channel(2));
        }
        public void updateStatus()
        {
            string result = ExecURL("http://" + mainBoardIP);
            if (result.Equals("OK"))
            {
                isConnected = true;
            }
            else
            {
                isConnected = false;
            }
        }

        public string ExecChannel(int channel, int value)
        {
            string url = "http://" + mainBoardIP + "/?" + channel + "=" + value;
            return ExecURL(url);
        }
        public string ExecURL(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 1000;
            HttpWebResponse result;
            try
            {
                result = (HttpWebResponse)request.GetResponse();
                request.Abort();
                isConnected = true;
                return result.StatusCode.ToString();
            }
            catch(Exception ex)
            {
                request.Abort();
                isConnected = false;
                return ex.Message;
            } 
        }

        public bool validateIp(string ipAddr)
        {
            Regex regex = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
            Match match = regex.Match(ipAddr);
            if (match.Success) return true;
            else return false;
        }
    }
}
