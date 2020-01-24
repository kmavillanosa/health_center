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
    public partial class ManageCategoryPage : UserControl, IDialog<PersonCategory>
    {
        public PersonCategory Data { get; set; }
        public Action BeforeSaveAction { get; set; }

        public ManageCategoryPage()
        {
            InitializeComponent();
            BeforeSaveAction = () =>
            {
                SetModelData();
            };
        }


        public void GetModelData(PersonCategory data)
        {
            Data = data;
            Controls.OfType<RichTextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            Controls.OfType<TextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            ValueTxt.DataBindings.Add("text", data, "Value");
            DescriptionTxt.DataBindings.Add("text", data, "Description");
        }

        public void SetModelData()
        {
            Data.Value = ValueTxt.Text;
            Data.Description = DescriptionTxt.Text;
        }
    }
}
