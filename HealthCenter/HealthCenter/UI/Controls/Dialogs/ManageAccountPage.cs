using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter
{
    public partial class ManageAccountPage : UserControl , IDialog<Account>
    {
        public ManageAccountPage()
        {
            InitializeComponent();
            BeforeSaveAction = () =>
            {
                SetModelData();
            };
        }

        public Account Data { get; set; }
        public Action BeforeSaveAction { get; set; }

        public void GetModelData(Account data)
        {
            Data = data;
            uname.Text = data.Username;
            pw.Text = data.Password;
        }

        public void SetModelData()
        {
            Data.Username = uname.Text;
            Data.Password = pw.Text;
            Data.AccountStatus = (AccountStatus)Enum.Parse(typeof(AccountStatus), cbStatus.Text);
            Data.Type = (AccountType)Enum.Parse(typeof(AccountType), CbAccessLevel.Text);
        }

        private void ManageAccountPage_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = Enum.GetNames(typeof(AccountStatus));
            cbStatus.Text = Data.AccountStatus.ToString();

            CbAccessLevel.DataSource = Enum.GetNames(typeof(AccountType));
            CbAccessLevel.Text = Data.Type.ToString();

        }
    }
}
