using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace WindowsFormsApp.Utilities
{
    class Channel
    {
        public int idx;
        private int currentVal;
        private int maxVal;
        private int minVal;
        private int zeroVal;
        public int CurrentVal 
        {
            get
            {
                return currentVal;
            }
            set
            {
                if (value >= 0 && value <= 180)
                {
                    currentVal = value;
                    shouldSend = true;
                }
            }
        }
        public int MaxVal
        {
            get
            {
                return maxVal;
            }
            set
            {
                if (value >= 0 && value <= 180)
                {
                    maxVal = value;
                }
            }
        }
        public int MinVal
        {
            get
            {
                return minVal;
            }
            set
            {
                if (value >= 0 && value <= 180)
                {
                    minVal = value;
                }
            }
        }
        public int ZeroVal 
        {
            get
            {
                return zeroVal;
            }
            set
            {
                if (value >= 0 && value <= 180)
                {
                    zeroVal = value;
                }
            }
        }

        public bool shouldSend;

        public Channel(int idx)
        {
            this.idx = idx;
            shouldSend = false;
            CurrentVal = 85;
            ZeroVal = 85;
            maxVal = 180;
            minVal = 0;
        }
    }
    class CentralClass
    {
        private static CentralClass _instance;
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
            isConnected = false;
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

        public bool setChannelVal(int channelIdx, int value)
        {
            if (channelIdx < 0 || channelIdx > channels.Count - 1) return false;
            if (value < 0 || value > 180 || channels[channelIdx].CurrentVal == value) return false;
            channels[channelIdx].CurrentVal = value;
            return true;
        }

        public string ExecChannels()
        {
            bool shouldSend = false;
            string url = "http://" + mainBoardIP + "/?";

            for(int i = 0; i < channels.Count; i++)
            {
                if(channels[i].shouldSend)
                {
                    url += channels[i].idx + "=" + channels[i].CurrentVal + "&";
                    channels[i].shouldSend = false;
                    shouldSend = true;
                }
            }
            url = url.Remove(url.Length - 1, 1);
            if(shouldSend)
            {
                return ExecURL(url);
            }
            return "Already Updated";
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
            catch (Exception ex)
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
