using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SharpBrowser
{
    public partial class AutokillWizard : Form
    {
        private System.Timers.Timer exitTimer;
        public AutokillWizard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitializeComponent();

            exitTimer = new System.Timers.Timer();
            exitTimer.Interval = 600000; // 10 minutes in milliseconds
            exitTimer.Elapsed += ExitTimer_Elapsed;
            exitTimer.AutoReset = false; // Set AutoReset to false to exit after one interval
            exitTimer.Start();
        }

        private void ExitTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            exitTimer.Stop();
            Application.Exit();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            Thread.Sleep(1800000);
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread.Sleep(3600000);
            Application.Exit();
        }
    }
}
