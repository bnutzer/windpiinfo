using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x02E0: //WM_DPICHANGED
                {
                    UpdateLabels(true);
                }
                break;
            }

            base.DefWndProc(ref m);
        }

        private void UpdateLabels(bool showDate = false)
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

            Console.WriteLine(@"Update ..." + showDate);

            if (showDate)
            {
                lblLastUpdate.Text = "Last updated: " + DateTime.Now.ToString("F", CultureInfo.CurrentCulture);
                Console.WriteLine("Update ...");
            }
            else
            {
                lblLastUpdate.Text = String.Empty;
            }

            var t = DpiNativeAccess.GetDpiFromHwndSource(Handle);
            lblDspWinDpiX.Text = t.Item1.ToString("F");
            lblDspWinDpiY.Text = t.Item2.ToString("F");
            Console.WriteLine(@"DPIs for window: " + t.Item1 + @" / " + t.Item2);

            PROCESS_DPI_AWARENESS awareness;
            DpiNativeAccess.GetProcessDpiAwareness(Process.GetCurrentProcess().Handle, out awareness);
            Console.WriteLine(@"Current level of api awareness: " + awareness);

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
