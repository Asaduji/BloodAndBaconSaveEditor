
namespace BloodAndBaconSaveEditor.Forms
{
    partial class FlashlightsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlashlightsForm));
            this.Flashlight1CheckBox = new System.Windows.Forms.CheckBox();
            this.Flashlight2CheckBox = new System.Windows.Forms.CheckBox();
            this.Flashlight3CheckBox = new System.Windows.Forms.CheckBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UnlockAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flashlight1CheckBox
            // 
            this.Flashlight1CheckBox.Location = new System.Drawing.Point(13, 13);
            this.Flashlight1CheckBox.Name = "Flashlight1CheckBox";
            this.Flashlight1CheckBox.Size = new System.Drawing.Size(145, 28);
            this.Flashlight1CheckBox.TabIndex = 0;
            this.Flashlight1CheckBox.Text = "Standard flashlight";
            this.Flashlight1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Flashlight2CheckBox
            // 
            this.Flashlight2CheckBox.Location = new System.Drawing.Point(12, 47);
            this.Flashlight2CheckBox.Name = "Flashlight2CheckBox";
            this.Flashlight2CheckBox.Size = new System.Drawing.Size(146, 28);
            this.Flashlight2CheckBox.TabIndex = 1;
            this.Flashlight2CheckBox.Text = "Sunbeam 2000";
            this.Flashlight2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Flashlight3CheckBox
            // 
            this.Flashlight3CheckBox.Location = new System.Drawing.Point(12, 81);
            this.Flashlight3CheckBox.Name = "Flashlight3CheckBox";
            this.Flashlight3CheckBox.Size = new System.Drawing.Size(146, 28);
            this.Flashlight3CheckBox.TabIndex = 2;
            this.Flashlight3CheckBox.Text = "Hunterlantern";
            this.Flashlight3CheckBox.UseVisualStyleBackColor = true;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(116, 125);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // UnlockAllButton
            // 
            this.UnlockAllButton.Location = new System.Drawing.Point(12, 125);
            this.UnlockAllButton.Name = "UnlockAllButton";
            this.UnlockAllButton.Size = new System.Drawing.Size(75, 23);
            this.UnlockAllButton.TabIndex = 4;
            this.UnlockAllButton.Text = "Unlock all";
            this.UnlockAllButton.UseVisualStyleBackColor = true;
            this.UnlockAllButton.Click += new System.EventHandler(this.UnlockAllButton_Click);
            // 
            // FlashlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 160);
            this.Controls.Add(this.UnlockAllButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.Flashlight3CheckBox);
            this.Controls.Add(this.Flashlight2CheckBox);
            this.Controls.Add(this.Flashlight1CheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FlashlightsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unlocked flashlights";
            this.Load += new System.EventHandler(this.FlashlightsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox Flashlight1CheckBox;
        private System.Windows.Forms.CheckBox Flashlight2CheckBox;
        private System.Windows.Forms.CheckBox Flashlight3CheckBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button UnlockAllButton;
    }
}