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
            this.ModeLabel = new System.Windows.Forms.Label();
            this.ModeCombo = new System.Windows.Forms.ComboBox();
            this.ModeOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.OptionsDisplayOrderCombobox = new System.Windows.Forms.ComboBox();
            this.OptionsDisplayOrderLabel = new System.Windows.Forms.Label();
            this.OptionsImageCountEntry = new System.Windows.Forms.NumericUpDown();
            this.OptionsImageCountLabel = new System.Windows.Forms.Label();
            this.OptionsCycleDelayEntry = new System.Windows.Forms.NumericUpDown();
            this.OptionsCycleDelayLabel = new System.Windows.Forms.Label();
            this.OptionsCycleCombobox = new System.Windows.Forms.ComboBox();
            this.OptionsCycleLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.ModeOptions = new System.Windows.Forms.Button();
            this.ModeInfoLabel = new System.Windows.Forms.Label();
            this.ModeCheckbox = new System.Windows.Forms.CheckBox();
            this.OptionsScalingLabel = new System.Windows.Forms.Label();
            this.OptionsScalingCombobox = new System.Windows.Forms.ComboBox();
            this.ModeOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsImageCountEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsCycleDelayEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.Location = new System.Drawing.Point(13, 15);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(41, 13);
            this.ModeLabel.TabIndex = 0;
            this.ModeLabel.Text = "Source";
            // 
            // ModeCombo
            // 
            this.ModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeCombo.FormattingEnabled = true;
            this.ModeCombo.Location = new System.Drawing.Point(53, 12);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.Size = new System.Drawing.Size(121, 21);
            this.ModeCombo.TabIndex = 1;
            this.ModeCombo.SelectedIndexChanged += new System.EventHandler(this.ModeCombo_SelectedIndexChanged);
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
            this.ModeOptionsGroupBox.Location = new System.Drawing.Point(16, 39);
            this.ModeOptionsGroupBox.Name = "ModeOptionsGroupBox";
            this.ModeOptionsGroupBox.Size = new System.Drawing.Size(346, 110);
            this.ModeOptionsGroupBox.TabIndex = 2;
            this.ModeOptionsGroupBox.TabStop = false;
            this.ModeOptionsGroupBox.Text = "Options";
            // 
            // OptionsDisplayOrderCombobox
            // 
            this.OptionsDisplayOrderCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionsDisplayOrderCombobox.FormattingEnabled = true;
            this.OptionsDisplayOrderCombobox.Location = new System.Drawing.Point(246, 22);
            this.OptionsDisplayOrderCombobox.Name = "OptionsDisplayOrderCombobox";
            this.OptionsDisplayOrderCombobox.Size = new System.Drawing.Size(83, 21);
            this.OptionsDisplayOrderCombobox.TabIndex = 7;
            // 
            // OptionsDisplayOrderLabel
            // 
            this.OptionsDisplayOrderLabel.AutoSize = true;
            this.OptionsDisplayOrderLabel.Location = new System.Drawing.Point(170, 25);
            this.OptionsDisplayOrderLabel.Name = "OptionsDisplayOrderLabel";
            this.OptionsDisplayOrderLabel.Size = new System.Drawing.Size(70, 13);
            this.OptionsDisplayOrderLabel.TabIndex = 6;
            this.OptionsDisplayOrderLabel.Text = "Display Order";
            // 
            // OptionsImageCountEntry
            // 
            this.OptionsImageCountEntry.Location = new System.Drawing.Point(246, 49);
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
            this.OptionsImageCountLabel.Location = new System.Drawing.Point(170, 52);
            this.OptionsImageCountLabel.Name = "OptionsImageCountLabel";
            this.OptionsImageCountLabel.Size = new System.Drawing.Size(72, 13);
            this.OptionsImageCountLabel.TabIndex = 4;
            this.OptionsImageCountLabel.Text = "Images/Cycle";
            // 
            // OptionsCycleDelayEntry
            // 
            this.OptionsCycleDelayEntry.Location = new System.Drawing.Point(74, 50);
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
            this.OptionsCycleDelayLabel.Location = new System.Drawing.Point(6, 52);
            this.OptionsCycleDelayLabel.Name = "OptionsCycleDelayLabel";
            this.OptionsCycleDelayLabel.Size = new System.Drawing.Size(34, 13);
            this.OptionsCycleDelayLabel.TabIndex = 2;
            this.OptionsCycleDelayLabel.Text = "Delay";
            // 
            // OptionsCycleCombobox
            // 
            this.OptionsCycleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionsCycleCombobox.FormattingEnabled = true;
            this.OptionsCycleCombobox.Location = new System.Drawing.Point(75, 23);
            this.OptionsCycleCombobox.Name = "OptionsCycleCombobox";
            this.OptionsCycleCombobox.Size = new System.Drawing.Size(83, 21);
            this.OptionsCycleCombobox.TabIndex = 1;
            // 
            // OptionsCycleLabel
            // 
            this.OptionsCycleLabel.AutoSize = true;
            this.OptionsCycleLabel.Location = new System.Drawing.Point(6, 26);
            this.OptionsCycleLabel.Name = "OptionsCycleLabel";
            this.OptionsCycleLabel.Size = new System.Drawing.Size(63, 13);
            this.OptionsCycleLabel.TabIndex = 0;
            this.OptionsCycleLabel.Text = "Cycle Mode";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(320, 155);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(239, 155);
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
            this.ModeOptions.Location = new System.Drawing.Point(180, 10);
            this.ModeOptions.Name = "ModeOptions";
            this.ModeOptions.Size = new System.Drawing.Size(75, 23);
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
            // ModeCheckbox
            // 
            this.ModeCheckbox.AutoSize = true;
            this.ModeCheckbox.Location = new System.Drawing.Point(264, 14);
            this.ModeCheckbox.Name = "ModeCheckbox";
            this.ModeCheckbox.Size = new System.Drawing.Size(98, 17);
            this.ModeCheckbox.TabIndex = 4;
            this.ModeCheckbox.Text = "Sub Directories";
            this.ModeCheckbox.UseVisualStyleBackColor = true;
            this.ModeCheckbox.Visible = false;
            // 
            // OptionsScalingLabel
            // 
            this.OptionsScalingLabel.AutoSize = true;
            this.OptionsScalingLabel.Location = new System.Drawing.Point(6, 79);
            this.OptionsScalingLabel.Name = "OptionsScalingLabel";
            this.OptionsScalingLabel.Size = new System.Drawing.Size(42, 13);
            this.OptionsScalingLabel.TabIndex = 7;
            this.OptionsScalingLabel.Text = "Scaling";
            // 
            // OptionsScalingCombobox
            // 
            this.OptionsScalingCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OptionsScalingCombobox.FormattingEnabled = true;
            this.OptionsScalingCombobox.Location = new System.Drawing.Point(75, 76);
            this.OptionsScalingCombobox.Name = "OptionsScalingCombobox";
            this.OptionsScalingCombobox.Size = new System.Drawing.Size(83, 21);
            this.OptionsScalingCombobox.TabIndex = 8;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 182);
            this.Controls.Add(this.ModeCheckbox);
            this.Controls.Add(this.ModeInfoLabel);
            this.Controls.Add(this.ModeOptions);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ModeOptionsGroupBox);
            this.Controls.Add(this.ModeCombo);
            this.Controls.Add(this.ModeLabel);
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

        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.ComboBox ModeCombo;
        private System.Windows.Forms.GroupBox ModeOptionsGroupBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button ModeOptions;
        private System.Windows.Forms.Label OptionsCycleLabel;
        private System.Windows.Forms.NumericUpDown OptionsCycleDelayEntry;
        private System.Windows.Forms.Label OptionsCycleDelayLabel;
        private System.Windows.Forms.ComboBox OptionsCycleCombobox;
        private System.Windows.Forms.Label ModeInfoLabel;
        private System.Windows.Forms.CheckBox ModeCheckbox;
        private System.Windows.Forms.NumericUpDown OptionsImageCountEntry;
        private System.Windows.Forms.Label OptionsImageCountLabel;
        private System.Windows.Forms.ComboBox OptionsDisplayOrderCombobox;
        private System.Windows.Forms.Label OptionsDisplayOrderLabel;
        private System.Windows.Forms.Label OptionsScalingLabel;
        private System.Windows.Forms.ComboBox OptionsScalingCombobox;
    }
}