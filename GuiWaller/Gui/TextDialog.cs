using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiWaller.Gui
{
    public partial class TextDialog : Form
    {
        public string EntryText
        {
            get { return TextDialogEntry.Text; }
            set { TextDialogEntry.Text = value; }
        }
        public TextDialog()
        {
            InitializeComponent();
            TextDialogEntry.Focus();
        }

        private void TextDialogOk_Click(object sender, EventArgs e)
        {

        }
    }
}
