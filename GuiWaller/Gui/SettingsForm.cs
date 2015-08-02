using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Windows.Native;

namespace GuiWaller.Gui
{
    public partial class SettingsForm : Form
    {
        private string ModeDirectoryPath;
        public SettingsForm()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            OptionsCycleCombobox.DataSource = Enum.GetValues(typeof(Settings.CycleMode));
            OptionsDisplayOrderCombobox.DataSource = Enum.GetValues(typeof(Settings.DisplayCycleMode));
            OptionsScalingCombobox.DataSource = Enum.GetValues(typeof(GuiWaller.Desktop.ScaleMode));
            OptionsImageCountEntry.Maximum = (new EnumDisplayMonitorsWrapper()).GetDisplays().Count;
            //WARNING databind will cause index change handle to be called and its value set to 0
            //Always set indexes after databinds to avoid headache

            ModeDirectoryPath = Properties.Settings.Default.ModeDirectoryPath;
            
            OptionsCycleCombobox.SelectedIndex = OptionsCycleCombobox.Items.IndexOf((Settings.CycleMode)Properties.Settings.Default.CycleMode);
            OptionsCycleDelayEntry.Value = Properties.Settings.Default.CycleDelay;
            OptionsImageCountEntry.Value = (decimal)Properties.Settings.Default.ImagesPerCycle > OptionsImageCountEntry.Maximum ?
                OptionsImageCountEntry.Maximum :(decimal)Properties.Settings.Default.ImagesPerCycle;
            OptionsDisplayOrderCombobox.SelectedIndex = OptionsDisplayOrderCombobox.Items.IndexOf((Settings.DisplayCycleMode)Properties.Settings.Default.DisplayOrder);
            OptionsScalingCombobox.SelectedIndex = OptionsScalingCombobox.Items.IndexOf((Desktop.ScaleMode)Properties.Settings.Default.ScaleMode);
            

            
   
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModeDirectoryPath = ModeDirectoryPath;
            Properties.Settings.Default.CycleMode = (int)OptionsCycleCombobox.SelectedItem;
            Properties.Settings.Default.CycleDelay = OptionsCycleDelayEntry.Value < 1 ? 1 : OptionsCycleDelayEntry.Value;
            Properties.Settings.Default.ImagesPerCycle = (int)OptionsImageCountEntry.Value;
            Properties.Settings.Default.DisplayOrder = (int)OptionsDisplayOrderCombobox.SelectedItem;
            Properties.Settings.Default.ScaleMode = (int)OptionsScalingCombobox.SelectedItem;
            //close
            Properties.Settings.Default.Save();

            this.Hide();
            this.Close();
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void SourceListAddButton_Click(object sender, EventArgs e)
        {

        }

        private void SourceListRemoveButton_Click(object sender, EventArgs e)
        {

        }



    }
}
