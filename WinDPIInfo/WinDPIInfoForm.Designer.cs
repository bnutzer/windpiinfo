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
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.lblDspWinDpiX = new System.Windows.Forms.Label();
            this.lblDspWinDpiY = new System.Windows.Forms.Label();
            this.lblWinDpiX = new System.Windows.Forms.Label();
            this.lblWinDpiY = new System.Windows.Forms.Label();
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
            this.lblDspDpiX.Text = "System dpiX:";
            // 
            // lblDspDpiY
            // 
            this.lblDspDpiY.AutoSize = true;
            this.lblDspDpiY.Location = new System.Drawing.Point(30, 70);
            this.lblDspDpiY.Name = "lblDspDpiY";
            this.lblDspDpiY.Size = new System.Drawing.Size(31, 13);
            this.lblDspDpiY.TabIndex = 2;
            this.lblDspDpiY.Text = "System dpiY:";
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
            // lblLastUpdate
            // 
            this.lblLastUpdate.AutoSize = true;
            this.lblLastUpdate.Location = new System.Drawing.Point(30, 110);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(71, 13);
            this.lblLastUpdate.TabIndex = 6;
            this.lblLastUpdate.Text = "(last updated)";
            // 
            // lblWinDpiX
            // 
            this.lblWinDpiX.AutoSize = true;
            this.lblWinDpiX.Location = new System.Drawing.Point(218, 70);
            this.lblWinDpiX.Name = "lblWinDpiX";
            this.lblWinDpiX.Size = new System.Drawing.Size(31, 13);
            this.lblWinDpiX.TabIndex = 8;
            this.lblWinDpiX.Text = "dpiY:";
            // 
            // lblWinDpiY
            // 
            this.lblWinDpiY.AutoSize = true;
            this.lblWinDpiY.Location = new System.Drawing.Point(218, 30);
            this.lblWinDpiY.Name = "lblWinDpiY";
            this.lblWinDpiY.Size = new System.Drawing.Size(31, 13);
            this.lblWinDpiY.TabIndex = 7;
            this.lblWinDpiY.Text = "dpiX:";
            // 
            // lblDspWinDpiX
            // 
            this.lblDspWinDpiX.AutoSize = true;
            this.lblDspWinDpiX.Location = new System.Drawing.Point(318, 70);
            this.lblDspWinDpiX.Name = "lblDspWinDpiX";
            this.lblDspWinDpiX.Size = new System.Drawing.Size(28, 13);
            this.lblDspWinDpiX.TabIndex = 10;
            this.lblDspWinDpiX.Text = "dpiY";
            // 
            // lblDspWinDpiY
            // 
            this.lblDspWinDpiY.AutoSize = true;
            this.lblDspWinDpiY.Location = new System.Drawing.Point(318, 30);
            this.lblDspWinDpiY.Name = "lblDspWinDpiY";
            this.lblDspWinDpiY.Size = new System.Drawing.Size(28, 13);
            this.lblDspWinDpiY.TabIndex = 9;
            this.lblDspWinDpiY.Text = "dpiX";
            // 
            // WinDPIInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(372, 199);
            this.Controls.Add(this.lblWinDpiX);
            this.Controls.Add(this.lblWinDpiY);
            this.Controls.Add(this.lblDspWinDpiX);
            this.Controls.Add(this.lblDspWinDpiY);
            this.Controls.Add(this.lblLastUpdate);
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
        private System.Windows.Forms.Label lblLastUpdate;
        private System.Windows.Forms.Label lblWinDpiX;
        private System.Windows.Forms.Label lblWinDpiY;
        private System.Windows.Forms.Label lblDspWinDpiX;
        private System.Windows.Forms.Label lblDspWinDpiY;
    }
}

