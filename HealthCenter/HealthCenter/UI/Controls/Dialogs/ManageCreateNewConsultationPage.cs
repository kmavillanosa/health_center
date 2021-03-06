﻿using System;
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
    public partial class ManageCreateNewConsultationPage : UserControl, IDialog<EventLogs>
    {
        event EventHandler<CollectionLoadedEventArgs<IEnumerable<Ailments>>> OnAilmentsLoaded;

        public Person CurrentPerson { get; set; }
        public Action BeforeSaveAction { get; set; }
        public IControlsFactory ControlsFactory { get; }
        public IHealthCenterService HealthCenterService { get; }
        public EventLogs Data { get; set; } = new EventLogs();
        public Consultation CurrentConsultation { get; set; } = new Consultation();


        public ManageCreateNewConsultationPage(IControlsFactory controlsFactory,IHealthCenterService healthCenterService)
        {
            InitializeComponent();


            ControlsFactory = controlsFactory;
            HealthCenterService = healthCenterService;

            BeforeSaveAction = () => 
            {
                SetModelData();
            };
            OnAilmentsLoaded += ManageConsultationPage_OnAilmentsLoaded;

            LoadData();
        }

        public void GetModelData(EventLogs data)
        {

        }

        public async void SetModelData()
        {
            try
            {
                int LastpersonId = 0;
                if (CurrentPerson.Id == 0)
                {
                    LastpersonId = await HealthCenterService.CreateProfile(CurrentPerson);
                }


                var consultation = new Consultation()
                {
                    PersonId = (LastpersonId != 0) ? LastpersonId : CurrentPerson.Id,
                    AilmentGroupId = (int)ailmentCb.SelectedValue,
                    Diagnosis = DiagnosisTxt.Text,
                    Remarks = RemarksTxt.Text,
                    ExpectedChildGender = (PersonGender)Enum.Parse(typeof(PersonGender), cbgender.Text),
                    PregnancyDueDate = dueDateDtp.Value,
                    Weight = WeightTxt.Text,
                    Height = HeightTxt.Text,
                    BloodPressure = BpTxt.Text
                };


                var lastConsultationId = await HealthCenterService.CreateMedicalConsultation(consultation);

                if (lastConsultationId != 0)
                {
                    Data = new EventLogs()
                    {
                        PersonId = (LastpersonId != 0) ? LastpersonId : CurrentPerson.Id,
                        ConsultationId = lastConsultationId,

                    };
                }

            }
            catch
            {

            }
           

        }


        private async void LoadData()
        {
            CurrentPerson = null;
            var ailments = await HealthCenterService.GetAilments();
            OnAilmentsLoaded?.Invoke(this, new CollectionLoadedEventArgs<IEnumerable<Ailments>> { Data = ailments });

            Controls.OfType<RichTextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            RemarksTxt.DataBindings.Add("text", CurrentConsultation, "Remarks");
            DiagnosisTxt.DataBindings.Add("text", CurrentConsultation, "Diagnosis");

            cbgender.DataSource = Enum.GetNames(typeof(PersonGender));
        }

        private void ManageConsultationPage_OnAilmentsLoaded(object sender, CollectionLoadedEventArgs<IEnumerable<Ailments>> e)
        {
            ailmentCb.DataSource = e.Data;
            ailmentCb.DisplayMember = "Name";
            ailmentCb.ValueMember = "Id";
            ailmentCb.SelectedIndex = 0;
        }


   

        private void button2_Click(object sender, EventArgs e)
        {
            var currentpage = ControlsFactory.Resolve<PersonSelectorPage>();
            DialogActivator.OpenDialog(currentpage, "Select patient", AllowButtons: false, saveCallBack: () =>
            {
                CurrentPerson = currentpage.Data;
                propertyGrid1.SelectedObject = CurrentPerson;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var currentpage = ControlsFactory.Resolve<ManagePersonPage>();
            DialogActivator.OpenDialog(currentpage, "Create patient",  saveCallBack: () =>
            {
                CurrentPerson = currentpage.Data;
                propertyGrid1.SelectedObject = CurrentPerson;
            });
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ailmentCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
