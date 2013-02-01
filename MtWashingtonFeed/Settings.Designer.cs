namespace MtWashingtonFeed
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.listBoxFeedCollection = new System.Windows.Forms.ListBox();
            this.buttonAddFeed = new System.Windows.Forms.Button();
            this.textBoxFeedNew = new System.Windows.Forms.TextBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPageSynchSettings = new System.Windows.Forms.TabPage();
            this.groupBoxSynchInterval = new System.Windows.Forms.GroupBox();
            this.trackBarInterval = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCWD = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.folderBrowserDialogPWD = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageSynchSettings.SuspendLayout();
            this.groupBoxSynchInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFeedCollection
            // 
            this.listBoxFeedCollection.FormattingEnabled = true;
            this.listBoxFeedCollection.Items.AddRange(new object[] {
            "http://www.mountwashington.org/weather/conditions.png",
            "http://www.mountwashington.org/weather/cam/deck/deck-med.jpg",
            "http://www.mountwashington.org/weather/cam/north/north-med.jpg",
            "http://www.mountwashington.org/weather/cam/west/west-med.jpg",
            "http://www.mountwashington.org/weather/cam/ravines/ravines-med.jpg",
            "http://www.mountwashington.org/weather/cam/attitash/attitash-med.jpg"});
            this.listBoxFeedCollection.Location = new System.Drawing.Point(7, 9);
            this.listBoxFeedCollection.Name = "listBoxFeedCollection";
            this.listBoxFeedCollection.Size = new System.Drawing.Size(361, 95);
            this.listBoxFeedCollection.TabIndex = 0;
            // 
            // buttonAddFeed
            // 
            this.buttonAddFeed.Location = new System.Drawing.Point(7, 139);
            this.buttonAddFeed.Name = "buttonAddFeed";
            this.buttonAddFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonAddFeed.TabIndex = 2;
            this.buttonAddFeed.Text = "Add Feed";
            this.buttonAddFeed.UseVisualStyleBackColor = true;
            this.buttonAddFeed.Click += new System.EventHandler(this.buttonAddFeed_Click);
            // 
            // textBoxFeedNew
            // 
            this.textBoxFeedNew.Location = new System.Drawing.Point(88, 141);
            this.textBoxFeedNew.Name = "textBoxFeedNew";
            this.textBoxFeedNew.Size = new System.Drawing.Size(280, 20);
            this.textBoxFeedNew.TabIndex = 3;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(7, 110);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(361, 23);
            this.buttonRemoveSelected.TabIndex = 4;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageSynchSettings);
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(381, 200);
            this.tabControlSettings.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxFeedNew);
            this.tabPage1.Controls.Add(this.buttonRemoveSelected);
            this.tabPage1.Controls.Add(this.listBoxFeedCollection);
            this.tabPage1.Controls.Add(this.buttonAddFeed);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 174);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cameras and Feeds";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPageSynchSettings
            // 
            this.tabPageSynchSettings.Controls.Add(this.groupBoxSynchInterval);
            this.tabPageSynchSettings.Controls.Add(this.groupBox1);
            this.tabPageSynchSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSynchSettings.Name = "tabPageSynchSettings";
            this.tabPageSynchSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSynchSettings.Size = new System.Drawing.Size(373, 174);
            this.tabPageSynchSettings.TabIndex = 1;
            this.tabPageSynchSettings.Text = "Synchronization Settings";
            this.tabPageSynchSettings.UseVisualStyleBackColor = true;
            // 
            // groupBoxSynchInterval
            // 
            this.groupBoxSynchInterval.Controls.Add(this.trackBarInterval);
            this.groupBoxSynchInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSynchInterval.Location = new System.Drawing.Point(3, 118);
            this.groupBoxSynchInterval.Name = "groupBoxSynchInterval";
            this.groupBoxSynchInterval.Size = new System.Drawing.Size(367, 53);
            this.groupBoxSynchInterval.TabIndex = 1;
            this.groupBoxSynchInterval.TabStop = false;
            this.groupBoxSynchInterval.Text = "Synchronization Interval:";
            // 
            // trackBarInterval
            // 
            this.trackBarInterval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarInterval.LargeChange = 15;
            this.trackBarInterval.Location = new System.Drawing.Point(3, 16);
            this.trackBarInterval.Maximum = 120;
            this.trackBarInterval.Minimum = 15;
            this.trackBarInterval.Name = "trackBarInterval";
            this.trackBarInterval.Size = new System.Drawing.Size(361, 45);
            this.trackBarInterval.SmallChange = 15;
            this.trackBarInterval.TabIndex = 0;
            this.trackBarInterval.TickFrequency = 15;
            this.trackBarInterval.Value = 15;
            this.trackBarInterval.ValueChanged += new System.EventHandler(this.trackBarInterval_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxEnabled);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxCWD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Settings:";
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(9, 58);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(92, 17);
            this.checkBoxEnabled.TabIndex = 2;
            this.checkBoxEnabled.Text = "Feed Enabled";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Path:";
            // 
            // textBoxCWD
            // 
            this.textBoxCWD.Location = new System.Drawing.Point(81, 22);
            this.textBoxCWD.Name = "textBoxCWD";
            this.textBoxCWD.ReadOnly = true;
            this.textBoxCWD.Size = new System.Drawing.Size(275, 20);
            this.textBoxCWD.TabIndex = 0;
            this.textBoxCWD.Enter += new System.EventHandler(this.textBoxCWD_Enter);
            // 
            // buttonApply
            // 
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApply.Location = new System.Drawing.Point(0, 200);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(381, 35);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // folderBrowserDialogPWD
            // 
            this.folderBrowserDialogPWD.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save images in MyPictures";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 235);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.tabControlSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageSynchSettings.ResumeLayout(false);
            this.groupBoxSynchInterval.ResumeLayout(false);
            this.groupBoxSynchInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFeedCollection;
        private System.Windows.Forms.TextBox textBoxFeedNew;
        private System.Windows.Forms.Button buttonAddFeed;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageSynchSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxSynchInterval;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TrackBar trackBarInterval;
        private System.Windows.Forms.TextBox textBoxCWD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogPWD;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
        private System.Windows.Forms.Button button1;
    }
}