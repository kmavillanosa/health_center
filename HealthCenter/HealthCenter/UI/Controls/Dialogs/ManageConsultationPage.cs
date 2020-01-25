using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter.UI
{
    public partial class ManageConsultationPage : UserControl, IDialog<Consultation>
    {
        public Consultation Data { get; set; }
        public Action BeforeSaveAction { get; set; }
        public IHealthCenterService HealthCenterService { get; }

        event EventHandler<CollectionLoadedEventArgs<IEnumerable<Ailments>>> OnAilmentsLoaded;


        public ManageConsultationPage(IHealthCenterService healthCenterService)
        {
            InitializeComponent();
            BeforeSaveAction = () => 
            {
                SetModelData();
            };

            OnAilmentsLoaded += ManageConsultationPage_OnAilmentsLoaded;
            HealthCenterService = healthCenterService;
        }

        private void ManageConsultationPage_OnAilmentsLoaded(object sender, CollectionLoadedEventArgs<IEnumerable<Ailments>> e)
        {
            ailmentCb.DataSource = e.Data;
            ailmentCb.DisplayMember = "Name";
            ailmentCb.ValueMember = "Id";
            ailmentCb.SelectedIndex = 0;
        }

        public async void GetModelData(Consultation data)
        {
            Data = data;

            var ailments = await HealthCenterService.GetAilments();
            OnAilmentsLoaded?.Invoke(this, new CollectionLoadedEventArgs<IEnumerable<Ailments>> { Data = ailments });
            Controls.OfType<RichTextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            RemarksTxt.DataBindings.Add("text", data, "Remarks");
            DiagnosisTxt.DataBindings.Add("text", data, "Diagnosis");

            cbgender.DataSource = Enum.GetNames(typeof(PersonGender));

        }

        public void SetModelData()
        {
            Data.AilmentGroupId = (int)ailmentCb.SelectedValue;

            Data.ExpectedChildGender = (PersonGender)Enum.Parse(typeof(PersonGender), cbgender.Text);
            Data.PregnancyDueDate = dueDateDtp.Value;
            Data.Weight = WeightTxt.Text;
            Data.Height = HeightTxt.Text;
            Data.BloodPressure = BpTxt.Text;


        }

        private void ManageConsultationPage_Load(object sender, EventArgs e)
        {

        }
    }
}
