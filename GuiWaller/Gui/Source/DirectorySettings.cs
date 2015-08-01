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
            public readonly string path;
            public readonly string order;
            public readonly bool useSubfolders;

            public DirectorySettingsClosedOptions(string newPath, string newOrder, bool newUseSubfolders)
            {
                path = newPath;
                order = newOrder;
                useSubfolders = newUseSubfolders;
            }

        }

        private EventHandler onOkHandler;
        public DirectorySettings(EventHandler onOkHandle)
        {
            InitializeComponent();
            onOkHandler = onOkHandle;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onOk(object sender, EventArgs e)
        {
            EventArgs args = new DirectorySettingsClosedOptions(
                DirectoryPath.Text,
                ""+DirectoryOrder.SelectedValue,
                DirectorySubfolders.Checked);
            onOkHandler(sender, args);
        }
    }
}
