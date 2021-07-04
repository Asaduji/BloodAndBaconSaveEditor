using System;
using System.Windows.Forms;
using BloodAndBaconSaveEditor.Forms;
using BloodAndBaconSaveEditor.Saves;

namespace BloodAndBaconSaveEditor
{
    internal static class Program
    {
        public static GameSave CurrentSave;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}