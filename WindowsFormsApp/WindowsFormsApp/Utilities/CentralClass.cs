using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace WindowsFormsApp.Utilities
{
    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = 1000;
            return w;
        }
    }
    class Channel
    {
        public static int channelCount = 9;
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
        public bool isCamConnected;
        public List<Channel> channels;
        private string camIp;
        public List<string> infoArray;
        public string CamIp
        {
            get
            {
                return camIp;
            }
            set
            {
                camIp = value;
            }
        }
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
            infoArray = new List<string>(new string[] {
            "192.168.4.1",
            "192.168.4.2",
            "http://",
            "/?",
            "&",
            "=",
            "/restartmain",
            "/camip",
            "OK",
            "/cam-lo.jpg",
            "Executed",
            "Already Updated"
            });
            mainBoardIP = infoArray[0];
            camIp = infoArray[1];
            isConnected = false;
            isCamConnected = false;
            channels = new List<Channel>();
            channels.Add(new Channel(0));
            channels.Add(new Channel(1));
            channels.Add(new Channel(2));
            channels.Add(new Channel(3));
            channels.Add(new Channel(4));
            channels.Add(new Channel(5));
            channels.Add(new Channel(6));
            channels.Add(new Channel(7));
            channels.Add(new Channel(8));
            channels.Add(new Channel(9));
        }
        public void updateStatus()
        {
            string result = ExecURL(infoArray[2] + mainBoardIP);
            if (result.Equals(infoArray[8]))
            {
                isConnected = true;
            }
            else
            {
                isConnected = false;
            }
        }

        

        public string ExecChannels()
        {
            bool shouldSend = false;
            string url = infoArray[2] + mainBoardIP + infoArray[3];

            for(int i = 0; i < channels.Count; i++)
            {
                if(channels[i].shouldSend)
                {
                    url += channels[i].idx + infoArray[5] + channels[i].CurrentVal + infoArray[4];
                    channels[i].shouldSend = false;
                    shouldSend = true;
                }
            }
            url = url.Remove(url.Length - 1, 1);
            if(shouldSend)
            {
                new System.Threading.Thread(delegate () {
                    ExecURL(url);
                }).Start();
                return infoArray[10]; 
            }
            return infoArray[11];
        }
        public void RestartBoard()
        {
            string url = infoArray[2] + mainBoardIP + infoArray[6];
            ExecURL(url);
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

        public void queryCamUrl()
        {
            try
            {
                string url = infoArray[2] + mainBoardIP + infoArray[7];
                if (isConnected)
                {
                    new System.Threading.Thread(delegate () {
                        MyWebClient client = new MyWebClient();
                        camIp = client.DownloadString(url);
                        client.Dispose();
                        updateCamStatus();
                    }).Start();
                }
            }
            catch(Exception ex)
            {
                return;
            }
        }
        public void updateCamStatus()
        {
            if(validateIp(camIp))
            {
                string result = ExecURL(infoArray[2] + camIp + infoArray[9]);
                if (result.Equals(infoArray[8]))
                {
                    isCamConnected = true;
                }
                else
                {
                    isCamConnected = false;
                }
            }
        }
    }
}
