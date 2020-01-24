using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HealthCenter
{
    /// <summary>
    /// Interaction logic for EventsView.xaml
    /// </summary>
    public partial class EventsView : UserControl , INotifyPropertyChanged  , IComponent
    {
        public Action<PersonEvents> UpdateAction { get; set; }
        public Action<PersonEvents> ViewAction { get; set; }
        public Action CreateAction { get; set; }
        public Action ExportAction { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<PersonEvents> Events { get { return _events; } set { _events = value; TriggerProp("Events"); } }
        private ObservableCollection<PersonEvents> _events;

        public IHealthCenterService HealthCenterService { get; }

        public EventsView(IHealthCenterService healthCenterService)
        {
            InitializeComponent();
            PropertyChanged += EventsView_PropertyChanged;
            HealthCenterService = healthCenterService;
        }

        private void TriggerProp(string property) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); }
        private void EventsView_PropertyChanged(object sender, PropertyChangedEventArgs e) { }


        public void LoadEvents(IEnumerable<PersonEvents> events)
        {
            Events = new ObservableCollection<PersonEvents>(events);
            EventItemsGrid.ItemsSource = events;

        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = await HealthCenterService.LoadEvents();
            LoadEvents(data);
        }

       
       

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateAction?.Invoke();
        }

      
        private void itemBorder_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var btn = (Border)sender;
            var data = (PersonEvents)btn.Tag;
            ViewAction?.Invoke(data);
        }

        private void ExportReportBtn_Click(object sender, RoutedEventArgs e)
        {
            ExportAction.Invoke();
        }

        private void EditBtn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var btn = (Border)sender;
            var data = (PersonEvents)btn.Tag;
            UpdateAction?.Invoke(data);
        }
    }
}
