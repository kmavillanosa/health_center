using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCenter.Events;

namespace HealthCenter.UI.Controls
{
    public partial class LoginView : UserControl , IPage
    {
        public event EventHandler<ControlChangedEventArgs<UserControl>> OnControlPageChanged;

        public LoginView(IHealthCenterService healthCenterService, 
            IAccountContextService accountContextService,
            IControlsFactory controlsFactory)
        {
            InitializeComponent();
            HealthCenterService = healthCenterService;
            AccountContextService = accountContextService;
            ControlsFactory = controlsFactory;
            OnControlPageChanged += LoginView_OnControlPageChanged;
        }

        private void LoginView_OnControlPageChanged(object sender, ControlChangedEventArgs<UserControl> e)
        {
            MainForm.Controls.Clear();
            e.CurrentControl.Dock = DockStyle.Fill;
            MainForm.Controls.Add(e.CurrentControl);
        }

        public IHealthCenterService HealthCenterService { get; }
        public IAccountContextService AccountContextService { get; }
        public IControlsFactory ControlsFactory { get; }
        public MainForm MainForm { get; }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private async void Login()
        {
            var data = await HealthCenterService.Login(txt_UserName.Text, Txt_Password.Text);
            if (data != null)
            {
                if (data.AccountStatus == AccountStatus.Active)
                {
                    var lastLogId = await HealthCenterService.CreateAccountLog(new AccountLogs { AccountId = data.Id });

                    
                    AccountContextService.SetAccount(data, lastLogId);

                    if(data.Type != AccountType.None)
                    {

                        ControlsFactory.ShellView.Controls.Clear();
                        var dd = ControlsFactory.Resolve<NavigationView>();
                        dd.Dock = DockStyle.Fill;
                        ControlsFactory.ShellView.Controls.Add(dd);
                    }
                }
                else
                {
                    MessageBox.Show("Account inactive.. please contact administrator","Access denied!");
                }
            }
            else
            {
                MessageBox.Show("Access denied", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnPageChanged(UserControl control)
        {
            OnControlPageChanged?.Invoke(this, new ControlChangedEventArgs<UserControl>
            { CurrentControl = control });
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            switch (seePwChk.Checked)
            {
                case true:
                    Txt_Password.UseSystemPasswordChar = false;
                    break;
                case false:
                    Txt_Password.UseSystemPasswordChar = true;
                    break;

                default:
                    Txt_Password.UseSystemPasswordChar = false;
                    break;
            }
        }

        private void LoginView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
