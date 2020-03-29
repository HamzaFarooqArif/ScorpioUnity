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

namespace WindowsFormsApp
{
    public partial class Form_DigitalControl : Form
    {
        public static Form_DigitalControl _instance;
        private bool isKeyExecuted;
        public static Form_DigitalControl getInstance()
        {
            if (_instance == null)
            {
                _instance = new Form_DigitalControl();
            }
            return _instance;
        }
        private Form_DigitalControl()
        {
            InitializeComponent();
            isKeyExecuted = false;
        }

        private void btn_fwd_MouseDown(object sender, MouseEventArgs e)
        {
            CentralClass.getInstance().ExecChannel(CentralClass.getInstance().channels[0].idx, CentralClass.getInstance().channels[0].maxVal);
        }

        private void btn_bwd_Click(object sender, EventArgs e)
        {
            CentralClass.getInstance().ExecChannel(CentralClass.getInstance().channels[0].idx, CentralClass.getInstance().channels[0].minVal);
        }

        private void Form_DigitalControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(!isKeyExecuted)
            {
                if (e.KeyCode == Keys.W)
                {
                    CentralClass.getInstance().ExecChannel(CentralClass.getInstance().channels[0].idx, CentralClass.getInstance().channels[0].maxVal);
                    btn_fwd.Focus();
                }
                else if (e.KeyCode == Keys.S)
                {
                    CentralClass.getInstance().ExecChannel(CentralClass.getInstance().channels[0].idx, CentralClass.getInstance().channels[0].minVal);
                    btn_bwd.Focus();
                }
                isKeyExecuted = true;
            }
        }

        private void Form_DigitalControl_KeyUp(object sender, KeyEventArgs e)
        {
            if(isKeyExecuted)
            {
                if (e.KeyCode == Keys.W)
                {
                    CentralClass.getInstance().ExecChannel(CentralClass.getInstance().channels[0].idx, CentralClass.getInstance().channels[0].zeroVal);
                    btn_fwd.Focus();
                }
                else if (e.KeyCode == Keys.S)
                {
                    CentralClass.getInstance().ExecChannel(CentralClass.getInstance().channels[0].idx, CentralClass.getInstance().channels[0].zeroVal);
                    btn_bwd.Focus();
                }
                isKeyExecuted = false;
            }
            
        }
    }
}
