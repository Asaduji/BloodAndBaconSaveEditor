using System.ComponentModel;

namespace BloodAndBaconSaveEditor.Forms
{
    partial class WeaponListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponListForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AK47CheckBox = new System.Windows.Forms.CheckBox();
            this.ShotgunCheckBox = new System.Windows.Forms.CheckBox();
            this.M16CheckBox = new System.Windows.Forms.CheckBox();
            this.UziCheckBox = new System.Windows.Forms.CheckBox();
            this.RocketLauncherCheckBox = new System.Windows.Forms.CheckBox();
            this.P90CheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeagleCheckBox = new System.Windows.Forms.CheckBox();
            this.ColtCheckBox = new System.Windows.Forms.CheckBox();
            this.SilencedPistolCheckBox = new System.Windows.Forms.CheckBox();
            this.PaintGunCheckBox = new System.Windows.Forms.CheckBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.UnlockAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primary weapons";
            // 
            // AK47CheckBox
            // 
            this.AK47CheckBox.Location = new System.Drawing.Point(14, 53);
            this.AK47CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AK47CheckBox.Name = "AK47CheckBox";
            this.AK47CheckBox.Size = new System.Drawing.Size(121, 28);
            this.AK47CheckBox.TabIndex = 1;
            this.AK47CheckBox.Text = "AK-47";
            this.AK47CheckBox.UseVisualStyleBackColor = true;
            // 
            // ShotgunCheckBox
            // 
            this.ShotgunCheckBox.Location = new System.Drawing.Point(14, 88);
            this.ShotgunCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ShotgunCheckBox.Name = "ShotgunCheckBox";
            this.ShotgunCheckBox.Size = new System.Drawing.Size(121, 28);
            this.ShotgunCheckBox.TabIndex = 2;
            this.ShotgunCheckBox.Text = "Shotgun";
            this.ShotgunCheckBox.UseVisualStyleBackColor = true;
            // 
            // M16CheckBox
            // 
            this.M16CheckBox.Location = new System.Drawing.Point(14, 122);
            this.M16CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.M16CheckBox.Name = "M16CheckBox";
            this.M16CheckBox.Size = new System.Drawing.Size(121, 28);
            this.M16CheckBox.TabIndex = 3;
            this.M16CheckBox.Text = "M16";
            this.M16CheckBox.UseVisualStyleBackColor = true;
            // 
            // UziCheckBox
            // 
            this.UziCheckBox.Location = new System.Drawing.Point(14, 157);
            this.UziCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UziCheckBox.Name = "UziCheckBox";
            this.UziCheckBox.Size = new System.Drawing.Size(121, 28);
            this.UziCheckBox.TabIndex = 4;
            this.UziCheckBox.Text = "Uzi";
            this.UziCheckBox.UseVisualStyleBackColor = true;
            // 
            // RocketLauncherCheckBox
            // 
            this.RocketLauncherCheckBox.Location = new System.Drawing.Point(14, 192);
            this.RocketLauncherCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RocketLauncherCheckBox.Name = "RocketLauncherCheckBox";
            this.RocketLauncherCheckBox.Size = new System.Drawing.Size(153, 28);
            this.RocketLauncherCheckBox.TabIndex = 5;
            this.RocketLauncherCheckBox.Text = "Rocket launcher";
            this.RocketLauncherCheckBox.UseVisualStyleBackColor = true;
            // 
            // P90CheckBox
            // 
            this.P90CheckBox.Location = new System.Drawing.Point(14, 226);
            this.P90CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.P90CheckBox.Name = "P90CheckBox";
            this.P90CheckBox.Size = new System.Drawing.Size(121, 28);
            this.P90CheckBox.TabIndex = 6;
            this.P90CheckBox.Text = "P90";
            this.P90CheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(183, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Secondary weapons";
            // 
            // DeagleCheckBox
            // 
            this.DeagleCheckBox.AutoSize = true;
            this.DeagleCheckBox.Location = new System.Drawing.Point(183, 58);
            this.DeagleCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeagleCheckBox.Name = "DeagleCheckBox";
            this.DeagleCheckBox.Size = new System.Drawing.Size(62, 19);
            this.DeagleCheckBox.TabIndex = 8;
            this.DeagleCheckBox.Text = "Deagle";
            this.DeagleCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColtCheckBox
            // 
            this.ColtCheckBox.AutoSize = true;
            this.ColtCheckBox.Location = new System.Drawing.Point(183, 93);
            this.ColtCheckBox.Name = "ColtCheckBox";
            this.ColtCheckBox.Size = new System.Drawing.Size(48, 19);
            this.ColtCheckBox.TabIndex = 9;
            this.ColtCheckBox.Text = "Colt";
            this.ColtCheckBox.UseVisualStyleBackColor = true;
            // 
            // SilencedPistolCheckBox
            // 
            this.SilencedPistolCheckBox.AutoSize = true;
            this.SilencedPistolCheckBox.Location = new System.Drawing.Point(183, 127);
            this.SilencedPistolCheckBox.Name = "SilencedPistolCheckBox";
            this.SilencedPistolCheckBox.Size = new System.Drawing.Size(102, 19);
            this.SilencedPistolCheckBox.TabIndex = 10;
            this.SilencedPistolCheckBox.Text = "Silenced pistol";
            this.SilencedPistolCheckBox.UseVisualStyleBackColor = true;
            // 
            // PaintGunCheckBox
            // 
            this.PaintGunCheckBox.AutoSize = true;
            this.PaintGunCheckBox.Location = new System.Drawing.Point(183, 162);
            this.PaintGunCheckBox.Name = "PaintGunCheckBox";
            this.PaintGunCheckBox.Size = new System.Drawing.Size(77, 19);
            this.PaintGunCheckBox.TabIndex = 11;
            this.PaintGunCheckBox.Text = "Paint gun";
            this.PaintGunCheckBox.UseVisualStyleBackColor = true;
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(252, 267);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 12;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // UnlockAllButton
            // 
            this.UnlockAllButton.Location = new System.Drawing.Point(12, 267);
            this.UnlockAllButton.Name = "UnlockAllButton";
            this.UnlockAllButton.Size = new System.Drawing.Size(75, 23);
            this.UnlockAllButton.TabIndex = 13;
            this.UnlockAllButton.Text = "Unlock all";
            this.UnlockAllButton.UseVisualStyleBackColor = true;
            this.UnlockAllButton.Click += new System.EventHandler(this.UnlockAllButton_Click);
            // 
            // WeaponListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 302);
            this.Controls.Add(this.UnlockAllButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.PaintGunCheckBox);
            this.Controls.Add(this.SilencedPistolCheckBox);
            this.Controls.Add(this.ColtCheckBox);
            this.Controls.Add(this.DeagleCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P90CheckBox);
            this.Controls.Add(this.RocketLauncherCheckBox);
            this.Controls.Add(this.UziCheckBox);
            this.Controls.Add(this.M16CheckBox);
            this.Controls.Add(this.ShotgunCheckBox);
            this.Controls.Add(this.AK47CheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "WeaponListForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unlocked weapons";
            this.Load += new System.EventHandler(this.WeaponList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox M16CheckBox;

        private System.Windows.Forms.CheckBox ShotgunCheckBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AK47CheckBox;
        private System.Windows.Forms.CheckBox UziCheckBox;
        private System.Windows.Forms.CheckBox P90CheckBox;
        private System.Windows.Forms.CheckBox DeagleCheckBox;
        private System.Windows.Forms.CheckBox ColtCheckBox;
        private System.Windows.Forms.CheckBox SilencedPistolCheckBox;
        private System.Windows.Forms.CheckBox PaintGunCheckBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.CheckBox RocketLauncherCheckBox;
        #endregion

        private System.Windows.Forms.Button UnlockAllButton;
    }
}