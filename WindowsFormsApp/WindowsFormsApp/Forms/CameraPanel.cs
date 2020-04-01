using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Utilities;

namespace WindowsFormsApp.Forms
{

    public partial class CameraPanel : Form
    {
        private static CameraPanel _instance;
        private Mat frame;
        private bool isStreaming;
        private int quality;
        public static CameraPanel getInstance()
        {
            if (_instance == null) _instance = new CameraPanel();
            return _instance;
        }
        public CameraPanel()
        {
            InitializeComponent();
            setupControls();
        }
        private void setupControls()
        {
            cb_quality.Items.Add("Low-Res");
            cb_quality.Items.Add("High-Res");
            cb_quality.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_quality.SelectedIndex = 0;
            quality = cb_quality.SelectedIndex;
            ib_Preview.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            frame = new Mat();
            isStreaming = false;
            timer.Start();
        }
        private void updateControls()
        {
            tb_CameraIP.Text = CentralClass.getInstance().CamIp;
            if(isStreaming)
            {
                if (btn_startStream.Enabled) btn_startStream.Enabled = false;
                if (!btn_stopStream.Enabled) btn_stopStream.Enabled = true;
                if (!btn_refresh.Enabled) btn_refresh.Enabled = true;
                if (!cb_quality.Enabled) cb_quality.Enabled = true;
            }
            else
            {
                if (!btn_startStream.Enabled) btn_startStream.Enabled = true;
                if (btn_stopStream.Enabled) btn_stopStream.Enabled = false;
                if (btn_refresh.Enabled) btn_refresh.Enabled = false;
                if (cb_quality.Enabled) cb_quality.Enabled = false;
            }
            if (CentralClass.getInstance().isCamConnected && isStreaming)
            {
                lbl_connection.Text = "Connected";
                lbl_connection.ForeColor = Color.Green;
                new System.Threading.Thread(delegate () {
                    processFrame();
                }).Start();
            }
            else
            {
                lbl_connection.Text = "Disconnected";
                lbl_connection.ForeColor = Color.Red;
            }
        }

        private void processFrame()
        {
            try
            {
                MyWebClient client = new MyWebClient();
                Stream stream;
                if(quality == 0) stream = client.OpenRead("http://" + CentralClass.getInstance().CamIp + "/cam-lo.jpg");
                else stream = client.OpenRead("http://" + CentralClass.getInstance().CamIp + "/cam-hi.jpg");
                Bitmap bitmap = new Bitmap(stream);

                if (bitmap != null)
                {
                    Image<Bgr, Byte> imageCV = new Image<Bgr, byte>(bitmap); //Image Class from Emgu.CV
                    frame = imageCV.Mat;
                    ib_Preview.Image = frame;
                    CentralClass.getInstance().isCamConnected = true;
                }
                stream.Flush();
                stream.Close();
                client.Dispose();
            }
            catch(Exception ex)
            {
                return;
            }
        }

        private void CameraPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            updateControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CentralClass.getInstance().queryCamUrl();
            CentralClass.getInstance().updateCamStatus();
        }

        private void tb_CameraIP_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_startStream_Click(object sender, EventArgs e)
        {
            isStreaming = true;
        }

        private void btn_stopStream_Click(object sender, EventArgs e)
        {
            isStreaming = false;
        }

        private void cb_quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_quality.Focused)
            {
                quality = cb_quality.SelectedIndex;
            }
        }
    }
}
