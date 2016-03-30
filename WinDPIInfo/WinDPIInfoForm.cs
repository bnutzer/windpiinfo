using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDPIInfo
{
    public partial class WinDPIInfoForm : Form
    {
        public WinDPIInfoForm()
        {
            InitializeComponent();

            UpdateLabels();
        }

        private void UpdateLabels(bool box = false)
        {
            /** Based on
             * http://stackoverflow.com/questions/6844161/how-to-get-dpi-in-c-sharp-net
             */
            using (var graphics = this.CreateGraphics())
            {
                var dpiX = graphics.DpiX;
                var dpiY = graphics.DpiY;

                lblDpiX.Text = dpiX.ToString(CultureInfo.CurrentCulture);
                lblDpiY.Text = dpiY.ToString(CultureInfo.CurrentCulture);
            }

            if (box) {
                MessageBox.Show("Updated.");
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UpdateLabels(true);
        }
    }
}
