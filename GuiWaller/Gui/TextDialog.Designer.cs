namespace GuiWaller.Gui
{
    partial class TextDialog
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
            this.TextDialogCaption = new System.Windows.Forms.Label();
            this.TextDialogEntry = new System.Windows.Forms.TextBox();
            this.TextDialogOk = new System.Windows.Forms.Button();
            this.TextDialogCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextDialogCaption
            // 
            this.TextDialogCaption.AutoSize = true;
            this.TextDialogCaption.Location = new System.Drawing.Point(12, 23);
            this.TextDialogCaption.Name = "TextDialogCaption";
            this.TextDialogCaption.Size = new System.Drawing.Size(55, 13);
            this.TextDialogCaption.TabIndex = 0;
            this.TextDialogCaption.Text = "Enter text:";
            // 
            // TextDialogEntry
            // 
            this.TextDialogEntry.Location = new System.Drawing.Point(12, 39);
            this.TextDialogEntry.Name = "TextDialogEntry";
            this.TextDialogEntry.Size = new System.Drawing.Size(388, 20);
            this.TextDialogEntry.TabIndex = 1;
            // 
            // TextDialogOk
            // 
            this.TextDialogOk.Location = new System.Drawing.Point(233, 87);
            this.TextDialogOk.Name = "TextDialogOk";
            this.TextDialogOk.Size = new System.Drawing.Size(75, 23);
            this.TextDialogOk.TabIndex = 2;
            this.TextDialogOk.Text = "Ok";
            this.TextDialogOk.UseVisualStyleBackColor = true;
            this.TextDialogOk.Click += new System.EventHandler(this.TextDialogOk_Click);
            // 
            // TextDialogCancel
            // 
            this.TextDialogCancel.Location = new System.Drawing.Point(325, 87);
            this.TextDialogCancel.Name = "TextDialogCancel";
            this.TextDialogCancel.Size = new System.Drawing.Size(75, 23);
            this.TextDialogCancel.TabIndex = 3;
            this.TextDialogCancel.Text = "Cancel";
            this.TextDialogCancel.UseVisualStyleBackColor = true;
            // 
            // TextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 122);
            this.Controls.Add(this.TextDialogCancel);
            this.Controls.Add(this.TextDialogOk);
            this.Controls.Add(this.TextDialogEntry);
            this.Controls.Add(this.TextDialogCaption);
            this.Name = "TextDialog";
            this.Text = "Text Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextDialogCaption;
        private System.Windows.Forms.TextBox TextDialogEntry;
        private System.Windows.Forms.Button TextDialogOk;
        private System.Windows.Forms.Button TextDialogCancel;
    }
}