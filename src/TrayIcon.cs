using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wakeeper
{
    public class TrayIcon
    {
        private NotifyIcon _notifyIcon;
        private Frm_Main _main;

        public TrayIcon(NotifyIcon notifyIcon, Frm_Main main)
        {
            _main = main;
            _notifyIcon = notifyIcon;
            _notifyIcon.Text = "Wakepper";
            _notifyIcon.Icon = new System.Drawing.Icon("icons/clock.ico");
            _notifyIcon.Visible = true;

            _notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            _notifyIcon.ContextMenuStrip.Items.Add("Configurações", Image.FromFile("icons/config.ico"), onConfigClicked);
            _notifyIcon.ContextMenuStrip.Items.Add("Sair", Image.FromFile("icons/clock.ico"), onExitClicked);
        }

        public void animateIcon()
        {
            _notifyIcon.Icon = new System.Drawing.Icon("icons/red-clock.ico");
            Thread.Sleep(1000);
            _notifyIcon.Icon = new System.Drawing.Icon("icons/clock.ico");
        }

        private void onConfigClicked(object? sender, EventArgs e)
        {
            _main.Show();
            _main.WindowState = FormWindowState.Normal;
        }

        private void onExitClicked(object? sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        public void Dispose()
        {
            _notifyIcon.Dispose();
        }
    }
}
