
namespace Directory_Cleaner
{
    partial class Main
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
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelectFolder = new System.Windows.Forms.Label();
            this.lblFolderSelection = new System.Windows.Forms.Label();
            this.lblLastAccessed = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.cld = new System.Windows.Forms.MonthCalendar();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Palatino Linotype", 28F);
            this.lblTitle.Location = new System.Drawing.Point(122, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(320, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Directory Cleaner";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSelectFolder
            // 
            this.lblSelectFolder.AutoSize = true;
            this.lblSelectFolder.Font = new System.Drawing.Font("Sitka Banner", 14F);
            this.lblSelectFolder.Location = new System.Drawing.Point(7, 84);
            this.lblSelectFolder.Name = "lblSelectFolder";
            this.lblSelectFolder.Size = new System.Drawing.Size(215, 28);
            this.lblSelectFolder.TabIndex = 0;
            this.lblSelectFolder.Text = "Select a folder to be cleaned:";
            // 
            // lblFolderSelection
            // 
            this.lblFolderSelection.Location = new System.Drawing.Point(9, 121);
            this.lblFolderSelection.Name = "lblFolderSelection";
            this.lblFolderSelection.Size = new System.Drawing.Size(208, 86);
            this.lblFolderSelection.TabIndex = 0;
            this.lblFolderSelection.Text = "No folder selected";
            // 
            // lblLastAccessed
            // 
            this.lblLastAccessed.AutoSize = true;
            this.lblLastAccessed.Font = new System.Drawing.Font("Sitka Banner", 14F);
            this.lblLastAccessed.Location = new System.Drawing.Point(228, 84);
            this.lblLastAccessed.Name = "lblLastAccessed";
            this.lblLastAccessed.Size = new System.Drawing.Size(277, 28);
            this.lblLastAccessed.TabIndex = 0;
            this.lblLastAccessed.Text = "Remove all files last modified before:";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 210);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(93, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // cld
            // 
            this.cld.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.cld.Location = new System.Drawing.Point(229, 121);
            this.cld.MaxSelectionCount = 1;
            this.cld.Name = "cld";
            this.cld.TabIndex = 1;
            this.cld.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cld_DateChanged);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(468, 262);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(93, 23);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 262);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(93, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 297);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cld);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lblLastAccessed);
            this.Controls.Add(this.lblFolderSelection);
            this.Controls.Add(this.lblSelectFolder);
            this.Controls.Add(this.lblTitle);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Cleaner";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelectFolder;
        private System.Windows.Forms.Label lblFolderSelection;
        private System.Windows.Forms.Label lblLastAccessed;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.MonthCalendar cld;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnQuit;
    }
}

