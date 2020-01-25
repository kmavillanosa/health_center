using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter.UI.Controls.Dialogs
{
    public partial class ForgotPassword : Form , IDialog
    {
        public Action BeforeSaveAction { get; set; }

        public ForgotPassword(IHealthCenterService healthCenterService)
        {
            InitializeComponent();
            HealthCenterService = healthCenterService;
        }

        public IHealthCenterService HealthCenterService { get; }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var password = await HealthCenterService.GetPassword(textBox1.Text);
            label2.Text = password;
        }
    }
}
