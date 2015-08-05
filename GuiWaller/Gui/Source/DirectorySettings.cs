using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWaller.Gui.Source
{
    public partial class DirectorySettings : Form
    {
        public class DirectorySettingsClosedOptions : EventArgs
        {
            public string path;
            public int order;
            public bool useSubfolders;

            public DirectorySettingsClosedOptions(string newPath, int newOrder, bool newUseSubfolders)
            {
                path = newPath;
                order = newOrder;
                useSubfolders = newUseSubfolders;
            }

        }

        private EventHandler onOkHandler;
        public DirectorySettings(EventHandler onOkHandle,DirectorySettingsClosedOptions options)
        {
            InitializeComponent();
            onOkHandler = onOkHandle;
            DirectoryOrder.DataSource = Enum.GetValues(typeof(Settings.CycleMode));

            DirectoryOrder.SelectedIndex = DirectoryOrder.Items.IndexOf((Settings.CycleMode)options.order);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onOk(object sender, EventArgs e)
        {
            EventArgs args = new DirectorySettingsClosedOptions(
                DirectoryPath.Text,
                DirectoryOrder.SelectedIndex,
                DirectorySubfolders.Checked);
            onOkHandler(sender, args);
        }

        private void DirectoryBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.ShowDialog();
            DirectoryPath.Text = diag.SelectedPath;
        }
    }
}
