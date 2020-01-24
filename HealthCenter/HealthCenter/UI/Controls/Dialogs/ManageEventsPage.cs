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
    public partial class ManageEventsPage : UserControl, IDialog<PersonEvents>
    {
        public ManageEventsPage()
        {
            InitializeComponent();
            BeforeSaveAction = () =>
            {
                SetModelData();
            };
        }

        public PersonEvents Data { get; set; }
        public Action BeforeSaveAction { get; set; }

        public void GetModelData(PersonEvents data)
        {
            Data = data;
            Controls.OfType<RichTextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            TitleTxt.DataBindings.Add("text", data, "Title");
            DescriptionText.DataBindings.Add("text", data, "Description");
        }

        public void SetModelData()
        {

        }
    }
}
