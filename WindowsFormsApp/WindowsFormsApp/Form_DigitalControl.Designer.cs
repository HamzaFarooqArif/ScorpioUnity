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
            this.SuspendLayout();
            // 
            // btn_fwd
            // 
            this.btn_fwd.Location = new System.Drawing.Point(88, 66);
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
            this.btn_bwd.Location = new System.Drawing.Point(88, 142);
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
            this.btn_left.Location = new System.Drawing.Point(12, 141);
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
            this.btn_right.Location = new System.Drawing.Point(164, 142);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(70, 70);
            this.btn_right.TabIndex = 3;
            this.btn_right.Text = "Right";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseDown);
            this.btn_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseUp);
            // 
            // Form_DigitalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 223);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.btn_bwd);
            this.Controls.Add(this.btn_fwd);
            this.KeyPreview = true;
            this.Name = "Form_DigitalControl";
            this.Text = "Form_DigitalControl";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_DigitalControl_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_DigitalControl_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fwd;
        private System.Windows.Forms.Button btn_bwd;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_right;
    }
}