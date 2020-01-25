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
    public partial class ManagePersonPage : UserControl, IDialog<Person>
    {
        public Action BeforeSaveAction { get; set; }
        public Person Data { get; set; } = new Person();
        public IHealthCenterService HealthCenterService { get; }

        public ManagePersonPage(IHealthCenterService healthCenterService)
        {
            InitializeComponent();
            BeforeSaveAction = () => 
            {
                SetModelData();
            };
            HealthCenterService = healthCenterService;
        }


        public void GetModelData(Person data = null)
        {
            Data = data;
            if (data.BirthDate == default(DateTime))
            {
                data.BirthDate = DateTime.Now;
                dtpbday.Value = data.BirthDate.Value;
            }
            Controls.OfType<TextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            Controls.OfType<RichTextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            txtfname.DataBindings.Add("text", data, "FirstName");
            txtlname.DataBindings.Add("text", data, "LastName");
            txtmname.DataBindings.Add("text", data, "MiddleName");
            AddressTxt.DataBindings.Add("text", data, "Address");
            txtsuffix.DataBindings.Add("text", data, "Suffix");
            txtSpouseName.DataBindings.Add("text", data, "CivilPartnerName");



        }

        public void SetModelData()
        {
            if (dtpbday.Checked)
            {
                Data.BirthDate = dtpbday.Value;
            }
            else
            {
                Data.BirthDate = null;
            }
            Data.CategoryId = (int)cbcategory.SelectedValue;
            Data.Gender = (PersonGender)Enum.Parse(typeof(PersonGender), cbgender.Text);
            Data.CivilStatus = (CivilStatus)Enum.Parse(typeof(CivilStatus), cvCb.Text);
            Data.FirstName = txtfname.Text;
            Data.LastName = txtlname.Text;
            Data.MiddleName = txtmname.Text;
            Data.Address = AddressTxt.Text;
            Data.Suffix = txtsuffix.Text;
            Data.CivilPartnerName = txtSpouseName.Text;


        }

        private async void ManagePersonPage_Load(object sender, EventArgs e)
        {
            if(Data != null)
            {
                var data = await HealthCenterService.GetPersonCategories();
                cbcategory.DataSource = data;
                cbcategory.DisplayMember = "Value";
                cbcategory.ValueMember = "Id";

                cbcategory.SelectedValue = Data.CategoryId;

                cvCb.DataSource = Enum.GetNames(typeof(CivilStatus));
                cvCb.Text = Data.CivilStatus.ToString();

                cbgender.DataSource = Enum.GetNames(typeof(PersonGender));
                cbgender.Text = Data.Gender.ToString();
            }

        }
    }
}
