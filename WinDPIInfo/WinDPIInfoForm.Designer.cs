namespace WinDPIInfo
{
    partial class WinDPIInfoForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.lblDspDpiX = new System.Windows.Forms.Label();
            this.lblDspDpiY = new System.Windows.Forms.Label();
            this.lblDpiX = new System.Windows.Forms.Label();
            this.lblDpiY = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(261, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Kthxbye";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblDspDpiX
            // 
            this.lblDspDpiX.AutoSize = true;
            this.lblDspDpiX.Location = new System.Drawing.Point(30, 30);
            this.lblDspDpiX.Name = "lblDspDpiX";
            this.lblDspDpiX.Size = new System.Drawing.Size(31, 13);
            this.lblDspDpiX.TabIndex = 1;
            this.lblDspDpiX.Text = "dpiX:";
            // 
            // lblDspDpiY
            // 
            this.lblDspDpiY.AutoSize = true;
            this.lblDspDpiY.Location = new System.Drawing.Point(30, 70);
            this.lblDspDpiY.Name = "lblDspDpiY";
            this.lblDspDpiY.Size = new System.Drawing.Size(31, 13);
            this.lblDspDpiY.TabIndex = 2;
            this.lblDspDpiY.Text = "dpiY:";
            // 
            // lblDpiX
            // 
            this.lblDpiX.AutoSize = true;
            this.lblDpiX.Location = new System.Drawing.Point(130, 30);
            this.lblDpiX.Name = "lblDpiX";
            this.lblDpiX.Size = new System.Drawing.Size(28, 13);
            this.lblDpiX.TabIndex = 3;
            this.lblDpiX.Text = "dpiX";
            // 
            // lblDpiY
            // 
            this.lblDpiY.AutoSize = true;
            this.lblDpiY.Location = new System.Drawing.Point(130, 70);
            this.lblDpiY.Name = "lblDpiY";
            this.lblDpiY.Size = new System.Drawing.Size(28, 13);
            this.lblDpiY.TabIndex = 4;
            this.lblDpiY.Text = "dpiY";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(33, 160);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "ORly?";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // WinDPIInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 261);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblDpiY);
            this.Controls.Add(this.lblDpiX);
            this.Controls.Add(this.lblDspDpiY);
            this.Controls.Add(this.lblDspDpiX);
            this.Controls.Add(this.btnOK);
            this.Name = "WinDPIInfoForm";
            this.Text = "WinDPIInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblDspDpiX;
        private System.Windows.Forms.Label lblDspDpiY;
        private System.Windows.Forms.Label lblDpiX;
        private System.Windows.Forms.Label lblDpiY;
        private System.Windows.Forms.Button btnReload;
    }
}

