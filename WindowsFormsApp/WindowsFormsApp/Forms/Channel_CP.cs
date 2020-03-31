using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Utilities;

namespace WindowsFormsApp.Forms
{
    public partial class Channel_CP : Form
    {
        private static Channel_CP _instance;
        public static Channel_CP getInstance()
        {
            if (_instance == null) _instance = new Channel_CP();
            return _instance;
        }
        public Channel_CP()
        {
            InitializeComponent();

            setupControls();
        }

        private void setupControls()
        {
            for(int i = 0; i < Channel.channelCount; i++)
            {
                FLP_ChannelControls.Controls.Add(ChannelControl.getInstance(FLP_ChannelControls.Controls.Count));
            }
            timer.Start();
            loadSettings();
        }
        private void timer_Tick(object sender, EventArgs e)
        {

        }
        private void appendControl(UserControl childControl)
        {
            FLP_ChannelControls.Controls.Add(childControl);
        }

        private void Channel_CP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveSettings();
            MessageBox.Show("All Channels Settings Saved");
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void loadSettings()
        {
            foreach (ChannelControl cc in ChannelControl._instance)
            {
                cc.loadSettings();
            }
        }
        private void saveSettings()
        {
            foreach (ChannelControl cc in ChannelControl._instance)
            {
                cc.saveSettings();
            }
        }
    }
}
