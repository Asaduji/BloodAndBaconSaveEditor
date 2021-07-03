using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class DaysForm : Form
    {
        public DaysForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void SelectedDayNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var days = Program.CurrentSave.UnlockedDays;         
            var day = days[Math.Clamp((int)SelectedDayNumericUpDown.Value, 0, 101)];
            SetDayStatus(day);
        }

        private void DaysForm_Load(object sender, EventArgs e)
        {
            SetDayStatus(Program.CurrentSave.UnlockedDays[1]);
        }

        /// <summary>
        /// Sets the current day lock status in the RadioButtons
        /// </summary>
        /// <param name="day"></param>
        private void SetDayStatus(byte day)
        {
            switch (day)
            {
                case 0:
                    LockedRadioButton.Checked = true;
                    break;
                case 1:
                    EasyRadioButton.Checked = true;
                    break;
                case 2:
                    NormalRadioButton.Checked = true;
                    break;
                case 3:
                    HardRadioButton.Checked = true;
                    break;
            }
        }

        /// <summary>
        /// Gets the day status value depending on the selected RadioButton
        /// </summary>
        /// <returns></returns>
        private byte GetDayStatus()
        {
            if (LockedRadioButton.Checked) return 0;
            if (EasyRadioButton.Checked) return 1;
            if (NormalRadioButton.Checked) return 2;
            if (HardRadioButton.Checked) return 3;
            return 0;
        }

        private void SetStatusForCurrentDayButton_Click(object sender, EventArgs e)
        {
            var days = Program.CurrentSave.UnlockedDays;
            days[Math.Clamp((int)SelectedDayNumericUpDown.Value, 0, 101)] = GetDayStatus();
            MessageBox.Show($"Successfully changed lock status for day {(int)SelectedDayNumericUpDown.Value}", "Success");
        }

        private void SetStatusForAllDaysButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to set the current lock status to all days?", "Set status for all days", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                var days = Program.CurrentSave.UnlockedDays;
                var status = GetDayStatus();
                //Start on index 1 because index 0 is useless, day 1 starts at index 1
                for (var i = 1; i < 102; i++)
                {
                    days[i] = status;
                }
                MessageBox.Show("Lock status was set successfully to all days", "Success");
            }
        }
    }
}
