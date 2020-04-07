using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Utilities;

namespace WindowsFormsApp.Forms
{
    public partial class ChannelControl : UserControl
    {
        public static List<ChannelControl> _instance;
        public int idx;
        Timer timer;
        public static ChannelControl getInstance(int idx)
        {
            if (_instance == null)
            {
                _instance = new List<ChannelControl>();
            }
            while (_instance.Count - 1 < idx)
            {
                _instance.Add(new ChannelControl());
            }
            return _instance[idx];
        }
        private ChannelControl()
        {
            InitializeComponent();
            setupControls();
            loadSettings();
            updateControls();
        }

        private void setupControls()
        {
            idx = _instance.Count;
            groupBox9.Text = "Channel " + (idx + 1);
            timer = new Timer();
            timer.Interval = CentralClass.getInstance().refreshInterval;
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (!CentralClass.getInstance().isConnected) return;
            updateControls();
        }

        private void updateControls()
        {
            panel18.Width = (int)(((float)CentralClass.getInstance().channels[idx].CurrentVal / (float)CentralClass.getInstance().channels[idx].MaxVal) * panel17.Width);
            if (!tb_current.Focused) tb_current.Text = CentralClass.getInstance().channels[idx].CurrentVal.ToString();
            if (!num_Max.Focused) num_Max.Value = CentralClass.getInstance().channels[idx].MaxVal;
            if (!num_Min.Focused) num_Min.Value = CentralClass.getInstance().channels[idx].MinVal;
            if (!num_zero.Focused) num_zero.Value = CentralClass.getInstance().channels[idx].ZeroVal;
            if (!trk_channel.Focused) trk_channel.Value = CentralClass.getInstance().channels[idx].CurrentVal;
        }

        private void num_Max_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && num_Max.Focused)
            {
                CentralClass.getInstance().channels[idx].MaxVal = (int)num_Max.Value;
                e.SuppressKeyPress = true;
            }
        }

        private void num_Min_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && num_Min.Focused)
            {
                CentralClass.getInstance().channels[idx].MinVal = (int)num_Min.Value;
                e.SuppressKeyPress = true;
            }
        }

        private void num_zero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && num_zero.Focused)
            {
                CentralClass.getInstance().channels[idx].ZeroVal = (int)num_zero.Value;
                e.SuppressKeyPress = true;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveSettings();
            MessageBox.Show(groupBox9.Text + " Settings Saved");
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadSettings();
            updateControls();
        }
        public void saveSettings()
        {
            Config.save("ChannelControl" + idx + "Max", (int)num_Max.Value);
            Config.save("ChannelControl" + idx + "Min", (int)num_Min.Value);
            Config.save("ChannelControl" + idx + "Mid", (int)num_zero.Value);
        }
        public void loadSettings()
        {
            CentralClass.getInstance().channels[idx].MaxVal = Config.load("ChannelControl" + idx + "Max");
            CentralClass.getInstance().channels[idx].MinVal = Config.load("ChannelControl" + idx + "Min");
            CentralClass.getInstance().channels[idx].ZeroVal = Config.load("ChannelControl" + idx + "Mid");
        }

        private void trk_channel_ValueChanged(object sender, EventArgs e)
        {
            if(trk_channel.Focused && CentralClass.getInstance().isConnected)
            {
                CentralClass.getInstance().channels[idx].CurrentVal = trk_channel.Value;
            }
        }
    }
}