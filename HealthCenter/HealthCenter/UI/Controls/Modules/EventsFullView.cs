using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Configurations;

namespace HealthCenter.UI.Controls.Modules
{
    public partial class EventsFullView : UserControl, IModule
    {
        public AccountType AccountType { get; set; }

        BindingSource EventLogBinding = new BindingSource();
        List<PersonEvents> EventList { get; set; } = new List<PersonEvents>();
        public EventsFullView(IHealthCenterService healthCenterService,
            IAccessTypeHandler accessTypeHandler,
            IControlsFactory controlsFactory)
        {
            InitializeComponent();
            HealthCenterService = healthCenterService;
            AccessTypeHandler = accessTypeHandler;
            ControlsFactory = controlsFactory;
            Load += EventsFullView_Load;
        }

        private void EventsFullView_Load(object sender, EventArgs e)
        {
            LoadDetails();

            if (AccessTypeHandler.Type == AccountType.Guest)
            {
                toolStripButton1.Enabled = false;
            }

        }
        public PersonEvents CurrentEvent { get; set; }
        public IHealthCenterService HealthCenterService { get; }
        public IAccessTypeHandler AccessTypeHandler { get; }
        public IControlsFactory ControlsFactory { get; }

        private void LoadEventParticipantChart()
        {

         

            DetailChart.Series.Clear();
            DetailChart.AxisX.Clear();
            DetailChart.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Participant count",
                    Values = new ChartValues<double>(EventList.Select(x=> Convert.ToDouble(x.PersonCount)).ToList())
                }

            };

            DetailChart.AxisX.Add(new Axis()
            {
                Title = "Event participants",
                Labels = EventList.Select(x => x.Title).ToArray(),
                Separator = new Separator // force the separator step to 1, so it always display all labels
                {
                    Step = 1,
                    IsEnabled = false //disable it to make it invisible.
                },
            });

            DetailChart.AxisX[0].ShowLabels = true;

        }

        private async void LoadEventPersonCategoriesChart()
        {
            CategoryChart.Series.Clear();
            CategoryChart.AxisX.Clear();


            var categoryPerEvents = await HealthCenterService.GetCategoriesPerEvent();
            var set = new SeriesCollection();


            foreach (var item in categoryPerEvents)
            {
                try
                {
                    set.Add(new ColumnSeries
                    {
                        Name = item.Title,
                        Title = $"{item.Category}",
                        Values = new ChartValues<double> { item.Count },

                    });

                }
                catch
                {

                }
               
            }
            CategoryChart.Series = set;

            CategoryChart.AxisX.Add(new Axis
            {
                Title = "Categories per event"
            });

            CategoryChart.LegendLocation = LegendLocation.Bottom;

            //   CategoryChart.Series.Add();
        }


        private async void LoadDetails()
        {
            var control = ControlsFactory.ResolveWpfControl<EventsView>();
            elementHost1.Child = control;

            var data = await HealthCenterService.LoadEvents();
            EventList = data.ToList();

            control.ExportAction = () =>
            {
                ExcelReports.GenerateEventParticipants(EventList);
            };

            control.ExportSingleAction = (ev) =>
            {
                ExcelReports.GemerateParticipantEvent(ev);
            };

            control.ViewAction = (obj) =>
            {
                CurrentEvent = obj;
                EventLogBinding.DataSource = obj.Logs.ToList();
                dtgvPersonevents.DataSource = EventLogBinding;
            };


            control.CreateAction = () =>
            {
                var pg = ControlsFactory.Resolve<ManageEventsPage>();
                var currentevent = new PersonEvents();
                pg.GetModelData(currentevent);
                DialogActivator.OpenDialog(pg, $"New event", () =>
                {
                    HealthCenterService.CreateEvent(currentevent);
                    LoadDetails();
                });
            };

            control.UpdateAction = (obj) =>
            {
                var pg = ControlsFactory.Resolve<ManageEventsPage>();
                var currentevent = obj;
                pg.GetModelData(currentevent);
                DialogActivator.OpenDialog(pg, $"Update event {obj.Title}", () =>
                {
                    HealthCenterService.ModifyEvent(currentevent);
                    LoadDetails();
                });
            };


        
            control.LoadEvents(data);

            LoadEventParticipantChart();
            LoadEventPersonCategoriesChart();
        }

        private void dtgvPersonevents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (EventLogs)EventLogBinding.Current;
            propertyGrid1.SelectedObject = data;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var pg = ControlsFactory.Resolve<ManageCreateNewConsultationPage>();

            DialogActivator.OpenDialog(pg, $"New participant", async () =>
            {
                pg.Data.Event = CurrentEvent.Id;
                await HealthCenterService.CreateEventLogs(pg.Data);

                LoadDetails();
            });
        }

        public void Revalidate()
        {

        }
    }
}
