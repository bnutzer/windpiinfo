using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDPIInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            PROCESS_DPI_AWARENESS awareness;
            DpiNativeAccess.GetProcessDpiAwareness(Process.GetCurrentProcess().Handle, out awareness);
            Console.WriteLine(@"(main) Current level of api awareness: " + awareness);
            DpiNativeAccess.SetProcessDpiAwareness(PROCESS_DPI_AWARENESS.Process_Per_Monitor_DPI_Aware);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WinDPIInfoForm());
        }

    }
}
