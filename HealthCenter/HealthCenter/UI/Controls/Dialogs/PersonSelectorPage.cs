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
    public partial class PersonSelectorPage : UserControl , IDialog<Person>
    {
        BindingSource PersonListBinding = new BindingSource();
        public PersonSelectorPage(IHealthCenterService healthCenterService)
        {
            InitializeComponent();
            HealthCenterService = healthCenterService;
            LoadData();
        }

        public Person Data { get; set; }
        public Action BeforeSaveAction { get; set; }
        public IHealthCenterService HealthCenterService { get; }

        private async void LoadData()
        {
            var data = await HealthCenterService.GetPeopleList();
            PersonListBinding.DataSource = data;
            dtgvPerson.DataSource = PersonListBinding;
        }

        public void GetModelData(Person data)
        {

        }

        public void SetModelData()
        {

        }

        private void dtgvPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    var dialog = MessageBox.Show("Are you sure?", "Select person", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        Data = (Person)PersonListBinding.Current;
                        this.ParentForm.DialogResult = DialogResult.OK;
                    }
                    break;
            }
        }
    }
}
