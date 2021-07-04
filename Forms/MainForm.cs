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
                WeaponsButton.Enabled = true;
                ConsumablesButton.Enabled = true;
                DaysButton.Enabled = true;
                CharactersButton.Enabled = true;
                HatsButton.Enabled = true;
                CollectiblesButton.Enabled = true;
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
                MessageBox.Show("Saved data", "Success");
            }
        }

        private void ConsumablesButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var consumables = new ConsumablesForm();
            consumables.ShowDialog();
        }

        private void DaysButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var days = new DaysForm();
            days.ShowDialog();
        }

        private void CharactersButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var characters = new CharactersForm();
            characters.ShowDialog();
        }

        private void HatsButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var hats = new HatsForm();
            hats.ShowDialog();
        }

        private void CollectiblesButton_Click(object sender, EventArgs e)
        {
            if (Program.CurrentSave == null) return;
            var collectibles = new CollectiblesForm();
            collectibles.ShowDialog();
        }
    }
}