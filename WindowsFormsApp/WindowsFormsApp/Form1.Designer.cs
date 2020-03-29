namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_mainBoardIP = new System.Windows.Forms.TextBox();
            this.tb_camIP = new System.Windows.Forms.TextBox();
            this.lbl_mainboardIp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_connection = new System.Windows.Forms.Label();
            this.btn_DigitalControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_mainBoardIP
            // 
            this.tb_mainBoardIP.Location = new System.Drawing.Point(89, 12);
            this.tb_mainBoardIP.Name = "tb_mainBoardIP";
            this.tb_mainBoardIP.Size = new System.Drawing.Size(100, 20);
            this.tb_mainBoardIP.TabIndex = 1;
            this.tb_mainBoardIP.TextChanged += new System.EventHandler(this.tb_mainBoardIP_TextChanged);
            this.tb_mainBoardIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_mainBoardIP_KeyDown);
            // 
            // tb_camIP
            // 
            this.tb_camIP.Enabled = false;
            this.tb_camIP.Location = new System.Drawing.Point(89, 38);
            this.tb_camIP.Name = "tb_camIP";
            this.tb_camIP.Size = new System.Drawing.Size(100, 20);
            this.tb_camIP.TabIndex = 2;
            // 
            // lbl_mainboardIp
            // 
            this.lbl_mainboardIp.AutoSize = true;
            this.lbl_mainboardIp.Location = new System.Drawing.Point(9, 15);
            this.lbl_mainboardIp.Name = "lbl_mainboardIp";
            this.lbl_mainboardIp.Size = new System.Drawing.Size(74, 13);
            this.lbl_mainboardIp.TabIndex = 6;
            this.lbl_mainboardIp.Text = "Main Board IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Camera Ip";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_connection
            // 
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.ForeColor = System.Drawing.Color.Red;
            this.lbl_connection.Location = new System.Drawing.Point(18, 71);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(119, 20);
            this.lbl_connection.TabIndex = 8;
            this.lbl_connection.Text = "Disconnected";
            // 
            // btn_DigitalControl
            // 
            this.btn_DigitalControl.Location = new System.Drawing.Point(22, 103);
            this.btn_DigitalControl.Name = "btn_DigitalControl";
            this.btn_DigitalControl.Size = new System.Drawing.Size(90, 23);
            this.btn_DigitalControl.TabIndex = 9;
            this.btn_DigitalControl.Text = "Digital Control";
            this.btn_DigitalControl.UseVisualStyleBackColor = true;
            this.btn_DigitalControl.Click += new System.EventHandler(this.btn_DigitalControl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 292);
            this.Controls.Add(this.btn_DigitalControl);
            this.Controls.Add(this.lbl_connection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_mainboardIp);
            this.Controls.Add(this.tb_camIP);
            this.Controls.Add(this.tb_mainBoardIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_mainBoardIP;
        private System.Windows.Forms.TextBox tb_camIP;
        private System.Windows.Forms.Label lbl_mainboardIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Button btn_DigitalControl;
    }
}

