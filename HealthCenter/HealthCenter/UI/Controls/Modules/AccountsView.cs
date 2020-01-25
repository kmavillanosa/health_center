using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter.UI.Controls.Modules
{
    public partial class AccountsView : UserControl , IModule
    {
        public AccountType AccountType { get; set; }

        public IHealthCenterService HealthCenterService { get; }
        public IControlsFactory ControlsFactory { get; }
        public IAccessTypeHandler AccessTypeHandler { get; }
        private BindingSource AccountListBinding { get; set; } = new BindingSource();
        private BindingSource AccountLogsListBinding { get; set; } = new BindingSource();
        private event EventHandler<CollectionLoadedEventArgs<List<Account>>> OnAccountsCollectionLoaded;
        public AccountsView(IHealthCenterService healthCenterService, IControlsFactory controlsFactory, IAccessTypeHandler accessTypeHandler)
        {
            InitializeComponent();
            OnAccountsCollectionLoaded += AccountsView_OnAccountsCollectionLoaded;
            HealthCenterService = healthCenterService;
            ControlsFactory = controlsFactory;
            AccessTypeHandler = accessTypeHandler;
            InitializeData();
        }

        private async void InitializeData()
        {
            var data = await HealthCenterService.GetAccounts();
            OnAccountsCollectionLoaded(this, new CollectionLoadedEventArgs<List<Account>>() { Data = data.ToList() });

        }

        private void AccountsView_OnAccountsCollectionLoaded(object sender, CollectionLoadedEventArgs<List<Account>> e)
        {
            AccountListBinding.DataSource = e.Data;
            dtgvAcc.DataSource = AccountListBinding;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var pg = ControlsFactory.Resolve<ManageAccountPage>();
            var data = new Account();
            pg.GetModelData(data);
            DialogActivator.OpenDialog(pg, "New account detail",
                () =>
                {
                    HealthCenterService.CreateAccount(data);
                });
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InitializeData();
        }

        private void dtgvAcc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (Account)AccountListBinding.Current;

            switch (e.ColumnIndex)
            {
                case 0:
                    AccountLogsListBinding.DataSource = data.Logs.ToList();
                    dtgvlogs.DataSource = AccountLogsListBinding;
                    break;
                case 1:
                    var pg = ControlsFactory.Resolve<ManageAccountPage>();
                    pg.GetModelData(data);
                    DialogActivator.OpenDialog(pg, "New account detail",
                        () =>
                        {
                            HealthCenterService.ModifyAccount(data);
                        });
                    break;
            }
        }

        public void Revalidate()
        {

        }
    }
}
