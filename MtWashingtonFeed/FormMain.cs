using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace MtWashingtonFeed
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerFeed.Interval = Properties.Settings.Default.FeedInterval * 60 * 1000;
            timerFeed.Enabled = Properties.Settings.Default.FeedEnabled;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if (this == null)
            {
                //This happen on create.
                return;
            }

            //If we are minimizing the form then hide it so it doesn't show up on the 
            //task bar
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.ShowBalloonTip(3000, "Mt. Washington Feed",
                        "MtWashington Feed has be moved to the tray.",
                        ToolTipIcon.Info);
            }
            else
            {
                //any other windows state show it.
                this.Show();
            }
        }

        private string WorkingDirectory
        {
            get { return Properties.Settings.Default.DownloadPath; }
        }

        /// <summary>
        /// 
        /// </summary>
        private void PerformFeedDownload()
        {
            WebClient client = new WebClient();

            int index = 0x01;
            int p_max = Properties.Settings.Default.FeedCollection.Count;

            // clear the image list
            imageList1.Images.Clear();

            foreach (var imgURL in Properties.Settings.Default.FeedCollection)
            {
                try
                {
                    Uri tmpUri = new Uri(imgURL);

                    string tmpFileName = tmpUri.Segments.Last();

                    toolStripStatusLabel.Text = string.Format("Downloading: {0}", tmpFileName);

                    using (Stream stream = client.OpenRead(imgURL))
                    {
                        Bitmap tmpBitmap = new Bitmap(stream);

                        tmpBitmap.Save(Path.Combine(WorkingDirectory, tmpFileName));

                        imageList1.Images.Add(tmpBitmap);

                        toolStripButton2.Image = tmpBitmap;

                        stream.Flush();
                        stream.Close();
                    }

                    toolStripStatusLabel.Text += " ... [Ok]";
                }
                catch (Exception ex)
                {
                    toolStripStatusLabel.Text += " ... [Failed]";
                }
                finally
                {
                    backgroundWorkerFeed.ReportProgress((int)(((double)index / (double)p_max) * 100.0));

                    Thread.Sleep(1000);

                    index += 1;
                }
            }
        }

        /// <summary>
        /// timerFeed_Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerFeed_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorkerFeed.IsBusy)
                backgroundWorkerFeed.RunWorkerAsync();
        }

        /// <summary>
        /// toolStripButton1_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form frmSettings = new Settings();

            frmSettings.Show();
        }

        /// <summary>
        /// toolStripButton2_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // if it's the first run, show the settings form
            if (IsFirstRunOrShowSettings())
                return;

            if (!backgroundWorkerFeed.IsBusy)
                backgroundWorkerFeed.RunWorkerAsync();
        }

        /// <summary>
        /// IsFirstRunOrShowSettings
        /// </summary>
        /// <returns></returns>
        private bool IsFirstRunOrShowSettings()
        {
            bool blnIsFirstRun = FeedMiner.FirstRun;

            // if it's the first run, show the settings form
            if (FeedMiner.FirstRun)
            {
                Settings frmSettings = new Settings();

                frmSettings.Show();

                // set first run to "false"
                FeedMiner.FirstRun = false;
            }

            return blnIsFirstRun;
        }

        /// <summary>
        /// backgroundWorkerFeed_DoWork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerFeed_DoWork(object sender, DoWorkEventArgs e)
        {
            PerformFeedDownload();
        }

        /// <summary>
        /// backgroundWorkerFeed_ProgressChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerFeed_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        /// <summary>
        /// backgroundWorkerFeed_RunWorkerCompleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorkerFeed_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = "Update Completed at " + DateTime.Now.ToShortTimeString();
        }

        /// <summary>
        /// notifyIcon1_MouseDoubleClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }

            // Activate the form.
            this.Activate();
            this.Focus();
        }

        /// <summary>
        /// FormMain_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
                return;

            //There are several ways to close an application.
            //We are trying to find the click of the X in the upper right hand corner
            //We will only allow the closing of this app if it is minimized.
            if (this.WindowState != FormWindowState.Minimized)
            {
                //we don't close the app...
                e.Cancel = true;

                // minimize the app and then display a message to the user so
                // they understand they didn't close the app they just sent it to the tray.
                this.WindowState = FormWindowState.Minimized;

                //Show the message.
                notifyIcon1.ShowBalloonTip(3000, "Mt. Washington Feed",
                     "You have not closed this appliation." +
                     (Char)(13) + "It has be moved to the tray." +
                     (Char)(13) + "Right click the Icon to exit.",
                     ToolTipIcon.Info);
            }
        }

        /// <summary>
        /// toolStripButton3_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bool blnOkToExit = !FeedMiner.FirstRun;

            if (FeedMiner.FirstRun)
            {
                switch (MessageBox.Show("Save without configuring FeedMiner?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                    default:
                        blnOkToExit = true;
                        break;
                }
            }

            if (blnOkToExit)
            {
                exit = true;

                this.Close();
            }
        }

        private bool exit = false;

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();

            aboutBox.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (IsFirstRunOrShowSettings())
                return;

            bool bail = false;
            bail = !Directory.Exists(Properties.Settings.Default.DownloadPath);

            if (!bail)
                bail = string.Empty.Equals(Properties.Settings.Default.DownloadPath);
            if (bail)
            {
                Settings tmpSettings = new Settings();
                tmpSettings.Show();
            }

            const string WindowsExplorer = "explorer";

            toolStripStatusLabel.Text = "Opening windows explorer ... ";

            try
            {
                var proc = Process.Start(new ProcessStartInfo()
                {
                    FileName = WindowsExplorer,
                    Arguments = Properties.Settings.Default.DownloadPath,
                });
            }
            catch
            {
                toolStripStatusLabel.Text += "[Failed]";

                return;
            }

            toolStripStatusLabel.Text += "[Ok]";

            Thread.Sleep(1000);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            AddFeed frmAddFeed = new AddFeed();

            frmAddFeed.Show();
        }
    }
}
