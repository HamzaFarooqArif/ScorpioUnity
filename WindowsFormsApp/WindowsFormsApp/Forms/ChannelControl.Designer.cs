namespace WindowsFormsApp.Forms
{
    partial class ChannelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.tb_current = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.num_Max = new System.Windows.Forms.NumericUpDown();
            this.num_Min = new System.Windows.Forms.NumericUpDown();
            this.num_zero = new System.Windows.Forms.NumericUpDown();
            this.trk_channel = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_zero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_channel)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(170, 140);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel3);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(0, 0);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(170, 140);
            this.groupBox9.TabIndex = 16;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Channel";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.8595F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.1405F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(164, 121);
            this.tableLayoutPanel3.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.30769F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.69231F));
            this.tableLayoutPanel2.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_current, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label27, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.num_Max, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.num_Min, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.num_zero, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.trk_channel, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.602151F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.10753F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 92);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(118, 8);
            this.panel17.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Red;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(59, 8);
            this.panel18.TabIndex = 0;
            // 
            // tb_current
            // 
            this.tb_current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_current.Location = new System.Drawing.Point(118, 0);
            this.tb_current.Margin = new System.Windows.Forms.Padding(0);
            this.tb_current.Name = "tb_current";
            this.tb_current.ReadOnly = true;
            this.tb_current.Size = new System.Drawing.Size(46, 20);
            this.tb_current.TabIndex = 1;
            this.tb_current.Tag = "tb_current";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(0, 75);
            this.label25.Margin = new System.Windows.Forms.Padding(0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(68, 13);
            this.label25.TabIndex = 7;
            this.label25.Text = "Middle Value";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(0, 38);
            this.label27.Margin = new System.Windows.Forms.Padding(0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Max Value";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(0, 56);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Min Value";
            // 
            // num_Max
            // 
            this.num_Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_Max.Location = new System.Drawing.Point(118, 36);
            this.num_Max.Margin = new System.Windows.Forms.Padding(0);
            this.num_Max.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_Max.Name = "num_Max";
            this.num_Max.Size = new System.Drawing.Size(46, 20);
            this.num_Max.TabIndex = 8;
            this.num_Max.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Max_KeyDown);
            // 
            // num_Min
            // 
            this.num_Min.Location = new System.Drawing.Point(118, 54);
            this.num_Min.Margin = new System.Windows.Forms.Padding(0);
            this.num_Min.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_Min.Name = "num_Min";
            this.num_Min.Size = new System.Drawing.Size(46, 20);
            this.num_Min.TabIndex = 9;
            this.num_Min.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Min_KeyDown);
            // 
            // num_zero
            // 
            this.num_zero.Location = new System.Drawing.Point(118, 72);
            this.num_zero.Margin = new System.Windows.Forms.Padding(0);
            this.num_zero.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.num_zero.Name = "num_zero";
            this.num_zero.Size = new System.Drawing.Size(46, 20);
            this.num_zero.TabIndex = 10;
            this.num_zero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_zero_KeyDown);
            // 
            // trk_channel
            // 
            this.trk_channel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trk_channel.Location = new System.Drawing.Point(3, 11);
            this.trk_channel.Maximum = 180;
            this.trk_channel.Name = "trk_channel";
            this.trk_channel.Size = new System.Drawing.Size(112, 22);
            this.trk_channel.TabIndex = 11;
            this.trk_channel.ValueChanged += new System.EventHandler(this.trk_channel_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_load, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_save, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 92);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(164, 29);
            this.tableLayoutPanel4.TabIndex = 19;
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(85, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 22);
            this.btn_load.TabIndex = 1;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(3, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 22);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // ChannelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChannelControl";
            this.Size = new System.Drawing.Size(170, 140);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_zero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trk_channel)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox tb_current;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown num_Max;
        private System.Windows.Forms.NumericUpDown num_Min;
        private System.Windows.Forms.NumericUpDown num_zero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TrackBar trk_channel;
    }
}
