﻿using System;
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
    public partial class OtherDetailsView : UserControl , IModule
    {
        public OtherDetailsView(IHealthCenterService healthCenterService,
            IControlsFactory controlsFactory)
        {
            InitializeComponent();
            HealthCenterService = healthCenterService;
            ControlsFactory = controlsFactory;
            GatherDetails();
        }

        public IHealthCenterService HealthCenterService { get; }
        public IControlsFactory ControlsFactory { get; }
        BindingSource AilmentListBinding { get; set; } = new BindingSource();
        BindingSource CategoryListBinding { get; set; } = new BindingSource();

        public async void GatherDetails()
        {
            var ailment = await HealthCenterService.GetAilments();
            var category = await HealthCenterService.GetPersonCategories();

            AilmentListBinding.DataSource = ailment.ToList();
            CategoryListBinding.DataSource = category.ToList();
            dtgvCategory.DataSource = CategoryListBinding;
            dtgvailment.DataSource = AilmentListBinding;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var pg = ControlsFactory.Resolve<ManageAilmentPage>();
            var data = new Ailments();
            pg.GetModelData(data);
            DialogActivator.OpenDialog(pg, "New Ailment",
                () =>
                {
                    HealthCenterService.CreateAilment(data);
                });
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            GatherDetails();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            GatherDetails();
        }

        private void dtgvailment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    var pg = ControlsFactory.Resolve<ManageAilmentPage>();
                    var data = (Ailments)AilmentListBinding.Current;
                    pg.GetModelData(data);
                    DialogActivator.OpenDialog(pg, "Modify Ailment",
                        () =>
                        {
                            HealthCenterService.ModifyAilment(data);
                        });
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var pg = ControlsFactory.Resolve<ManageCategoryPage>();
            var data = new PersonCategory();
            pg.GetModelData(data);
            DialogActivator.OpenDialog(pg, "New Category",
                () =>
                {
                    HealthCenterService.CreateCategory(data);
                });
        }

        private void dtgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    var pg = ControlsFactory.Resolve<ManageCategoryPage>();
                    var data = (PersonCategory)CategoryListBinding.Current;
                    pg.GetModelData(data);
                    DialogActivator.OpenDialog(pg, "Modify Category",
                        () =>
                        {
                            HealthCenterService.ModifyCategory(data);
                        });
                    break;
            }
        }
    }
}
