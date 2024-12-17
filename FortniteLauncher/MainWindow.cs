using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FortniteLauncher.files;
namespace FortniteLauncher
{
    public partial class MainWindow : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void AppExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            downloadPanel1.Hide();
            StatsPanel.Show();
            DownloadPanel.Show();
            SettingsButton.Enabled = false;
            ItemShopButton.Enabled = false;
        }
        public static Process StartProcess(string path, bool shouldFreeze, string extraArgs = "")
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    Arguments = $"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -noeac -fromfl=be -fltoken=5dh74c635862g575778132fb -skippatchcheck" + extraArgs
                }
            };
            process.Start();
            if (shouldFreeze)
            {
                foreach (object obj in process.Threads)
                {
                    ProcessThread thread = (ProcessThread)obj;
                    Win32.SuspendThread(Win32.OpenThread(2, false, thread.Id));
                }
            }
            return process;
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            var clientPath = Path.Combine(File.ReadAllText("FortniteAccount\\Path.txt"), $"FortniteGame\\Binaries\\Win64\\{stringvalues.ClientExecutable}");

            if (!File.Exists(clientPath))
            {
                MessageBox.Show($"\"{stringvalues.ClientExecutable}\" was not found, please make sure it exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var nativePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), stringvalues.dll);

            if (!File.Exists(nativePath))
            {
                MessageBox.Show($"\"{stringvalues.dll}\" was not found, please make sure it exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // need to find a better start // credits to rift for this part
            //Process process = StartProcess(File.ReadAllText("FortniteAccount\\Path.txt") + "\\FortniteGame\\Binaries\\Win64\\FortniteLauncher.exe", true, "-NOSSLPINNING");
            Process process2 = StartProcess(File.ReadAllText("FortniteAccount\\Path.txt") + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping_BE.exe", true, "");
            Process process3 = StartProcess(File.ReadAllText("FortniteAccount\\Path.txt") + "\\FortniteGame\\Binaries\\Win64\\FortniteClient-Win64-Shipping.exe", false, $"-AUTH_TYPE=epic -AUTH_LOGIN={File.ReadAllText("FortniteAccount\\Email.txt")} -AUTH_PASSWORD={File.ReadAllText("FortniteAccount\\Password.txt")}");
            process3.WaitForInputIdle();
            base.Hide();
            inject.InjectDll(process3.Id, Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), stringvalues.dll)); // change this in the stringvalues.cs or do "Yourdll.dll"
            process3.WaitForExit();
            base.Show();
        }

        private void OpenFortLibrary_Click(object sender, EventArgs e)
        {
            downloadPanel1.Show();
            StatsPanel.Hide();
            DownloadPanel.Hide();
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            downloadPanel1.Show();
            StatsPanel.Hide();
            DownloadPanel.Hide();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            downloadPanel1.Hide();
            StatsPanel.Show();
            DownloadPanel.Show();
        }

        private void AddBuildButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FortBuildWindow();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
