using System;
using System.Windows.Forms;

namespace LibraryApp
{
    static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ��������� ����� MainForm ������ Form1
            Application.Run(new MainForm());
        }
    }
}
