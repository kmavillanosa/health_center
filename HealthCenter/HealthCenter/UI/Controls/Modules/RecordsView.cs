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
    public partial class RecordsView : UserControl ,IModule
    {
        public AccountType AccountType { get; set; }
        
        private BindingSource PersonListBinding = new BindingSource();
        private BindingSource ConsultationListBinding = new BindingSource();
        List<Person> PersonList = new List<Person>();

        public event EventHandler<CollectionLoadedEventArgs<IEnumerable<Person>>> OnPersonCollectionLoaded;
        public IHealthCenterService HealthCenterService { get; }
        public IAccessTypeHandler AccessTypeHandler { get; }
        public IControlsFactory ControlsFactory { get; }

        public RecordsView(IHealthCenterService healthCenterService,
            IAccessTypeHandler accessTypeHandler,
            IControlsFactory controlsFactory)
        {
            InitializeComponent();
            HealthCenterService = healthCenterService;
            AccessTypeHandler = accessTypeHandler;
            ControlsFactory = controlsFactory;
            OnPersonCollectionLoaded += RecordsView_OnPersonCollectionLoaded;
        }

        private async void LoadData()
        {
            var data = await HealthCenterService.GetPeopleList();
            OnPersonCollectionLoaded(this, new CollectionLoadedEventArgs<IEnumerable<Person>> { Data = data });
        }

        private void RecordsView_OnPersonCollectionLoaded(object sender, CollectionLoadedEventArgs<IEnumerable<Person>> e)
        {
            PersonListBinding.DataSource = e.Data;
            PersonList = e.Data.ToList();
            dtgvPerson.DataSource = PersonListBinding;

            if(AccessTypeHandler.Type == AccountType.Guest)
            {
                button1.Enabled = false;
                CreateBtn.Enabled = false;
                toolStripButton1.Enabled = false;


                dtgvPerson.Columns[1].Visible = false;
                dtgvPerson.Columns[2].Visible = false;
                dtgvConsultations.Columns[0].Visible = false;



                  //.Where(dtgv => dtgv.Tag.ToString() == "GridForRestriction");
                  //.Select(dtg => dtg.Columns).ToList()
                  //      .ForEach(col => col.OfType<DataGridViewButtonColumn>()
                  //      .ToList()
                  //      .ForEach(cc => { cc.Visible = false; }));


            }
        }

        private void RecordsView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                e.CellStyle.ForeColor = ColorTranslator.FromHtml("#212121");
                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Underline | FontStyle.Bold);
            }
            if(e.Value != null && e.Value.GetType() == typeof(PersonGender))
            {
                e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                var data = (PersonGender)e.Value;
                switch (data)
                {
                    case PersonGender.Female:
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#E91E63");
                        break;
                    case PersonGender.Male:
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("#1E88E5");
                        break;
                    case PersonGender.NotDefined:
                        e.CellStyle.ForeColor = ColorTranslator.FromHtml("Dimgray");
                        break;
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTxt.Text))
            {
                LoadData();
            }
            else
            {
                var temp = PersonList.FindAll(x => x.FullName.ToLower().Contains(searchTxt.Text.ToLower()));
                PersonListBinding.DataSource = temp;
                dtgvPerson.DataSource = PersonListBinding;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (Person)PersonListBinding.Current;
            switch (e.ColumnIndex)
            {
                case 0:
                    ConsultationListBinding.DataSource = data.Consultations.ToList();
                    dtgvConsultations.DataSource = ConsultationListBinding;
                    propertyGrid1.SelectedObject = data;

                    break;
                case 1:
                    var pg = ControlsFactory.Resolve<ManagePersonPage>();
                    pg.GetModelData(data);
                    DialogActivator.OpenDialog(pg, $"Edit person detail: {data.FullName}.",
                        () =>
                        {
                            HealthCenterService.ModifyProfile(data);
                        });
                    break;
                case 2:
                    ExcelReports.GeneratePersonReport(data);
                    break;
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var pg = ControlsFactory.Resolve<ManagePersonPage>();
            var data = new Person();
            pg.GetModelData(data);
            DialogActivator.OpenDialog(pg, "New person detail",
                () => 
                {
                    HealthCenterService.CreateProfile(data);
                });
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var person = (Person)PersonListBinding.Current;

            var pg = ControlsFactory.Resolve<ManageConsultationPage>();
            var data = new Consultation() { PersonId = person.Id };
           

            pg.GetModelData(data);
            DialogActivator.OpenDialog(pg, "New medical consultation",
             async () =>
             {
                 await HealthCenterService.CreateMedicalConsultation(data);
             });
        }

        private void dtgvConsultations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var person = (Person)PersonListBinding.Current;
            var data = (Consultation)ConsultationListBinding.Current;
            switch (e.ColumnIndex)
            {
                case 0:
                    var pg = ControlsFactory.Resolve<ManageConsultationPage>();
                    pg.GetModelData(data);
                    DialogActivator.OpenDialog(pg, $"Edit medical consultation {person.FullName}",
                    async () =>
                    {
                        await HealthCenterService.ModifyMedicalConsultation(data);
                    });
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
