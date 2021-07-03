namespace BloodAndBaconSaveEditor.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.selectFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.unlockedWeaponsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 346);
            this.selectFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(117, 27);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select save file";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Enabled = false;
            this.saveFileButton.Location = new System.Drawing.Point(135, 346);
            this.saveFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(88, 27);
            this.saveFileButton.TabIndex = 1;
            this.saveFileButton.Text = "Save as...";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // unlockedWeaponsButton
            // 
            this.unlockedWeaponsButton.Enabled = false;
            this.unlockedWeaponsButton.Location = new System.Drawing.Point(12, 12);
            this.unlockedWeaponsButton.Name = "unlockedWeaponsButton";
            this.unlockedWeaponsButton.Size = new System.Drawing.Size(117, 23);
            this.unlockedWeaponsButton.TabIndex = 2;
            this.unlockedWeaponsButton.Text = "Unlocked weapons";
            this.unlockedWeaponsButton.UseVisualStyleBackColor = true;
            this.unlockedWeaponsButton.Click += new System.EventHandler(this.UnlockedWeaponsButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 387);
            this.Controls.Add(this.unlockedWeaponsButton);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.selectFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "Blood And Bacon Save Editor";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Button saveFileButton;

        #endregion

        private System.Windows.Forms.Button unlockedWeaponsButton;
    }
}