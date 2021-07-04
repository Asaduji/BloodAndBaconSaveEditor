using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class CollectiblesForm : Form
    {
        public CollectiblesForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void CollectiblesForm_Load(object sender, EventArgs e)
        {
            var save = Program.CurrentSave;

            //Set values

            //RedSkull 1
            RedSkull1LockedRadioButton.Checked = save.RedSkull1 == 0;
            RedSkull1OnInventoryRadioButton.Checked = save.RedSkull1 == 1;
            RedSkull1UnlockedRadioButton.Checked = save.RedSkull1 == 2;

            //RedSkull 2
            RedSkull2LockedRadioButton.Checked = save.RedSkull2 == 0;
            RedSkull2OnInventoryRadioButton.Checked = save.RedSkull2 == 1;
            RedSkull2UnlockedRadioButton.Checked = save.RedSkull2 == 2;

            //RedSkull 3
            RedSkull3LockedRadioButton.Checked = save.RedSkull3 == 0;
            RedSkull3OnInventoryRadioButton.Checked = save.RedSkull3 == 1;
            RedSkull3UnlockedRadioButton.Checked = save.RedSkull3 == 2;

            //Relic 1
            Relic1LockedRadioButton.Checked = save.Relic1 == 0;
            Relic1OnInventoryRadioButton.Checked = save.Relic1 == 1;
            Relic1UnlockedRadioButton.Checked = save.Relic1 == 2;

            //Relic 2
            Relic2LockedRadioButton.Checked = save.Relic2 == 0;
            Relic2OnInventoryRadioButton.Checked = save.Relic2 == 1;
            Relic2UnlockedRadioButton.Checked = save.Relic2 == 2;

            //Relic 3
            Relic3LockedRadioButton.Checked = save.Relic3 == 0;
            Relic3OnInventoryRadioButton.Checked = save.Relic3 == 1;
            Relic3UnlockedRadioButton.Checked = save.Relic3 == 2;

            //Listen to events

            //RedSkull 1
            RedSkull1LockedRadioButton.CheckedChanged += OnRedSkull1RadioButtonCheckedChange;
            RedSkull1OnInventoryRadioButton.CheckedChanged += OnRedSkull1RadioButtonCheckedChange;
            RedSkull1UnlockedRadioButton.CheckedChanged += OnRedSkull1RadioButtonCheckedChange;

            //RedSkull 2
            RedSkull2LockedRadioButton.CheckedChanged += OnRedSkull2RadioButtonCheckedChange;
            RedSkull2OnInventoryRadioButton.CheckedChanged += OnRedSkull2RadioButtonCheckedChange;
            RedSkull2UnlockedRadioButton.CheckedChanged += OnRedSkull2RadioButtonCheckedChange;

            //RedSkull 3
            RedSkull3LockedRadioButton.CheckedChanged += OnRedSkull3RadioButtonCheckedChange;
            RedSkull3OnInventoryRadioButton.CheckedChanged += OnRedSkull3RadioButtonCheckedChange;
            RedSkull3UnlockedRadioButton.CheckedChanged += OnRedSkull3RadioButtonCheckedChange;

            //Relic 1
            Relic1LockedRadioButton.CheckedChanged += OnRelic1RadioButtonCheckedChange;
            Relic1OnInventoryRadioButton.CheckedChanged += OnRelic1RadioButtonCheckedChange;
            Relic1UnlockedRadioButton.CheckedChanged += OnRelic1RadioButtonCheckedChange;

            //Relic 2
            Relic2LockedRadioButton.CheckedChanged += OnRelic2RadioButtonCheckedChange;
            Relic2OnInventoryRadioButton.CheckedChanged += OnRelic2RadioButtonCheckedChange;
            Relic2UnlockedRadioButton.CheckedChanged += OnRelic2RadioButtonCheckedChange;

            //Relic 3
            Relic3LockedRadioButton.CheckedChanged += OnRelic3RadioButtonCheckedChange;
            Relic3OnInventoryRadioButton.CheckedChanged += OnRelic3RadioButtonCheckedChange;
            Relic3UnlockedRadioButton.CheckedChanged += OnRelic3RadioButtonCheckedChange;
        }

        //RedSkull 1
        private void OnRedSkull1RadioButtonCheckedChange(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            var save = Program.CurrentSave;

            if (RedSkull1LockedRadioButton.Checked) save.RedSkull1 = 0;
            if (RedSkull1OnInventoryRadioButton.Checked) save.RedSkull1 = 1;
            if (RedSkull1UnlockedRadioButton.Checked) save.RedSkull1 = 2;
        }

        //RedSkull 2
        private void OnRedSkull2RadioButtonCheckedChange(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            var save = Program.CurrentSave;

            if (RedSkull2LockedRadioButton.Checked) save.RedSkull2 = 0;
            if (RedSkull2OnInventoryRadioButton.Checked) save.RedSkull2 = 1;
            if (RedSkull2UnlockedRadioButton.Checked) save.RedSkull2 = 2;
        }

        //RedSkull 3
        private void OnRedSkull3RadioButtonCheckedChange(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            var save = Program.CurrentSave;

            if (RedSkull3LockedRadioButton.Checked) save.RedSkull3 = 0;
            if (RedSkull3OnInventoryRadioButton.Checked) save.RedSkull3 = 1;
            if (RedSkull3UnlockedRadioButton.Checked) save.RedSkull3 = 2;
        }

        //Relic 1
        private void OnRelic1RadioButtonCheckedChange(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            var save = Program.CurrentSave;

            if (Relic1LockedRadioButton.Checked) save.Relic1 = 0;
            if (Relic1OnInventoryRadioButton.Checked) save.Relic1 = 1;
            if (Relic1UnlockedRadioButton.Checked) save.Relic1 = 2;
        }

        //Relic 2
        private void OnRelic2RadioButtonCheckedChange(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            var save = Program.CurrentSave;

            if (Relic2LockedRadioButton.Checked) save.Relic2 = 0;
            if (Relic2OnInventoryRadioButton.Checked) save.Relic2 = 1;
            if (Relic2UnlockedRadioButton.Checked) save.Relic2 = 2;
        }

        //Relic 3
        private void OnRelic3RadioButtonCheckedChange(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked) return;

            var save = Program.CurrentSave;

            if (Relic3LockedRadioButton.Checked) save.Relic3 = 0;
            if (Relic3OnInventoryRadioButton.Checked) save.Relic3 = 1;
            if (Relic3UnlockedRadioButton.Checked) save.Relic3 = 2;
        }

        private void UnlockAllButton_Click(object sender, EventArgs e)
        {
            RedSkull1UnlockedRadioButton.Checked = true;
            RedSkull2UnlockedRadioButton.Checked = true;
            RedSkull3UnlockedRadioButton.Checked = true;
            Relic1UnlockedRadioButton.Checked = true;
            Relic2UnlockedRadioButton.Checked = true;
            Relic3UnlockedRadioButton.Checked = true;
        }
    }
}
