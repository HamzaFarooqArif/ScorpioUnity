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
            this.lbl_mainboardIp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_connection = new System.Windows.Forms.Label();
            this.btn_DigitalControl = new System.Windows.Forms.Button();
            this.btn_chControl = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_mainBoardIP
            // 
            this.tb_mainBoardIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mainBoardIP.Location = new System.Drawing.Point(84, 7);
            this.tb_mainBoardIP.Margin = new System.Windows.Forms.Padding(0);
            this.tb_mainBoardIP.Name = "tb_mainBoardIP";
            this.tb_mainBoardIP.Size = new System.Drawing.Size(127, 20);
            this.tb_mainBoardIP.TabIndex = 1;
            this.tb_mainBoardIP.TextChanged += new System.EventHandler(this.tb_mainBoardIP_TextChanged);
            this.tb_mainBoardIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_mainBoardIP_KeyDown);
            // 
            // lbl_mainboardIp
            // 
            this.lbl_mainboardIp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_mainboardIp.AutoSize = true;
            this.lbl_mainboardIp.Location = new System.Drawing.Point(0, 10);
            this.lbl_mainboardIp.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_mainboardIp.Name = "lbl_mainboardIp";
            this.lbl_mainboardIp.Size = new System.Drawing.Size(74, 13);
            this.lbl_mainboardIp.TabIndex = 6;
            this.lbl_mainboardIp.Text = "Main Board IP";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_connection
            // 
            this.lbl_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.ForeColor = System.Drawing.Color.Red;
            this.lbl_connection.Location = new System.Drawing.Point(211, 7);
            this.lbl_connection.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(125, 20);
            this.lbl_connection.TabIndex = 8;
            this.lbl_connection.Text = "Disconnected";
            // 
            // btn_DigitalControl
            // 
            this.btn_DigitalControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_DigitalControl.Location = new System.Drawing.Point(0, 0);
            this.btn_DigitalControl.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DigitalControl.Name = "btn_DigitalControl";
            this.btn_DigitalControl.Size = new System.Drawing.Size(168, 34);
            this.btn_DigitalControl.TabIndex = 9;
            this.btn_DigitalControl.Text = "Digital Control";
            this.btn_DigitalControl.UseVisualStyleBackColor = true;
            this.btn_DigitalControl.Click += new System.EventHandler(this.btn_DigitalControl_Click);
            // 
            // btn_chControl
            // 
            this.btn_chControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_chControl.Location = new System.Drawing.Point(0, 34);
            this.btn_chControl.Margin = new System.Windows.Forms.Padding(0);
            this.btn_chControl.Name = "btn_chControl";
            this.btn_chControl.Size = new System.Drawing.Size(168, 34);
            this.btn_chControl.TabIndex = 10;
            this.btn_chControl.Text = "Channel Control Panel";
            this.btn_chControl.UseVisualStyleBackColor = true;
            this.btn_chControl.Click += new System.EventHandler(this.btn_chControl_Click);
            // 
            // btn_Restart
            // 
            this.btn_Restart.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Restart.Location = new System.Drawing.Point(261, 39);
            this.btn_Restart.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 23);
            this.btn_Restart.TabIndex = 11;
            this.btn_Restart.Text = "Restart";
            this.btn_Restart.UseVisualStyleBackColor = true;
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 87);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Board Config";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Restart, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 68);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_mainboardIp, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_connection, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_mainBoardIP, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(336, 34);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 87);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Panels";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_chControl, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_DigitalControl, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 68);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(168, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Camera Panel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(168, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Analog Control";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(342, 174);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 174);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "Form1";
            this.Text = "Scorpio Winforms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_mainBoardIP;
        private System.Windows.Forms.Label lbl_mainboardIp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Button btn_DigitalControl;
        private System.Windows.Forms.Button btn_chControl;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

