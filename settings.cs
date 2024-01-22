using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SharpBrowser
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcesses();
            foreach (Process p in process) try { EmptyWorkingSet(p.Handle); } catch { }
            DirectoryInfo directory = new DirectoryInfo(Path.GetTempPath());
            foreach (FileInfo file in directory.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch { }
            }
            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch { }
            }
            directory = new DirectoryInfo(Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine));
            foreach (FileInfo file in directory.GetFiles())
            {
                try
                {
                    file.Delete();
                }
                catch { }
            }

            foreach (DirectoryInfo dir in directory.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                }
                catch { }
            }
        }

        private void EmptyWorkingSet(IntPtr handle)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://festerbrowser.jimdofree.com/",
                UseShellExecute = true
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {

                FileName = "https://pastebin.com/raw/dE5Jn9cS",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aboutpage f2 = new Aboutpage();
            f2.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        //this is not upcoming feature it was going to be but i didnt have time to do it.

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Remember that antivirus, firewalls, vpns are only layer of security.", "FesterBrowserSecurity", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("V2.4", "FesterBrowserSecurity", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

