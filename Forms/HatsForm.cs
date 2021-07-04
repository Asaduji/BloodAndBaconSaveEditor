using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class HatsForm : Form
    {
        public HatsForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void HatsForm_Load(object sender, EventArgs e)
        {
            ref var hats = ref Program.CurrentSave.UnlockedHats;

            //Set values
            GasMaskCheckBox.Checked = hats.GasMask;
            WizardHatCheckBox.Checked = hats.WizardHat;
            GermanHelmutCheckBox.Checked = hats.GermanHelmut;
            TractorCapCheckBox.Checked = hats.TractorCap;
            RussianBolCheckBox.Checked = hats.RussianBol;
            CowboyHatCheckBox.Checked = hats.CowboyHat;
            TopHatCheckBox.Checked = hats.TopHat;
            BowlerHatCheckBox.Checked = hats.BowlerHat;
            IrishTweedCheckBox.Checked = hats.IrishTweed;
            PeruvianPomCheckBox.Checked = hats.PeruvianPom;
            SnowCapCheckBox.Checked = hats.SnowCap;
            MacarthurCheckBox.Checked = hats.Macarthur;
            RedsunHatCheckBox.Checked = hats.RedsunHat;
            ElfinHatCheckBox.Checked = hats.ElfinHat;
            PumpkinCheckBox.Checked = hats.Pumpkin;

            //Listen to events
            GasMaskCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            WizardHatCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            GermanHelmutCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            TractorCapCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            RussianBolCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            CowboyHatCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            TopHatCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            BowlerHatCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            IrishTweedCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            PeruvianPomCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            SnowCapCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            MacarthurCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            RedsunHatCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            ElfinHatCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            PumpkinCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            ref var hats = ref Program.CurrentSave.UnlockedHats;

            hats.GasMask = GasMaskCheckBox.Checked;
            hats.WizardHat = WizardHatCheckBox.Checked;
            hats.GermanHelmut = GermanHelmutCheckBox.Checked;
            hats.TractorCap = TractorCapCheckBox.Checked;
            hats.RussianBol = RussianBolCheckBox.Checked;
            hats.CowboyHat = CowboyHatCheckBox.Checked;
            hats.TopHat = TopHatCheckBox.Checked;
            hats.BowlerHat = BowlerHatCheckBox.Checked;
            hats.IrishTweed = IrishTweedCheckBox.Checked;
            hats.PeruvianPom = PeruvianPomCheckBox.Checked;
            hats.SnowCap = SnowCapCheckBox.Checked;
            hats.Macarthur = MacarthurCheckBox.Checked;
            hats.RedsunHat = RedsunHatCheckBox.Checked;
            hats.ElfinHat = ElfinHatCheckBox.Checked;
            hats.Pumpkin = PumpkinCheckBox.Checked;
        }

        private void UnlockAllButton_Click(object sender, EventArgs e)
        {
            ref var hats = ref Program.CurrentSave.UnlockedHats;

            GasMaskCheckBox.Checked = true;
            WizardHatCheckBox.Checked = true;
            GermanHelmutCheckBox.Checked = true;
            TractorCapCheckBox.Checked = true;
            RussianBolCheckBox.Checked = true;
            CowboyHatCheckBox.Checked = true;
            TopHatCheckBox.Checked = true;
            BowlerHatCheckBox.Checked = true;
            IrishTweedCheckBox.Checked = true;
            PeruvianPomCheckBox.Checked = true;
            SnowCapCheckBox.Checked = true;
            MacarthurCheckBox.Checked = true;
            RedsunHatCheckBox.Checked = true;
            ElfinHatCheckBox.Checked = true;
            PumpkinCheckBox.Checked = true;
        }
    }
}
