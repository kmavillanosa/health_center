using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCenter.UI.Controls.Modules;
using HealthCenter.Events;

namespace HealthCenter.UI.Controls
{
    public partial class NavigationView : UserControl, IPage
    {
        public AccountType AccountType { get; set; } = AccountType.None;
        private IControlsFactory ControlsFactory { get; }
        public IAccountContextService AccountContextService { get; }
        public IHealthCenterService HealthCenterService { get; }
        public IAccessTypeHandler AccessTypeHandler { get; }

        public event EventHandler<ControlChangedEventArgs<UserControl>> OnUserControlChanged;
        public NavigationView(IControlsFactory controlsFactory,
            IAccountContextService accountContextService,
            IHealthCenterService healthCenterService,
            IAccessTypeHandler accessTypeHandler)
        {
            InitializeComponent();

            ControlsFactory = controlsFactory;
            AccountContextService = accountContextService;
            HealthCenterService = healthCenterService;
            AccessTypeHandler = accessTypeHandler;
            var records = ControlsFactory.Resolve<RecordsView>();
            OnUserControlChanged += NavigationView_OnUserControlChanged;


        }

        private void NavigationView_OnUserControlChanged(object sender, ControlChangedEventArgs<UserControl> e)
        {
            ModulePanel.Controls.Clear();
            e.CurrentControl.Dock = DockStyle.Fill;
            ModulePanel.Controls.Add(e.CurrentControl);


            if (AccessTypeHandler.Type != AccountType.Administrator)
            {
                button3.Enabled = false;
                button3.Text = "Account Restricted";
                button3.Visible = false;
            }

        }

        public void OnControlChanged(UserControl control)
        {

            OnUserControlChanged?.Invoke(this, new ControlChangedEventArgs<UserControl> { CurrentControl = control });
        }


        public void GotoRecords()
        {
            CurrentViewLbl.Text = "Records";
            var data = ControlsFactory.Resolve<RecordsView>();
            OnControlChanged(data);
        }

        public void GotoEvents()
        {
            CurrentViewLbl.Text = "Events";
            var data = ControlsFactory.Resolve<EventsFullView>();
            OnControlChanged(data);
        }

        public void GotoAccounts()
        {
            CurrentViewLbl.Text = "Accounts";
            var data = ControlsFactory.Resolve<AccountsView>();
            OnControlChanged(data);
        }
        public void GotoOtherDetailsView()
        {
            CurrentViewLbl.Text = "Other details";
            var data = ControlsFactory.Resolve<OtherDetailsView>();
            OnControlChanged(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GotoRecords();
        }

        private void NavigationView_Load(object sender, EventArgs e)
        {
            GotoRecords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GotoEvents();
        }

        private async void button5_Click(object sender, EventArgs e)
        {

            ControlsFactory.ShellView.Controls.Clear();
            var loginview = ControlsFactory.Resolve<LoginView>();
            loginview.Dock = DockStyle.Fill;
            ControlsFactory.ShellView.Controls.Add(loginview);
            await HealthCenterService.SetLogoutTime(AccountContextService.LastLogId, DateTime.Now);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GotoOtherDetailsView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GotoAccounts();
        }
    }
}
