
namespace BloodAndBaconSaveEditor.Forms
{
    partial class CharactersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharactersForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Character1CheckBox = new System.Windows.Forms.CheckBox();
            this.Character2CheckBox = new System.Windows.Forms.CheckBox();
            this.Character3CheckBox = new System.Windows.Forms.CheckBox();
            this.Character4CheckBox = new System.Windows.Forms.CheckBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UnlockAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTE: To unlock the farmer as playable character you need to complete the game.\nY" +
    "ou can use the \"days\" option to unlock all days.";
            // 
            // Character1CheckBox
            // 
            this.Character1CheckBox.AutoSize = true;
            this.Character1CheckBox.Location = new System.Drawing.Point(12, 25);
            this.Character1CheckBox.Name = "Character1CheckBox";
            this.Character1CheckBox.Size = new System.Drawing.Size(91, 19);
            this.Character1CheckBox.TabIndex = 1;
            this.Character1CheckBox.Text = "A Scarecrow";
            this.Character1CheckBox.UseVisualStyleBackColor = true;
            // 
            // Character2CheckBox
            // 
            this.Character2CheckBox.AutoSize = true;
            this.Character2CheckBox.Location = new System.Drawing.Point(124, 25);
            this.Character2CheckBox.Name = "Character2CheckBox";
            this.Character2CheckBox.Size = new System.Drawing.Size(79, 19);
            this.Character2CheckBox.TabIndex = 2;
            this.Character2CheckBox.Text = "Toy Robot";
            this.Character2CheckBox.UseVisualStyleBackColor = true;
            // 
            // Character3CheckBox
            // 
            this.Character3CheckBox.AutoSize = true;
            this.Character3CheckBox.Location = new System.Drawing.Point(12, 50);
            this.Character3CheckBox.Name = "Character3CheckBox";
            this.Character3CheckBox.Size = new System.Drawing.Size(83, 19);
            this.Character3CheckBox.TabIndex = 3;
            this.Character3CheckBox.Text = "The Golem";
            this.Character3CheckBox.UseVisualStyleBackColor = true;
            // 
            // Character4CheckBox
            // 
            this.Character4CheckBox.AutoSize = true;
            this.Character4CheckBox.Location = new System.Drawing.Point(124, 49);
            this.Character4CheckBox.Name = "Character4CheckBox";
            this.Character4CheckBox.Size = new System.Drawing.Size(78, 19);
            this.Character4CheckBox.TabIndex = 4;
            this.Character4CheckBox.Text = "Astronaut";
            this.Character4CheckBox.UseVisualStyleBackColor = true;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(375, 114);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 5;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // UnlockAllButton
            // 
            this.UnlockAllButton.Location = new System.Drawing.Point(13, 113);
            this.UnlockAllButton.Name = "UnlockAllButton";
            this.UnlockAllButton.Size = new System.Drawing.Size(75, 23);
            this.UnlockAllButton.TabIndex = 6;
            this.UnlockAllButton.Text = "Unlock all";
            this.UnlockAllButton.UseVisualStyleBackColor = true;
            this.UnlockAllButton.Click += new System.EventHandler(this.UnlockAllButton_Click);
            // 
            // CharactersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 149);
            this.Controls.Add(this.UnlockAllButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.Character4CheckBox);
            this.Controls.Add(this.Character3CheckBox);
            this.Controls.Add(this.Character2CheckBox);
            this.Controls.Add(this.Character1CheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CharactersForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unlock special characters";
            this.Load += new System.EventHandler(this.CharactersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Character1CheckBox;
        private System.Windows.Forms.CheckBox Character2CheckBox;
        private System.Windows.Forms.CheckBox Character3CheckBox;
        private System.Windows.Forms.CheckBox Character4CheckBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button UnlockAllButton;
    }
}