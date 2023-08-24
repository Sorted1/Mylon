using KeyAuth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth
{
    class AntiDebug
    {
        internal static class Program
        {
            [DllImport("user32.dll")]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [DllImport("user32.dll")]
            public static extern bool IsWindowVisible(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

            private const int SW_RESTORE = 9;

            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Process[] anyDeskProcesses = Process.GetProcessesByName("anydesk");
                if (anyDeskProcesses.Length > 0)
                {
                    ExecuteAnotherFile();
                }
                else
                {
                    Application.Run(new Login());
                }
            }

            private static void ExecuteAnotherFile()
            {
                Process.Start("start another program if anydesk is open");
            }
        }
    }
}
