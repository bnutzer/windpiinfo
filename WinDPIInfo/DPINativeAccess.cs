using System;
using System.Runtime.InteropServices;

namespace WinDPIInfo
{
    public enum PROCESS_DPI_AWARENESS
    {
        Process_DPI_Unaware = 0,
        Process_System_DPI_Aware = 1,
        Process_Per_Monitor_DPI_Aware = 2
    }

    public enum MONITOR_DPI_TYPE
    {
        MDT_EFFECTIVE_DPI = 0,
        MDT_ANGULAR_DPI = 1,
        MDT_RAW_DPI = 2,
        MDT_DEFAULT = MDT_EFFECTIVE_DPI
    }

    internal enum MONITOR_DEFAULTTO : uint
    {
        MONITOR_DEFAULTTONULL = 0x00000000,
        MONITOR_DEFAULTTOPRIMARY = 0x00000001,
        MONITOR_DEFAULTTONEAREST = 0x00000002,
    }

    public class DpiNativeAccess
    {
        [DllImport("SHCore.dll", SetLastError = true)]
        public static extern void GetProcessDpiAwareness(IntPtr hprocess, out PROCESS_DPI_AWARENESS awareness);

        [DllImport("shcore.dll")]
        public static extern int SetProcessDpiAwareness(PROCESS_DPI_AWARENESS awareness);

        [DllImport("SHCore.dll", SetLastError = true)]
        public static extern void GetDpiForMonitor(IntPtr monitor, MONITOR_DPI_TYPE type, ref uint newDpiX, ref uint newDpiY);

        [DllImport("user32.dll")]
        static extern IntPtr MonitorFromWindow(IntPtr hwnd, MONITOR_DEFAULTTO dwFlags);

        public static Tuple<uint,uint> GetDpiFromHwndSource(IntPtr targetSourceHandle)
        {
            /*
            if (targetSource == null)
                throw new ArgumentNullException(@"targetSource");
            */

            var handleMonitor = MonitorFromWindow(
                targetSourceHandle,
                MONITOR_DEFAULTTO.MONITOR_DEFAULTTONEAREST);

            if (handleMonitor == IntPtr.Zero)
                return null;

            uint dpiX = 1;
            uint dpiY = 1;

            GetDpiForMonitor(
                handleMonitor,
                MONITOR_DPI_TYPE.MDT_DEFAULT,
                ref dpiX,
                ref dpiY);

            return new Tuple<uint, uint>(dpiX, dpiY);

        }

        private static ushort GetLoWord(uint dword)
        {
            return (ushort)(dword & 0xffff);
        }

        private static ushort GetHiWord(uint dword)
        {
            return (ushort)(dword >> 16);
        }

    }
}