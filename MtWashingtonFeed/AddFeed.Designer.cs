namespace MtWashingtonFeed
{
    partial class AddFeed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNewFeed = new System.Windows.Forms.TextBox();
            this.buttonAddNewFeed = new System.Windows.Forms.Button();
            this.pictureBoxFeedImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNewFeed
            // 
            this.textBoxNewFeed.Location = new System.Drawing.Point(82, 21);
            this.textBoxNewFeed.Name = "textBoxNewFeed";
            this.textBoxNewFeed.Size = new System.Drawing.Size(190, 20);
            this.textBoxNewFeed.TabIndex = 0;
            this.textBoxNewFeed.TextChanged += new System.EventHandler(this.textBoxNewFeed_TextChanged);
            // 
            // buttonAddNewFeed
            // 
            this.buttonAddNewFeed.Location = new System.Drawing.Point(180, 47);
            this.buttonAddNewFeed.Name = "buttonAddNewFeed";
            this.buttonAddNewFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewFeed.TabIndex = 1;
            this.buttonAddNewFeed.Text = "Ok";
            this.buttonAddNewFeed.UseVisualStyleBackColor = true;
            this.buttonAddNewFeed.Click += new System.EventHandler(this.buttonAddNewFeed_Click);
            // 
            // pictureBoxFeedImage
            // 
            this.pictureBoxFeedImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxFeedImage.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFeedImage.Name = "pictureBoxFeedImage";
            this.pictureBoxFeedImage.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxFeedImage.TabIndex = 3;
            this.pictureBoxFeedImage.TabStop = false;
            // 
            // AddFeed
            // 
            this.AcceptButton = this.buttonAddNewFeed;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 89);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxFeedImage);
            this.Controls.Add(this.buttonAddNewFeed);
            this.Controls.Add(this.textBoxNewFeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddFeed";
            this.ShowInTaskbar = false;
            this.Text = "Add Feed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeedImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewFeed;
        private System.Windows.Forms.Button buttonAddNewFeed;
        private System.Windows.Forms.PictureBox pictureBoxFeedImage;
    }
}