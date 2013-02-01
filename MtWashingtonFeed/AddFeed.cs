using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace MtWashingtonFeed
{
    public partial class AddFeed : Form
    {
        public AddFeed()
        {
            InitializeComponent();

            FeedOkay = false;
        }

        /// <summary>
        /// textBoxNewFeed_TextChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNewFeed_TextChanged(object sender, EventArgs e)
        {
            feedPictureTryUpdate();
        }

        /// <summary>
        /// buttonAddNewFeed_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddNewFeed_Click(object sender, EventArgs e)
        {
            feedPictureTryUpdate();

            if (!FeedOkay)
            {
                switch (MessageBox.Show("Are you sure you want to continue?", "Invalid Image", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
                {
                    case System.Windows.Forms.DialogResult.OK:
                        this.Close();
                        return;
                    default:
                    case System.Windows.Forms.DialogResult.Cancel:
                        return;
                }
            }
            else
            {
                Properties.Settings.Default.FeedCollection.Add(textBoxNewFeed.Text);

                this.Close();
            }
        }

        /// <summary>
        /// is the feed okay?
        /// </summary>
        bool FeedOkay { get; set; }

        /// <summary>
        /// feedPictureTryUpdate
        /// </summary>
        private void feedPictureTryUpdate()
        {
            try
            {
                WebClient client = new WebClient();

                Uri tmpUri = new Uri(textBoxNewFeed.Text);

                string tmpFileName = tmpUri.Segments.Last();

                using (Stream stream = client.OpenRead(textBoxNewFeed.Text))
                {
                    Bitmap tmpBitmap = new Bitmap(stream);

                    tmpBitmap.Save(Path.Combine(
                        Properties.Settings.Default.DownloadPath, tmpFileName));

                    pictureBoxFeedImage.Image = tmpBitmap;

                    stream.Flush();
                    stream.Close();
                }

                FeedOkay = true;
            }
            catch
            {
                FeedOkay = false;

                pictureBoxFeedImage.Image = null;
                    
                pictureBoxFeedImage.Invalidate();

                pictureBoxFeedImage.Update();
            }
        }
    }
}
