using System;
using System.Threading;
using System.Windows.Forms;
using View.Forms;
using Presenter.Common;

namespace View
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
            using (Mutex myLock = new Mutex(false, "mydomain.com myprogramname"))
            {
                if (myLock.WaitOne(3000, false))
                {
                    ApplicationContext context = new Context(new Preview(), new MainForm());
                    Application.Run(context);
                }
                else
                {
                    MessageBox.Show("Программа уже запущена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
