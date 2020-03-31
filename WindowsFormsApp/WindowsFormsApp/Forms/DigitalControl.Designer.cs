namespace WindowsFormsApp
{
    partial class Form_DigitalControl
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
            this.btn_fwd = new System.Windows.Forms.Button();
            this.btn_bwd = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_fwd
            // 
            this.btn_fwd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_fwd.Location = new System.Drawing.Point(83, 12);
            this.btn_fwd.Name = "btn_fwd";
            this.btn_fwd.Size = new System.Drawing.Size(70, 70);
            this.btn_fwd.TabIndex = 0;
            this.btn_fwd.Text = "Forward";
            this.btn_fwd.UseVisualStyleBackColor = true;
            this.btn_fwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_fwd_MouseDown);
            this.btn_fwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_fwd_MouseUp);
            // 
            // btn_bwd
            // 
            this.btn_bwd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_bwd.Location = new System.Drawing.Point(83, 3);
            this.btn_bwd.Name = "btn_bwd";
            this.btn_bwd.Size = new System.Drawing.Size(70, 70);
            this.btn_bwd.TabIndex = 1;
            this.btn_bwd.Text = "Backward";
            this.btn_bwd.UseVisualStyleBackColor = true;
            this.btn_bwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_bwd_MouseDown);
            this.btn_bwd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_bwd_MouseUp);
            // 
            // btn_left
            // 
            this.btn_left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_left.Location = new System.Drawing.Point(6, 3);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(70, 70);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "Left";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseDown);
            this.btn_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseUp);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(161, 3);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(70, 70);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseDown);
            this.btn_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 190);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation Controls";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(239, 171);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btn_fwd, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 85);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btn_right, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_left, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_bwd, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(239, 86);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Form_DigitalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 190);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "Form_DigitalControl";
            this.Text = "Form_DigitalControl";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_DigitalControl_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_DigitalControl_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_DigitalControl_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fwd;
        private System.Windows.Forms.Button btn_bwd;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}