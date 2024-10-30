using System;
using System.Windows.Forms;

namespace LibraryApp
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

            // Запускаем форму MainForm вместо Form1
            Application.Run(new MainForm());
        }
    }
}
