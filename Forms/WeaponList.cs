using System;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class WeaponList : Form
    {
        public WeaponList()
        {
            InitializeComponent();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WeaponList_Load(object sender, EventArgs e)
        {
            ref var unlockedWeapons = ref Program.CurrentSave.UnlockedWeapons;

            //Set values
            ak47CheckBox.Checked = unlockedWeapons.Ak47;
            shotgunCheckBox.Checked = unlockedWeapons.Shotgun;
            m16CheckBox.Checked = unlockedWeapons.M16;
            uziCheckBox.Checked = unlockedWeapons.Uzi;
            rocketLauncherCheckBox.Checked = unlockedWeapons.RocketLauncher;
            p90CheckBox.Checked = unlockedWeapons.P90;
            deagleCheckBox.Checked = unlockedWeapons.Deagle;
            coltCheckBox.Checked = unlockedWeapons.Colt;
            silencedPistolCheckBox.Checked = unlockedWeapons.SilencedPistol;
            paintGunCheckBox.Checked = unlockedWeapons.PaintGun;

            //Listen to events
            ak47CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            shotgunCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            m16CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            uziCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            rocketLauncherCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            p90CheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            deagleCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            coltCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            silencedPistolCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;
            paintGunCheckBox.CheckedChanged += OnCheckBoxCheckedChanged;

        }

        private void OnCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            ref var unlockedWeapons = ref Program.CurrentSave.UnlockedWeapons;
            
            unlockedWeapons.Ak47 = ak47CheckBox.Checked;
            unlockedWeapons.Shotgun = shotgunCheckBox.Checked;
            unlockedWeapons.M16 = m16CheckBox.Checked;
            unlockedWeapons.Uzi = uziCheckBox.Checked;
            unlockedWeapons.RocketLauncher = rocketLauncherCheckBox.Checked;
            unlockedWeapons.P90 = p90CheckBox.Checked;
            unlockedWeapons.Deagle = deagleCheckBox.Checked;
            unlockedWeapons.Colt = coltCheckBox.Checked;
            unlockedWeapons.SilencedPistol = silencedPistolCheckBox.Checked;
            unlockedWeapons.PaintGun = paintGunCheckBox.Checked;
        }
    }
}