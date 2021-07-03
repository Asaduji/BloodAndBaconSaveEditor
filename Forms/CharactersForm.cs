using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class CharactersForm : Form
    {
        public CharactersForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void CharactersForm_Load(object sender, EventArgs e)
        {
            var save = Program.CurrentSave;

            //Set values
            Character1CheckBox.Checked = save.UnlockedSpecialCharacter1;
            Character2CheckBox.Checked = save.UnlockedSpecialCharacter2;
            Character3CheckBox.Checked = save.UnlockedSpecialCharacter3;
            Character4CheckBox.Checked = save.UnlockedSpecialCharacter4;

            //Listen to events
            Character1CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            Character2CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            Character3CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            Character4CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            var save = Program.CurrentSave;

            save.UnlockedSpecialCharacter1 = Character1CheckBox.Checked;
            save.UnlockedSpecialCharacter2 = Character2CheckBox.Checked;
            save.UnlockedSpecialCharacter3 = Character3CheckBox.Checked;
            save.UnlockedSpecialCharacter4 = Character4CheckBox.Checked;
        }

        private void UnlockAllButton_Click(object sender, EventArgs e)
        {
            Character1CheckBox.Checked = true;
            Character2CheckBox.Checked = true;
            Character3CheckBox.Checked = true;
            Character4CheckBox.Checked = true;
        }
    }
}
