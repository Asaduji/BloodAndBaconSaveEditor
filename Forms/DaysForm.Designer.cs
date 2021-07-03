
namespace BloodAndBaconSaveEditor.Forms
{
    partial class DaysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DaysForm));
            this.SelectedDayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SetStatusForCurrentDayButton = new System.Windows.Forms.Button();
            this.LockedRadioButton = new System.Windows.Forms.RadioButton();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.NormalRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SetStatusForAllDaysButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDayNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectedDayNumericUpDown
            // 
            this.SelectedDayNumericUpDown.Location = new System.Drawing.Point(12, 30);
            this.SelectedDayNumericUpDown.Maximum = new decimal(new int[] {
            101,
            0,
            0,
            0});
            this.SelectedDayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SelectedDayNumericUpDown.Name = "SelectedDayNumericUpDown";
            this.SelectedDayNumericUpDown.Size = new System.Drawing.Size(84, 23);
            this.SelectedDayNumericUpDown.TabIndex = 0;
            this.SelectedDayNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SelectedDayNumericUpDown.ValueChanged += new System.EventHandler(this.SelectedDayNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Day";
            // 
            // SetStatusForCurrentDayButton
            // 
            this.SetStatusForCurrentDayButton.Location = new System.Drawing.Point(11, 185);
            this.SetStatusForCurrentDayButton.Name = "SetStatusForCurrentDayButton";
            this.SetStatusForCurrentDayButton.Size = new System.Drawing.Size(163, 23);
            this.SetStatusForCurrentDayButton.TabIndex = 4;
            this.SetStatusForCurrentDayButton.Text = "Set status for selected day";
            this.SetStatusForCurrentDayButton.UseVisualStyleBackColor = true;
            this.SetStatusForCurrentDayButton.Click += new System.EventHandler(this.SetStatusForCurrentDayButton_Click);
            // 
            // LockedRadioButton
            // 
            this.LockedRadioButton.AutoSize = true;
            this.LockedRadioButton.Checked = true;
            this.LockedRadioButton.Location = new System.Drawing.Point(12, 74);
            this.LockedRadioButton.Name = "LockedRadioButton";
            this.LockedRadioButton.Size = new System.Drawing.Size(63, 19);
            this.LockedRadioButton.TabIndex = 5;
            this.LockedRadioButton.TabStop = true;
            this.LockedRadioButton.Text = "Locked";
            this.LockedRadioButton.UseVisualStyleBackColor = true;
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Location = new System.Drawing.Point(12, 99);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(48, 19);
            this.EasyRadioButton.TabIndex = 6;
            this.EasyRadioButton.Text = "Easy";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // NormalRadioButton
            // 
            this.NormalRadioButton.AutoSize = true;
            this.NormalRadioButton.Location = new System.Drawing.Point(12, 124);
            this.NormalRadioButton.Name = "NormalRadioButton";
            this.NormalRadioButton.Size = new System.Drawing.Size(65, 19);
            this.NormalRadioButton.TabIndex = 7;
            this.NormalRadioButton.Text = "Normal";
            this.NormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Location = new System.Drawing.Point(12, 149);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(51, 19);
            this.HardRadioButton.TabIndex = 8;
            this.HardRadioButton.Text = "Hard";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Day unlock status";
            // 
            // SetStatusForAllDaysButton
            // 
            this.SetStatusForAllDaysButton.Location = new System.Drawing.Point(11, 214);
            this.SetStatusForAllDaysButton.Name = "SetStatusForAllDaysButton";
            this.SetStatusForAllDaysButton.Size = new System.Drawing.Size(162, 23);
            this.SetStatusForAllDaysButton.TabIndex = 10;
            this.SetStatusForAllDaysButton.Text = "Set status for all days";
            this.SetStatusForAllDaysButton.UseVisualStyleBackColor = true;
            this.SetStatusForAllDaysButton.Click += new System.EventHandler(this.SetStatusForAllDaysButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(103, 264);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 11;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 299);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.SetStatusForAllDaysButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HardRadioButton);
            this.Controls.Add(this.NormalRadioButton);
            this.Controls.Add(this.EasyRadioButton);
            this.Controls.Add(this.LockedRadioButton);
            this.Controls.Add(this.SetStatusForCurrentDayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectedDayNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DaysForm";
            this.ShowIcon = false;
            this.Text = "Days";
            this.Load += new System.EventHandler(this.DaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedDayNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SelectedDayNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetStatusForCurrentDayButton;
        private System.Windows.Forms.RadioButton LockedRadioButton;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.RadioButton NormalRadioButton;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetStatusForAllDaysButton;
        private System.Windows.Forms.Button DoneButton;
    }
}