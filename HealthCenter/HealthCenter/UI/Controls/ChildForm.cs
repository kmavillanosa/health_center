using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCenter.UI.Controls
{
    public partial class ChildForm : Form
    {

        public Action SaveAction { get; set; }
        public Panel ControlHandler { get; set; }
        public ChildForm()
        {
            InitializeComponent();
            ControlHandler = new Panel();
            ControlHandler.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(ControlHandler);

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            KeyDown += ChildForm_KeyDown;
        }

        private void ChildForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Escape:
                    DialogResult = DialogResult.Cancel;
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAction?.Invoke();
        }
    }
}
