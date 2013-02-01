using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MtWashingtonFeed
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// textBoxCWD_Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCWD_Enter(object sender, EventArgs e)
        {

            bool blnUseMyPictures = false;
            if (!Directory.Exists(Properties.Settings.Default.DownloadPath))
                blnUseMyPictures = true;
            else if (string.Empty.Equals(Properties.Settings.Default.DownloadPath))
                blnUseMyPictures = true;

            if (blnUseMyPictures)
                folderBrowserDialogPWD.RootFolder = Environment.SpecialFolder.MyPictures;

            folderBrowserDialogPWD.Description = "Select feed download folder";

            var result = folderBrowserDialogPWD.ShowDialog(this);

            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    UpdateRequired = true;
                    textBoxCWD.Text = folderBrowserDialogPWD.SelectedPath;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// UpdateRequired,
        /// <remarks>
        /// Warning: Has the side effect of changing button apply text
        /// </remarks>
        /// </summary>
        public bool UpdateRequired
        {
            get { return blnUpdateRequired; }
            set
            {
                if (value) buttonApply.Text = "*Apply";
                else buttonApply.Text = "Apply";

                blnUpdateRequired = value;
            }
        }
        private bool blnUpdateRequired = false;

        /// <summary>
        /// buttonApply_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FeedEnabled = checkBoxEnabled.Checked;
            Properties.Settings.Default.DownloadPath = textBoxCWD.Text;
            Properties.Settings.Default.FeedInterval = trackBarInterval.Value;
            Properties.Settings.Default.FeedCollection.Clear();
            foreach (var s in listBoxFeedCollection.Items)
                Properties.Settings.Default.FeedCollection.Add(s.ToString());
            Properties.Settings.Default.Save();
            UpdateRequired = false;

            if (!checkBoxEnabled.Checked)
                MessageBox.Show("Feeds have been prevented from automatically downloading.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Settings_Load
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event</param>
        private void Settings_Load(object sender, EventArgs e)
        {
            listBoxFeedCollection.Items.Clear();
            checkBoxEnabled.Checked = Properties.Settings.Default.FeedEnabled;
            textBoxCWD.Text = Properties.Settings.Default.DownloadPath;
            try { trackBarInterval.Value = Properties.Settings.Default.FeedInterval; }
            catch { trackBarInterval.Value = trackBarInterval.Minimum; }
            foreach (var s in Properties.Settings.Default.FeedCollection)
                listBoxFeedCollection.Items.Add(s);
            UpdateIntervalText();
        }

        /// <summary>
        /// trackBarInterval_ValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBarInterval_ValueChanged(object sender, EventArgs e)
        {
            UpdateRequired = true;
            UpdateIntervalText();
        }

        /// <summary>
        /// Updates Interval Text
        /// </summary>
        private void UpdateIntervalText()
        {
            groupBoxSynchInterval.Text =
                string.Format(SyncIntervalTextFrmt,
                new TimeSpan(0, trackBarInterval.Value, 0).ToString());
        }

        /// <summary>
        /// SyncIntervalTextFrmt
        /// </summary>
        const string SyncIntervalTextFrmt = "Synchronization Interval: {0}";

        /// <summary>
        /// buttonRemoveSelected_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxFeedCollection.Items.RemoveAt(listBoxFeedCollection.SelectedIndex);
                UpdateRequired = true;
            }
            catch { }
        }

        /// <summary>
        /// buttonAddFeed_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddFeed_Click(object sender, EventArgs e)
        {
            string strNewFeed = textBoxFeedNew.Text;

            if (!listBoxFeedCollection.Items.Contains(strNewFeed))
            {
                listBoxFeedCollection.Items.Add(strNewFeed);
                UpdateRequired = true;
            }
        }

        /// <summary>
        /// Settings_FormClosing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!UpdateRequired)
                return;

            var result = MessageBox.Show(this, "Close without saving?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            switch (result)
            {
                case System.Windows.Forms.DialogResult.OK:
                    return;
                default:
                    e.Cancel = true;
                    break;
            }

        }

        /// <summary>
        /// checkBoxEnabled_CheckedChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnabled.Checked != Properties.Settings.Default.FeedEnabled)
                UpdateRequired = true;
        }

        string MyPictures
        {
            get { return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCWD.Text = MyPictures;

            UpdateRequired = true;
        }
    }
}
