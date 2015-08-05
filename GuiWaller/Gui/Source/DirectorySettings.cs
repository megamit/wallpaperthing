using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWaller.Gui.Source
{
    public partial class DirectorySettings : Form
    {
        public string Path
        {
            get { return DirectoryPath.Text; }
            set { DirectoryPath.Text = value; }
        }
        public Settings.CycleMode Order
        {
            get { return (Settings.CycleMode)DirectoryOrder.SelectedIndex; }
            set { DirectoryOrder.SelectedIndex = (int)value; }
        }
        public bool UseSubfolders
        {
            get { return DirectorySubfolders.Checked;}
            set { DirectorySubfolders.Checked = value; }
        }
        public int ExitStatus { private set; get; }
        public DirectorySettings()
        {
            ExitStatus = -1;
            InitializeComponent();
            DirectoryOrder.DataSource = Enum.GetValues(typeof(Settings.CycleMode));
        }
        private void onOk(object sender, EventArgs e)
        {
            if (!Directory.Exists(DirectoryPath.Text))
            {
                MessageBox.Show("Directory is Invalid");
                return;
            }
            ExitStatus = 0;
            this.Close();
        }

        private void DirectoryBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.ShowDialog();
            DirectoryPath.Text = diag.SelectedPath;
        }

        private void DirectoryPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirectoryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
