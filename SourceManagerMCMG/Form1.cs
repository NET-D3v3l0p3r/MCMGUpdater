using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.IO.Compression;
using System.Diagnostics;

namespace SourceManagerMCMG
{
    public partial class SourceManagerMCMG : Form
    {
        public SourceManagerMCMG()
        {
            InitializeComponent();
        }

        private void SourceManagerMCMG_Load(object sender, EventArgs e)
        {
            save.Enabled = false;
            tb_url.Text = "https://github.com/NET-D3v3l0p3r/MCMG/archive/master.zip";

            string tempDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!Directory.Exists(tempDir + @"\SourceManagerMCMG"))
            {
                Directory.CreateDirectory(tempDir + @"\SourceManagerMCMG");
                save.Enabled = true;
                return;
            }

            string path = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SourceManagerMCMG\save.dat");
            string version = File.ReadAllText(path).Replace("\n", "");

            WebClient webClient = new WebClient();
            string s = webClient.DownloadString(@"https://raw.githubusercontent.com/NET-D3v3l0p3r/MCMG/master/Version").Replace("\n", "");
            if (double.Parse( s) <= double.Parse(version))
            {
                MessageBox.Show("You have the latest version!");
                Close();
                return;
            }

            save.Enabled = true;

        }

        private void save_Click(object sender, EventArgs e)
        {
            save.Enabled = false;
            downloadPb.Value = 0;
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowDialog();

            if (String.IsNullOrEmpty(folderBrowser.SelectedPath))
                return;

            string path = folderBrowser.SelectedPath;

            WebClient webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler((s1, status) =>
            {
                downloadPb.Value = (status.ProgressPercentage);
            });
            webClient.DownloadFileCompleted += new AsyncCompletedEventHandler((s1, e1) =>
            {
                if (Directory.Exists(path + @"\MCMG-master"))
                {
                    Directory.Delete(path + @"\MCMG-master", true);
                }
                ZipFile.ExtractToDirectory(path + @"\src.zip", path);
                File.Delete(path + @"\src.zip");
                string tempDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                File.WriteAllText(tempDir + @"\SourceManagerMCMG\save.dat", path + @"\MCMG-master\Version");
                if (MessageBox.Show("Done!" + Environment.NewLine + "Do You want to open the solution? (Requires Visual Studio 2016 !)", "Succeed!", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.No)
                    return;

 
                Process.Start(path + @"\MCMG -master\ShootCube.csproj");

            });

            webClient.DownloadFileAsync(new Uri(tb_url.Text), path + @"\src.zip");
            
        }
    }
}
