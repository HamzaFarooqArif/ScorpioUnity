namespace WindowsFormsApp.Forms
{
    partial class CameraPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_CameraIP = new System.Windows.Forms.TextBox();
            this.ib_Preview = new Emgu.CV.UI.ImageBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_connection = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_startStream = new System.Windows.Forms.Button();
            this.btn_stopStream = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cb_quality = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ib_Preview)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera IP";
            // 
            // tb_CameraIP
            // 
            this.tb_CameraIP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_CameraIP.Location = new System.Drawing.Point(134, 8);
            this.tb_CameraIP.Margin = new System.Windows.Forms.Padding(0);
            this.tb_CameraIP.Name = "tb_CameraIP";
            this.tb_CameraIP.ReadOnly = true;
            this.tb_CameraIP.Size = new System.Drawing.Size(134, 20);
            this.tb_CameraIP.TabIndex = 1;
            // 
            // ib_Preview
            // 
            this.ib_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ib_Preview.Location = new System.Drawing.Point(3, 16);
            this.ib_Preview.Margin = new System.Windows.Forms.Padding(0);
            this.ib_Preview.Name = "ib_Preview";
            this.ib_Preview.Size = new System.Drawing.Size(529, 404);
            this.ib_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ib_Preview.TabIndex = 2;
            this.ib_Preview.TabStop = false;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.Location = new System.Drawing.Point(402, 7);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(0);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(136, 23);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_connection
            // 
            this.lbl_connection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connection.ForeColor = System.Drawing.Color.Red;
            this.lbl_connection.Location = new System.Drawing.Point(268, 8);
            this.lbl_connection.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(134, 20);
            this.lbl_connection.TabIndex = 9;
            this.lbl_connection.Text = "Disconnected";
            // 
            // timer
            // 
            this.timer.Interval = 400;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_startStream
            // 
            this.btn_startStream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startStream.Location = new System.Drawing.Point(108, 8);
            this.btn_startStream.Margin = new System.Windows.Forms.Padding(0);
            this.btn_startStream.Name = "btn_startStream";
            this.btn_startStream.Size = new System.Drawing.Size(99, 23);
            this.btn_startStream.TabIndex = 10;
            this.btn_startStream.Text = "Start Streaming";
            this.btn_startStream.UseVisualStyleBackColor = true;
            this.btn_startStream.Click += new System.EventHandler(this.btn_startStream_Click);
            // 
            // btn_stopStream
            // 
            this.btn_stopStream.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_stopStream.Location = new System.Drawing.Point(211, 8);
            this.btn_stopStream.Margin = new System.Windows.Forms.Padding(0);
            this.btn_stopStream.Name = "btn_stopStream";
            this.btn_stopStream.Size = new System.Drawing.Size(103, 23);
            this.btn_stopStream.TabIndex = 11;
            this.btn_stopStream.Text = "Stop";
            this.btn_stopStream.UseVisualStyleBackColor = true;
            this.btn_stopStream.Click += new System.EventHandler(this.btn_stopStream_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_CameraIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_connection, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_refresh, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(538, 37);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.368421F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.26316F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.631579F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(541, 505);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btn_startStream, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_stopStream, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cb_quality, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 466);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(316, 39);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // cb_quality
            // 
            this.cb_quality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_quality.FormattingEnabled = true;
            this.cb_quality.Location = new System.Drawing.Point(0, 9);
            this.cb_quality.Margin = new System.Windows.Forms.Padding(0);
            this.cb_quality.Name = "cb_quality";
            this.cb_quality.Size = new System.Drawing.Size(105, 21);
            this.cb_quality.TabIndex = 12;
            this.cb_quality.SelectedIndexChanged += new System.EventHandler(this.cb_quality_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ib_Preview);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 423);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stream";
            // 
            // CameraPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 505);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CameraPanel";
            this.Text = "Camera Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraPanel_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ib_Preview)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_CameraIP;
        private Emgu.CV.UI.ImageBox ib_Preview;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_startStream;
        private System.Windows.Forms.Button btn_stopStream;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cb_quality;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}