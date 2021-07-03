using BloodAndBaconSaveEditor.Saves;
using System;
using System.IO;
using System.Windows.Forms;

namespace BloodAndBaconSaveEditor.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog();
            fileDialog.Filter = "save file|savegame";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = fileDialog.FileName;
                var bytes = File.ReadAllBytes(path);
                Program.CurrentSave = new GameSave(bytes);

                //Enable controls
                UnlockedWeaponsButton.Enabled = true;
                ConsumablesButton.Enabled = true;
                SaveFileButton.Enabled = true;
            }
        }

        private void UnlockedWeaponsButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var weaponList = new WeaponListForm();
            weaponList.ShowDialog();
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            using var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "save file|savegame";
            saveDialog.FileName = "savegame";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveDialog.FileName;
                File.WriteAllBytes(path, Program.CurrentSave.GetBytes());
                MessageBox.Show("Saved data");
            }
        }

        private void ConsumablesButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var consumables = new ConsumablesForm();
            consumables.ShowDialog();
        }
    }
}