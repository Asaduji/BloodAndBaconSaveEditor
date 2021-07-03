using System;
using System.Windows.Forms;
using BloodAndBaconSaveEditor.Forms;
using BloodAndBaconSaveEditor.Saves;

namespace BloodAndBaconSaveEditor
{
    static class Program
    {
        public static GameSave CurrentSave;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}