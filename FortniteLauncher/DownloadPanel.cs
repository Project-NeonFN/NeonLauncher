using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FortniteLauncher
{
    public partial class DownloadPanel : UserControl
    {
        public DownloadPanel()
        {
            InitializeComponent();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://public.simplyblk.xyz/7.40.rar");
        }
    }
}
