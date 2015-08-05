namespace GuiWaller.Gui
{
    partial class SettingsForm
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
            this.ModeOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionsScalingLabel = new System.Windows.Forms.Label();
            this.OptionsScalingCombobox = new System.Windows.Forms.ComboBox();
            this.OptionsDisplayOrderCombobox = new System.Windows.Forms.ComboBox();
            this.OptionsDisplayOrderLabel = new System.Windows.Forms.Label();
            this.OptionsImageCountEntry = new System.Windows.Forms.NumericUpDown();
            this.OptionsImageCountLabel = new System.Windows.Forms.Label();
            this.OptionsCycleDelayEntry = new System.Windows.Forms.NumericUpDown();
            this.OptionsCycleDelayLabel = new System.Windows.Forms.Label();
            this.OptionsCycleCombobox = new System.Windows.Forms.ComboBox();
            this.OptionsCycleLabel = new System.Windows.Forms.Label();
            this.CnclButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ModeOptions = new System.Windows.Forms.Button();
            this.ModeInfoLabel = new System.Windows.Forms.Label();
            this.SourceListView = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sourceType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SourceListAddButton = new System.Windows.Forms.Button();
            this.SourceListRemoveButton = new System.Windows.Forms.Button();
            this.ModeOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsImageCountEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsCycleDelayEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeOptionsGroupBox
            // 
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsScalingLabel);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsScalingCombobox);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsDisplayOrderCombobox);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsDisplayOrderLabel);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsImageCountEntry);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsImageCountLabel);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsCycleDelayEntry);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsCycleDelayLabel);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsCycleCombobox);
            this.ModeOptionsGroupBox.Controls.Add(this.OptionsCycleLabel);
            this.ModeOptionsGroupBox.Location = new System.Drawing.Point(299, 70);
            this.ModeOptionsGroupBox.Name = "ModeOptionsGroupBox";
            this.ModeOptionsGroupBox.Size = new System.Drawing.Size(182, 172);
            this.ModeOptionsGroupBox.TabIndex = 2;
            this.ModeOptionsGroupBox.TabStop = false;
            this.ModeOptionsGroupBox.Text = "Options";
            // 
            // OptionsScalingLabel
            // 
            this.OptionsScalingLabel.AutoSize = true;
            this.OptionsScalingLabel.Location = new System.Drawing.Point(36, 132);
            this.OptionsScalingLabel.Name = "OptionsScalingLabel";
            this.OptionsScalingLabel.Size = new System.Drawing.Size(42, 13);
            this.OptionsScalingLabel.TabIndex = 7;
            this.OptionsScalingLabel.Text = "Scaling";
            // 
            // OptionsScalingCombobox
            // 
            this.OptionsScalingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionsScalingCombobox.FormattingEnabled = true;
            this.OptionsScalingCombobox.Location = new System.Drawing.Point(84, 132);
            this.OptionsScalingCombobox.Name = "OptionsScalingCombobox";
            this.OptionsScalingCombobox.Size = new System.Drawing.Size(83, 21);
            this.OptionsScalingCombobox.TabIndex = 8;
            // 
            // OptionsDisplayOrderCombobox
            // 
            this.OptionsDisplayOrderCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionsDisplayOrderCombobox.FormattingEnabled = true;
            this.OptionsDisplayOrderCombobox.Location = new System.Drawing.Point(84, 25);
            this.OptionsDisplayOrderCombobox.Name = "OptionsDisplayOrderCombobox";
            this.OptionsDisplayOrderCombobox.Size = new System.Drawing.Size(83, 21);
            this.OptionsDisplayOrderCombobox.TabIndex = 7;
            // 
            // OptionsDisplayOrderLabel
            // 
            this.OptionsDisplayOrderLabel.AutoSize = true;
            this.OptionsDisplayOrderLabel.Location = new System.Drawing.Point(8, 28);
            this.OptionsDisplayOrderLabel.Name = "OptionsDisplayOrderLabel";
            this.OptionsDisplayOrderLabel.Size = new System.Drawing.Size(70, 13);
            this.OptionsDisplayOrderLabel.TabIndex = 6;
            this.OptionsDisplayOrderLabel.Text = "Display Order";
            // 
            // OptionsImageCountEntry
            // 
            this.OptionsImageCountEntry.Location = new System.Drawing.Point(84, 52);
            this.OptionsImageCountEntry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OptionsImageCountEntry.Name = "OptionsImageCountEntry";
            this.OptionsImageCountEntry.Size = new System.Drawing.Size(83, 20);
            this.OptionsImageCountEntry.TabIndex = 5;
            this.OptionsImageCountEntry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OptionsImageCountLabel
            // 
            this.OptionsImageCountLabel.AutoSize = true;
            this.OptionsImageCountLabel.Location = new System.Drawing.Point(6, 54);
            this.OptionsImageCountLabel.Name = "OptionsImageCountLabel";
            this.OptionsImageCountLabel.Size = new System.Drawing.Size(72, 13);
            this.OptionsImageCountLabel.TabIndex = 4;
            this.OptionsImageCountLabel.Text = "Images/Cycle";
            // 
            // OptionsCycleDelayEntry
            // 
            this.OptionsCycleDelayEntry.Location = new System.Drawing.Point(84, 106);
            this.OptionsCycleDelayEntry.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OptionsCycleDelayEntry.Name = "OptionsCycleDelayEntry";
            this.OptionsCycleDelayEntry.Size = new System.Drawing.Size(84, 20);
            this.OptionsCycleDelayEntry.TabIndex = 3;
            this.OptionsCycleDelayEntry.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OptionsCycleDelayLabel
            // 
            this.OptionsCycleDelayLabel.AutoSize = true;
            this.OptionsCycleDelayLabel.Location = new System.Drawing.Point(44, 108);
            this.OptionsCycleDelayLabel.Name = "OptionsCycleDelayLabel";
            this.OptionsCycleDelayLabel.Size = new System.Drawing.Size(34, 13);
            this.OptionsCycleDelayLabel.TabIndex = 2;
            this.OptionsCycleDelayLabel.Text = "Delay";
            // 
            // OptionsCycleCombobox
            // 
            this.OptionsCycleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionsCycleCombobox.FormattingEnabled = true;
            this.OptionsCycleCombobox.Location = new System.Drawing.Point(84, 76);
            this.OptionsCycleCombobox.Name = "OptionsCycleCombobox";
            this.OptionsCycleCombobox.Size = new System.Drawing.Size(83, 21);
            this.OptionsCycleCombobox.TabIndex = 1;
            // 
            // OptionsCycleLabel
            // 
            this.OptionsCycleLabel.AutoSize = true;
            this.OptionsCycleLabel.Location = new System.Drawing.Point(15, 79);
            this.OptionsCycleLabel.Name = "OptionsCycleLabel";
            this.OptionsCycleLabel.Size = new System.Drawing.Size(63, 13);
            this.OptionsCycleLabel.TabIndex = 0;
            this.OptionsCycleLabel.Text = "Cycle Mode";
            // 
            // CnclButton
            // 
            this.CnclButton.Location = new System.Drawing.Point(406, 248);
            this.CnclButton.Name = "CnclButton";
            this.CnclButton.Size = new System.Drawing.Size(75, 23);
            this.CnclButton.TabIndex = 3;
            this.CnclButton.Text = "Cancel";
            this.CnclButton.UseVisualStyleBackColor = true;
            this.CnclButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(299, 248);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // ModeOptions
            // 
            this.ModeOptions.Enabled = false;
            this.ModeOptions.Location = new System.Drawing.Point(299, 41);
            this.ModeOptions.Name = "ModeOptions";
            this.ModeOptions.Size = new System.Drawing.Size(93, 23);
            this.ModeOptions.TabIndex = 5;
            this.ModeOptions.Text = "Options";
            this.ModeOptions.UseVisualStyleBackColor = true;
            // 
            // ModeInfoLabel
            // 
            this.ModeInfoLabel.AutoSize = true;
            this.ModeInfoLabel.Location = new System.Drawing.Point(13, 255);
            this.ModeInfoLabel.Name = "ModeInfoLabel";
            this.ModeInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.ModeInfoLabel.TabIndex = 6;
            // 
            // SourceListView
            // 
            this.SourceListView.CheckBoxes = true;
            this.SourceListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.sourceType});
            this.SourceListView.FullRowSelect = true;
            this.SourceListView.GridLines = true;
            this.SourceListView.LabelWrap = false;
            this.SourceListView.Location = new System.Drawing.Point(16, 12);
            this.SourceListView.Name = "SourceListView";
            this.SourceListView.Size = new System.Drawing.Size(277, 254);
            this.SourceListView.TabIndex = 7;
            this.SourceListView.UseCompatibleStateImageBehavior = false;
            this.SourceListView.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 189;
            // 
            // sourceType
            // 
            this.sourceType.Text = "Source Type";
            this.sourceType.Width = 84;
            // 
            // SourceListAddButton
            // 
            this.SourceListAddButton.Location = new System.Drawing.Point(299, 12);
            this.SourceListAddButton.Name = "SourceListAddButton";
            this.SourceListAddButton.Size = new System.Drawing.Size(93, 23);
            this.SourceListAddButton.TabIndex = 8;
            this.SourceListAddButton.Text = "Add";
            this.SourceListAddButton.UseVisualStyleBackColor = true;
            this.SourceListAddButton.Click += new System.EventHandler(this.SourceListAddButton_Click);
            // 
            // SourceListRemoveButton
            // 
            this.SourceListRemoveButton.Location = new System.Drawing.Point(398, 12);
            this.SourceListRemoveButton.Name = "SourceListRemoveButton";
            this.SourceListRemoveButton.Size = new System.Drawing.Size(90, 23);
            this.SourceListRemoveButton.TabIndex = 9;
            this.SourceListRemoveButton.Text = "Remove";
            this.SourceListRemoveButton.UseVisualStyleBackColor = true;
            this.SourceListRemoveButton.Click += new System.EventHandler(this.SourceListRemoveButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 278);
            this.Controls.Add(this.SourceListRemoveButton);
            this.Controls.Add(this.SourceListAddButton);
            this.Controls.Add(this.SourceListView);
            this.Controls.Add(this.ModeInfoLabel);
            this.Controls.Add(this.ModeOptions);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CnclButton);
            this.Controls.Add(this.ModeOptionsGroupBox);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ModeOptionsGroupBox.ResumeLayout(false);
            this.ModeOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsImageCountEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsCycleDelayEntry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ModeOptionsGroupBox;
        private System.Windows.Forms.Button CnclButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ModeOptions;
        private System.Windows.Forms.Label OptionsCycleLabel;
        private System.Windows.Forms.NumericUpDown OptionsCycleDelayEntry;
        private System.Windows.Forms.Label OptionsCycleDelayLabel;
        private System.Windows.Forms.ComboBox OptionsCycleCombobox;
        private System.Windows.Forms.Label ModeInfoLabel;
        private System.Windows.Forms.NumericUpDown OptionsImageCountEntry;
        private System.Windows.Forms.Label OptionsImageCountLabel;
        private System.Windows.Forms.ComboBox OptionsDisplayOrderCombobox;
        private System.Windows.Forms.Label OptionsDisplayOrderLabel;
        private System.Windows.Forms.Label OptionsScalingLabel;
        private System.Windows.Forms.ComboBox OptionsScalingCombobox;
        private System.Windows.Forms.ListView SourceListView;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader sourceType;
        private System.Windows.Forms.Button SourceListAddButton;
        private System.Windows.Forms.Button SourceListRemoveButton;
    }
}