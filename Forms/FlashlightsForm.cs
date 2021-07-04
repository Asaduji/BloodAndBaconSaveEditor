using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class FlashlightsForm : Form
    {
        public FlashlightsForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void FlashlightsForm_Load(object sender, EventArgs e)
        {
            var save = Program.CurrentSave;

            //Set values
            Flashlight1CheckBox.Checked = save.Flashlight1;
            Flashlight2CheckBox.Checked = save.Flashlight2;
            Flashlight3CheckBox.Checked = save.Flashlight3;

            //Listen to events
            Flashlight1CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            Flashlight2CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            Flashlight3CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            var save = Program.CurrentSave;

            save.Flashlight1 = Flashlight1CheckBox.Checked;
            save.Flashlight2 = Flashlight2CheckBox.Checked;
            save.Flashlight3 = Flashlight3CheckBox.Checked;
        }

        private void UnlockAllButton_Click(object sender, EventArgs e)
        {
            Flashlight1CheckBox.Checked = true;
            Flashlight2CheckBox.Checked = true;
            Flashlight3CheckBox.Checked = true;
        }
    }
}
