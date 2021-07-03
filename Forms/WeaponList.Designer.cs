using System.ComponentModel;

namespace BloodAndBaconSaveEditor.Forms
{
    partial class WeaponList
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeaponList));
            this.label1 = new System.Windows.Forms.Label();
            this.ak47CheckBox = new System.Windows.Forms.CheckBox();
            this.shotgunCheckBox = new System.Windows.Forms.CheckBox();
            this.m16CheckBox = new System.Windows.Forms.CheckBox();
            this.uziCheckBox = new System.Windows.Forms.CheckBox();
            this.rocketLauncherCheckBox = new System.Windows.Forms.CheckBox();
            this.p90CheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deagleCheckBox = new System.Windows.Forms.CheckBox();
            this.coltCheckBox = new System.Windows.Forms.CheckBox();
            this.silencedPistolCheckBox = new System.Windows.Forms.CheckBox();
            this.paintGunCheckBox = new System.Windows.Forms.CheckBox();
            this.doneButton = new System.Windows.Forms.Button();
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
            // ak47CheckBox
            // 
            this.ak47CheckBox.Location = new System.Drawing.Point(14, 53);
            this.ak47CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ak47CheckBox.Name = "ak47CheckBox";
            this.ak47CheckBox.Size = new System.Drawing.Size(121, 28);
            this.ak47CheckBox.TabIndex = 1;
            this.ak47CheckBox.Text = "AK-47";
            this.ak47CheckBox.UseVisualStyleBackColor = true;
            // 
            // shotgunCheckBox
            // 
            this.shotgunCheckBox.Location = new System.Drawing.Point(14, 88);
            this.shotgunCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.shotgunCheckBox.Name = "shotgunCheckBox";
            this.shotgunCheckBox.Size = new System.Drawing.Size(121, 28);
            this.shotgunCheckBox.TabIndex = 2;
            this.shotgunCheckBox.Text = "Shotgun";
            this.shotgunCheckBox.UseVisualStyleBackColor = true;
            // 
            // m16CheckBox
            // 
            this.m16CheckBox.Location = new System.Drawing.Point(14, 122);
            this.m16CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m16CheckBox.Name = "m16CheckBox";
            this.m16CheckBox.Size = new System.Drawing.Size(121, 28);
            this.m16CheckBox.TabIndex = 3;
            this.m16CheckBox.Text = "M16";
            this.m16CheckBox.UseVisualStyleBackColor = true;
            // 
            // uziCheckBox
            // 
            this.uziCheckBox.Location = new System.Drawing.Point(14, 157);
            this.uziCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.uziCheckBox.Name = "uziCheckBox";
            this.uziCheckBox.Size = new System.Drawing.Size(121, 28);
            this.uziCheckBox.TabIndex = 4;
            this.uziCheckBox.Text = "Uzi";
            this.uziCheckBox.UseVisualStyleBackColor = true;
            // 
            // rocketLauncherCheckBox
            // 
            this.rocketLauncherCheckBox.Location = new System.Drawing.Point(14, 192);
            this.rocketLauncherCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rocketLauncherCheckBox.Name = "rocketLauncherCheckBox";
            this.rocketLauncherCheckBox.Size = new System.Drawing.Size(153, 28);
            this.rocketLauncherCheckBox.TabIndex = 5;
            this.rocketLauncherCheckBox.Text = "Rocket launcher";
            this.rocketLauncherCheckBox.UseVisualStyleBackColor = true;
            // 
            // p90CheckBox
            // 
            this.p90CheckBox.Location = new System.Drawing.Point(14, 226);
            this.p90CheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.p90CheckBox.Name = "p90CheckBox";
            this.p90CheckBox.Size = new System.Drawing.Size(121, 28);
            this.p90CheckBox.TabIndex = 6;
            this.p90CheckBox.Text = "P90";
            this.p90CheckBox.UseVisualStyleBackColor = true;
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
            // deagleCheckBox
            // 
            this.deagleCheckBox.AutoSize = true;
            this.deagleCheckBox.Location = new System.Drawing.Point(183, 58);
            this.deagleCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deagleCheckBox.Name = "deagleCheckBox";
            this.deagleCheckBox.Size = new System.Drawing.Size(62, 19);
            this.deagleCheckBox.TabIndex = 8;
            this.deagleCheckBox.Text = "Deagle";
            this.deagleCheckBox.UseVisualStyleBackColor = true;
            // 
            // coltCheckBox
            // 
            this.coltCheckBox.AutoSize = true;
            this.coltCheckBox.Location = new System.Drawing.Point(183, 93);
            this.coltCheckBox.Name = "coltCheckBox";
            this.coltCheckBox.Size = new System.Drawing.Size(48, 19);
            this.coltCheckBox.TabIndex = 9;
            this.coltCheckBox.Text = "Colt";
            this.coltCheckBox.UseVisualStyleBackColor = true;
            // 
            // silencedPistolCheckBox
            // 
            this.silencedPistolCheckBox.AutoSize = true;
            this.silencedPistolCheckBox.Location = new System.Drawing.Point(183, 127);
            this.silencedPistolCheckBox.Name = "silencedPistolCheckBox";
            this.silencedPistolCheckBox.Size = new System.Drawing.Size(102, 19);
            this.silencedPistolCheckBox.TabIndex = 10;
            this.silencedPistolCheckBox.Text = "Silenced pistol";
            this.silencedPistolCheckBox.UseVisualStyleBackColor = true;
            // 
            // paintGunCheckBox
            // 
            this.paintGunCheckBox.AutoSize = true;
            this.paintGunCheckBox.Location = new System.Drawing.Point(183, 162);
            this.paintGunCheckBox.Name = "paintGunCheckBox";
            this.paintGunCheckBox.Size = new System.Drawing.Size(77, 19);
            this.paintGunCheckBox.TabIndex = 11;
            this.paintGunCheckBox.Text = "Paint gun";
            this.paintGunCheckBox.UseVisualStyleBackColor = true;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(242, 240);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 12;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // WeaponList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 275);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.paintGunCheckBox);
            this.Controls.Add(this.silencedPistolCheckBox);
            this.Controls.Add(this.coltCheckBox);
            this.Controls.Add(this.deagleCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.p90CheckBox);
            this.Controls.Add(this.rocketLauncherCheckBox);
            this.Controls.Add(this.uziCheckBox);
            this.Controls.Add(this.m16CheckBox);
            this.Controls.Add(this.shotgunCheckBox);
            this.Controls.Add(this.ak47CheckBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeaponList";
            this.ShowIcon = false;
            this.Text = "Unlocked weapons";
            this.Load += new System.EventHandler(this.WeaponList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox m16CheckBox;

        private System.Windows.Forms.CheckBox shotgunCheckBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ak47CheckBox;
        private System.Windows.Forms.CheckBox uziCheckBox;
        private System.Windows.Forms.CheckBox p90CheckBox;
        private System.Windows.Forms.CheckBox rocketLauncherCheckBox;

        private System.Windows.Forms.CheckBox deagleCheckBox;
        private System.Windows.Forms.CheckBox coltCheckBox;
        private System.Windows.Forms.CheckBox silencedPistolCheckBox;
        private System.Windows.Forms.CheckBox paintGunCheckBox;
        private System.Windows.Forms.Button doneButton;
    }
}