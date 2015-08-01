namespace GuiWaller.Gui.Source
{
    partial class DirectorySettings
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
            this.DirectoryLabel = new System.Windows.Forms.Label();
            this.DirectoryPath = new System.Windows.Forms.TextBox();
            this.DirectoryBrowse = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DirectoryOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DirectorySubfolders = new System.Windows.Forms.CheckBox();
            this.DirectoryOk = new System.Windows.Forms.Button();
            this.DirectoryCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DirectoryLabel
            // 
            this.DirectoryLabel.AutoSize = true;
            this.DirectoryLabel.Location = new System.Drawing.Point(12, 15);
            this.DirectoryLabel.Name = "DirectoryLabel";
            this.DirectoryLabel.Size = new System.Drawing.Size(49, 13);
            this.DirectoryLabel.TabIndex = 0;
            this.DirectoryLabel.Text = "Directory";
            // 
            // DirectoryPath
            // 
            this.DirectoryPath.Location = new System.Drawing.Point(67, 12);
            this.DirectoryPath.Name = "DirectoryPath";
            this.DirectoryPath.Size = new System.Drawing.Size(139, 20);
            this.DirectoryPath.TabIndex = 1;
            // 
            // DirectoryBrowse
            // 
            this.DirectoryBrowse.Location = new System.Drawing.Point(212, 10);
            this.DirectoryBrowse.Name = "DirectoryBrowse";
            this.DirectoryBrowse.Size = new System.Drawing.Size(75, 23);
            this.DirectoryBrowse.TabIndex = 2;
            this.DirectoryBrowse.Text = "Browse";
            this.DirectoryBrowse.UseVisualStyleBackColor = true;
            this.DirectoryBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DirectoryOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DirectorySubfolders);
            this.groupBox1.Location = new System.Drawing.Point(15, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // DirectoryOrder
            // 
            this.DirectoryOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DirectoryOrder.FormattingEnabled = true;
            this.DirectoryOrder.Location = new System.Drawing.Point(45, 19);
            this.DirectoryOrder.Name = "DirectoryOrder";
            this.DirectoryOrder.Size = new System.Drawing.Size(121, 21);
            this.DirectoryOrder.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DirectorySubfolders
            // 
            this.DirectorySubfolders.AutoSize = true;
            this.DirectorySubfolders.Location = new System.Drawing.Point(174, 21);
            this.DirectorySubfolders.Name = "DirectorySubfolders";
            this.DirectorySubfolders.Size = new System.Drawing.Size(98, 17);
            this.DirectorySubfolders.TabIndex = 0;
            this.DirectorySubfolders.Text = "Use Subfolders";
            this.DirectorySubfolders.UseVisualStyleBackColor = true;
            // 
            // DirectoryOk
            // 
            this.DirectoryOk.Location = new System.Drawing.Point(141, 97);
            this.DirectoryOk.Name = "DirectoryOk";
            this.DirectoryOk.Size = new System.Drawing.Size(75, 23);
            this.DirectoryOk.TabIndex = 4;
            this.DirectoryOk.Text = "Ok";
            this.DirectoryOk.UseVisualStyleBackColor = true;
            this.DirectoryOk.Click += new System.EventHandler(this.onOk);
            // 
            // DirectoryCancel
            // 
            this.DirectoryCancel.Location = new System.Drawing.Point(222, 97);
            this.DirectoryCancel.Name = "DirectoryCancel";
            this.DirectoryCancel.Size = new System.Drawing.Size(75, 23);
            this.DirectoryCancel.TabIndex = 5;
            this.DirectoryCancel.Text = "Cancel";
            this.DirectoryCancel.UseVisualStyleBackColor = true;
            // 
            // DirectorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 125);
            this.Controls.Add(this.DirectoryCancel);
            this.Controls.Add(this.DirectoryOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DirectoryBrowse);
            this.Controls.Add(this.DirectoryPath);
            this.Controls.Add(this.DirectoryLabel);
            this.Name = "DirectorySettings";
            this.Text = "DirectorySettings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DirectoryLabel;
        private System.Windows.Forms.TextBox DirectoryPath;
        private System.Windows.Forms.Button DirectoryBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox DirectorySubfolders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DirectoryOrder;
        private System.Windows.Forms.Button DirectoryOk;
        private System.Windows.Forms.Button DirectoryCancel;
    }
}