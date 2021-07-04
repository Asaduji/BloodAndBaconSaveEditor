
namespace BloodAndBaconSaveEditor.Forms
{
    partial class ConsumablesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsumablesForm));
            this.GrenadesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.MilkNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BulkifyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PillsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RocketsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.MaxAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrenadesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkifyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PillsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocketsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GrenadesNumericUpDown
            // 
            this.GrenadesNumericUpDown.Location = new System.Drawing.Point(12, 35);
            this.GrenadesNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.GrenadesNumericUpDown.Name = "GrenadesNumericUpDown";
            this.GrenadesNumericUpDown.Size = new System.Drawing.Size(63, 23);
            this.GrenadesNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grenades";
            // 
            // MilkNumericUpDown
            // 
            this.MilkNumericUpDown.Location = new System.Drawing.Point(81, 35);
            this.MilkNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MilkNumericUpDown.Name = "MilkNumericUpDown";
            this.MilkNumericUpDown.Size = new System.Drawing.Size(63, 23);
            this.MilkNumericUpDown.TabIndex = 2;
            // 
            // BulkifyNumericUpDown
            // 
            this.BulkifyNumericUpDown.Location = new System.Drawing.Point(150, 35);
            this.BulkifyNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BulkifyNumericUpDown.Name = "BulkifyNumericUpDown";
            this.BulkifyNumericUpDown.Size = new System.Drawing.Size(63, 23);
            this.BulkifyNumericUpDown.TabIndex = 3;
            // 
            // PillsNumericUpDown
            // 
            this.PillsNumericUpDown.Location = new System.Drawing.Point(219, 35);
            this.PillsNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PillsNumericUpDown.Name = "PillsNumericUpDown";
            this.PillsNumericUpDown.Size = new System.Drawing.Size(63, 23);
            this.PillsNumericUpDown.TabIndex = 4;
            // 
            // RocketsNumericUpDown
            // 
            this.RocketsNumericUpDown.Location = new System.Drawing.Point(288, 35);
            this.RocketsNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.RocketsNumericUpDown.Name = "RocketsNumericUpDown";
            this.RocketsNumericUpDown.Size = new System.Drawing.Size(63, 23);
            this.RocketsNumericUpDown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Milk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bulkify";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pills";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rockets";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(277, 75);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 10;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // MaxAllButton
            // 
            this.MaxAllButton.Location = new System.Drawing.Point(13, 75);
            this.MaxAllButton.Name = "MaxAllButton";
            this.MaxAllButton.Size = new System.Drawing.Size(75, 23);
            this.MaxAllButton.TabIndex = 11;
            this.MaxAllButton.Text = "Max all";
            this.MaxAllButton.UseVisualStyleBackColor = true;
            this.MaxAllButton.Click += new System.EventHandler(this.MaxAllButton_Click);
            // 
            // ConsumablesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 110);
            this.Controls.Add(this.MaxAllButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RocketsNumericUpDown);
            this.Controls.Add(this.PillsNumericUpDown);
            this.Controls.Add(this.BulkifyNumericUpDown);
            this.Controls.Add(this.MilkNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrenadesNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConsumablesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consumables";
            this.Load += new System.EventHandler(this.ConsumablesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrenadesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MilkNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulkifyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PillsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocketsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown GrenadesNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MilkNumericUpDown;
        private System.Windows.Forms.NumericUpDown BulkifyNumericUpDown;
        private System.Windows.Forms.NumericUpDown PillsNumericUpDown;
        private System.Windows.Forms.NumericUpDown RocketsNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button MaxAllButton;
    }
}