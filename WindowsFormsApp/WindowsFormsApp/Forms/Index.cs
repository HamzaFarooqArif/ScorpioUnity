using DebugTools.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Forms;
using WindowsFormsApp.Utilities;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Inspector inspector = new Inspector();

            CentralClass.getInstance().updateStatus();
            tb_mainBoardIP.Text = CentralClass.getInstance().mainBoardIP;
            timer1.Interval = 1000;
            timer1.Start();
            updateControls();

            Channel_CP.getInstance().Hide();
            Form_DigitalControl.getInstance().Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tb_mainBoardIP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_mainBoardIP_KeyDown(object sender, KeyEventArgs e)
        {
            if (tb_mainBoardIP.Focused && e.KeyCode == Keys.Enter)
            {
                if (CentralClass.getInstance().validateIp(tb_mainBoardIP.Text))
                {
                    CentralClass.getInstance().mainBoardIP = tb_mainBoardIP.Text;
                    e.SuppressKeyPress = true;
                }
                else
                {
                    tb_mainBoardIP.Text = CentralClass.getInstance().mainBoardIP;
                    MessageBox.Show("Invalid IP Address");
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateControls();
        }
        private void updateControls()
        {
            if (!CentralClass.getInstance().isConnected)
            {
                new System.Threading.Thread(delegate () {
                    CentralClass.getInstance().updateStatus();
                }).Start();
            }

            if (CentralClass.getInstance().isConnected)
            {
                lbl_connection.Text = "Connected";
                lbl_connection.ForeColor = Color.Green;
            }
            else
            {
                lbl_connection.ForeColor = Color.Red;
                lbl_connection.Text = "Disonnected";
            }
        }

        private void btn_DigitalControl_Click(object sender, EventArgs e)
        {
            if(Form_DigitalControl.getInstance().Visible)
            {
                Form_DigitalControl.getInstance().Hide();
            }
            else
            {
                Form_DigitalControl.getInstance().Show();
            }
        }

        private void btn_chControl_Click(object sender, EventArgs e)
        {
            if (Channel_CP.getInstance().Visible)
            {
                Channel_CP.getInstance().Hide();
            }
            else
            {
                Channel_CP.getInstance().Show();
            }
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            CentralClass.getInstance().RestartBoard();
        }
    }
}
