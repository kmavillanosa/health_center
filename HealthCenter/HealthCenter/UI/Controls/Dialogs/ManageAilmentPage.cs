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
    public partial class ManageAilmentPage : UserControl , IDialog<Ailments>
    {
        public Ailments Data { get; set; }
        public Action BeforeSaveAction { get; set; }

        public ManageAilmentPage()
        {
            InitializeComponent();
            BeforeSaveAction = () =>
            {
                SetModelData();
            };
        }

       
        public void GetModelData(Ailments data)
        {
            Data = data;
            Controls.OfType<RichTextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            Controls.OfType<TextBox>().ToList().ForEach(x => x.DataBindings.Clear());
            nameTxt.DataBindings.Add("text", data, "Name");
            DescriptionTxt.DataBindings.Add("text", data, "Description");
        }

        public void SetModelData()
        {
            Data.Name = nameTxt.Text;
            Data.Description = DescriptionTxt.Text;
        }
    }
}
