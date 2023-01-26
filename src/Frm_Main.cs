using System.ComponentModel;

namespace wakeeper
{
    public partial class Frm_Main : Form
    {
        private int idleTimeout;
        private readonly TrayIcon _trayIcon;
        private readonly IdleDetector _idleDetector;
        private readonly ConfigManager _config;

        public Frm_Main()
        {
            InitializeComponent();
            this.Visible= false;
            _trayIcon = new TrayIcon(new NotifyIcon(), this);
            _idleDetector = new IdleDetector();
            _config = new ConfigManager("config.yml");
        }
        private void Frm_Main_Load(object sender, EventArgs e)
        {
            _config.Load();
            this.idleTimeout = int.Parse(_config.GetValue("idleTimeout"));
            textBoxIdleTimeout.Text = _config.GetValue("idleTimeout");
            System.Windows.Forms.Timer checkIdleTimer = new System.Windows.Forms.Timer();   
            checkIdleTimer.Interval = 999;
            checkIdleTimer.Tick += new EventHandler(checkIdleTimer_Tick);
            checkIdleTimer.Start();
        }

        private void checkIdleTimer_Tick(object? sender, System.EventArgs e)
        {
            if (_idleDetector.getIdleTime() >= this.idleTimeout)
            {
                SendKeys.Send("^");
                _trayIcon.animateIcon();
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _config.SetValue("idleTimeout", textBoxIdleTimeout.Text);
            _config.Save();
            _trayIcon.Dispose();
            Application.Restart();
        }

        private void onConfigClicked(object? sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void Frm_Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            base.OnClosing(e);
        }

        private void Frm_Main_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}