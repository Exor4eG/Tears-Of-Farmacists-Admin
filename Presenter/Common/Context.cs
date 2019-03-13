using Model;
using Presenter.Presenters;
using Presenter.Views;
using System;
using System.Windows.Forms;

namespace Presenter.Common
{
    public class Context : ApplicationContext
    {
        Data data = new Data();
        private Form preview = null;
        private Form main = null;
        Timer timer = new Timer();

        public Context(Form preview, Form main)
        {
            base.MainForm = preview;
            this.preview = preview;
            this.main = main;
            timer.Tick += new EventHandler(SplashTimeUp);
            new MainPresenter((IMainForm)main, data);
            timer.Interval = 6000;
            timer.Enabled = true;
        }

        private void SplashTimeUp(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();

            base.MainForm.Close();
        }
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is IPreview)
            {
                base.MainForm = main;
                base.MainForm.Show();
            }
            else if (sender is IMainForm)
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
