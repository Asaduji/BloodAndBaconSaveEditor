using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class WeaponListForm : Form
    {
        public WeaponListForm()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e) => Close();

        private void WeaponList_Load(object sender, EventArgs e)
        {
            ref var unlockedWeapons = ref Program.CurrentSave.UnlockedWeapons;

            //Set values
            AK47CheckBox.Checked = unlockedWeapons.Ak47;
            ShotgunCheckBox.Checked = unlockedWeapons.Shotgun;
            M16CheckBox.Checked = unlockedWeapons.M16;
            UziCheckBox.Checked = unlockedWeapons.Uzi;
            RocketLauncherCheckBox.Checked = unlockedWeapons.RocketLauncher;
            P90CheckBox.Checked = unlockedWeapons.P90;
            DeagleCheckBox.Checked = unlockedWeapons.Deagle;
            ColtCheckBox.Checked = unlockedWeapons.Colt;
            SilencedPistolCheckBox.Checked = unlockedWeapons.SilencedPistol;
            PaintGunCheckBox.Checked = unlockedWeapons.PaintGun;

            //Listen to events
            AK47CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            ShotgunCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            M16CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            UziCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            RocketLauncherCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            P90CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            DeagleCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            ColtCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            SilencedPistolCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            PaintGunCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;

        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            ref var unlockedWeapons = ref Program.CurrentSave.UnlockedWeapons;
            
            unlockedWeapons.Ak47 = AK47CheckBox.Checked;
            unlockedWeapons.Shotgun = ShotgunCheckBox.Checked;
            unlockedWeapons.M16 = M16CheckBox.Checked;
            unlockedWeapons.Uzi = UziCheckBox.Checked;
            unlockedWeapons.RocketLauncher = RocketLauncherCheckBox.Checked;
            unlockedWeapons.P90 = P90CheckBox.Checked;
            unlockedWeapons.Deagle = DeagleCheckBox.Checked;
            unlockedWeapons.Colt = ColtCheckBox.Checked;
            unlockedWeapons.SilencedPistol = SilencedPistolCheckBox.Checked;
            unlockedWeapons.PaintGun = PaintGunCheckBox.Checked;
        }

        private void UnlockAllButton_Click(object sender, EventArgs e)
        {
            AK47CheckBox.Checked = true;
            ShotgunCheckBox.Checked = true;
            M16CheckBox.Checked = true;
            UziCheckBox.Checked = true;
            RocketLauncherCheckBox.Checked = true;
            P90CheckBox.Checked = true;
            DeagleCheckBox.Checked = true;
            ColtCheckBox.Checked = true;
            SilencedPistolCheckBox.Checked = true;
            PaintGunCheckBox.Checked = true;
        }
    }
}