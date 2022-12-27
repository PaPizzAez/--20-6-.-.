using System;
using System.Windows.Forms;

namespace CurseH
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DiskMonitoring monitor = new DiskMonitoring();
            MainForm mainForm = new MainForm();
            MainPresenter presenter = new MainPresenter(mainForm, monitor);

            Application.Run(mainForm);

        }
    }
}
