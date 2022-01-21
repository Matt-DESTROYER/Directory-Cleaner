using System;
using System.IO;
using System.Windows.Forms;

namespace Directory_Cleaner
{
    public partial class Main : Form
    {
        DateTime date = new DateTime(1, 1, 1);

        private void CleanDirectory(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            foreach (string file in files)
            {
                if (date.CompareTo(Directory.GetLastWriteTime(file)) > 0)
                {
                    File.Delete(file);
                }
            }
            if (Directory.GetFiles(directory).Length == 0)
            {
                Directory.Delete(directory);
            }
            string[] folders = Directory.GetDirectories(directory);
            foreach (string folder in folders)
            {
                CleanDirectory(folder);
            }
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                lblFolderSelection.Text = fbd.SelectedPath;
            }
        }

        private void cld_DateChanged(object sender, DateRangeEventArgs e)
        {
            date = cld.SelectionEnd;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(fbd.SelectedPath))
            {
                try
                {
                    CleanDirectory(fbd.SelectedPath);
                    MessageBox.Show(fbd.SelectedPath + " was successfully cleaned!");
                }
                catch (FileNotFoundException err)
                {
                    MessageBox.Show("An unexpected error occurred: " + err.Message);
                }
                catch (IOException err)
                {
                    MessageBox.Show("An unexpected error occurred: " + err.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a folder before attempting to run the directory cleaner.");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}