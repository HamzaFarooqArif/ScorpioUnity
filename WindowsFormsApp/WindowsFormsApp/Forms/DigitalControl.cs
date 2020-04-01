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
            if (!isKeyExecuted)
            {
                forward();
                isKeyExecuted = true;
            }
                
        }
        private void Form_DigitalControl_KeyDown(object sender, KeyEventArgs e)
        {
            if(!isKeyExecuted)
            {
                if (e.KeyCode == Keys.W)
                {
                    forward();
                    btn_fwd.Focus();
                }
                else if (e.KeyCode == Keys.S)
                {
                    backward();
                    btn_bwd.Focus();
                }
                else if (e.KeyCode == Keys.A)
                {
                    left();
                    btn_left.Focus();
                }
                else if (e.KeyCode == Keys.D)
                {
                    right();
                    btn_right.Focus();
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
                    stop();
                    btn_fwd.Focus();
                }
                else if (e.KeyCode == Keys.S)
                {
                    stop();
                    btn_bwd.Focus();
                }
                else if (e.KeyCode == Keys.A)
                {
                    stop();
                    btn_left.Focus();
                }
                else if (e.KeyCode == Keys.D)
                {
                    stop();
                    btn_right.Focus();
                }
                isKeyExecuted = false;
            }
        }

        private void btn_fwd_MouseUp(object sender, MouseEventArgs e)
        {
            if (isKeyExecuted)
            {
                stop();
                isKeyExecuted = false;
            }
        }

        private void btn_bwd_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isKeyExecuted)
            {
                backward();
                isKeyExecuted = true;
            }
                
        }

        private void btn_bwd_MouseUp(object sender, MouseEventArgs e)
        {
            if (isKeyExecuted)
            {
                stop();
                isKeyExecuted = false;
            }
        }

        private void forward()
        {
            CentralClass.getInstance().channels[0].CurrentVal = CentralClass.getInstance().channels[0].MaxVal;
            CentralClass.getInstance().channels[1].CurrentVal = CentralClass.getInstance().channels[1].MaxVal;


        }
        private void backward()
        {
            CentralClass.getInstance().channels[0].CurrentVal = CentralClass.getInstance().channels[0].MinVal;
            CentralClass.getInstance().channels[1].CurrentVal = CentralClass.getInstance().channels[1].MinVal;

        }
        private void left()
        {
            CentralClass.getInstance().channels[0].CurrentVal = CentralClass.getInstance().channels[0].MaxVal;
            CentralClass.getInstance().channels[1].CurrentVal = CentralClass.getInstance().channels[1].MinVal;

        }
        private void right()
        {
            CentralClass.getInstance().channels[0].CurrentVal = CentralClass.getInstance().channels[0].MinVal;
            CentralClass.getInstance().channels[1].CurrentVal = CentralClass.getInstance().channels[1].MaxVal;

        }
        private void stop()
        {
            CentralClass.getInstance().channels[0].CurrentVal = CentralClass.getInstance().channels[0].ZeroVal;
            CentralClass.getInstance().channels[1].CurrentVal = CentralClass.getInstance().channels[1].ZeroVal;

        }

        private void btn_left_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isKeyExecuted)
            {
                left();
                isKeyExecuted = true;
            }
        }

        private void btn_left_MouseUp(object sender, MouseEventArgs e)
        {
            if (isKeyExecuted)
            {
                stop();
                isKeyExecuted = false;
            }
        }

        private void btn_right_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isKeyExecuted)
            {
                right();
                isKeyExecuted = true;
            }
        }

        private void btn_right_MouseUp(object sender, MouseEventArgs e)
        {
            if (isKeyExecuted)
            {
                stop();
                isKeyExecuted = false;
            }
        }

        private void Form_DigitalControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}