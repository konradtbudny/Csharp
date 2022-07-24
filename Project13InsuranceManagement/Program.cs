using System;
using System.Windows.Forms;
using Project13InsuranceManagement.Views;
using Project13InsuranceManagement.DataLayer;

using System.IO;

namespace Project13InsuranceManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            if (File.Exists(ObjectPlus.STORE_PATH))
            {
                ObjectPlus.Deserialize();
            }
            else
            {
                PopulateDB.Populate();
            }
            Application.ApplicationExit += (s, e) => ObjectPlus.Serialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
