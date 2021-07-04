using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class ConsumablesForm : Form
    {
        public ConsumablesForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void ConsumablesForm_Load(object sender, EventArgs e)
        {
            ref var consumables = ref Program.CurrentSave.Consumables;

            //Set values
            GrenadesNumericUpDown.Value = consumables.Grenades;
            MilkNumericUpDown.Value = consumables.Milk;
            BulkifyNumericUpDown.Value = consumables.Bulkify;
            PillsNumericUpDown.Value = consumables.Pills;
            RocketsNumericUpDown.Value = consumables.Rockets;

            //Listen to events
            GrenadesNumericUpDown.ValueChanged += OnNumericUpDownValueChanged;
            MilkNumericUpDown.ValueChanged += OnNumericUpDownValueChanged;
            BulkifyNumericUpDown.ValueChanged += OnNumericUpDownValueChanged;
            PillsNumericUpDown.ValueChanged += OnNumericUpDownValueChanged;
            RocketsNumericUpDown.ValueChanged += OnNumericUpDownValueChanged;
        }

        private void OnNumericUpDownValueChanged(object sender, EventArgs e)
        {
            ref var consumables = ref Program.CurrentSave.Consumables;
            consumables.Grenades = (byte)GrenadesNumericUpDown.Value;
            consumables.Milk = (byte)MilkNumericUpDown.Value;
            consumables.Bulkify = (byte)BulkifyNumericUpDown.Value;
            consumables.Pills = (byte)PillsNumericUpDown.Value;
            consumables.Rockets = (byte)RocketsNumericUpDown.Value;
        }

        private void MaxAllButton_Click(object sender, EventArgs e)
        {
            GrenadesNumericUpDown.Value = 10;
            MilkNumericUpDown.Value = 10;
            BulkifyNumericUpDown.Value = 5;
            PillsNumericUpDown.Value = 5;
            RocketsNumericUpDown.Value = 2;
        }
    }
}
