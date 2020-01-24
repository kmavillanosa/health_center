namespace HealthCenter.UI.Controls.Modules
{
    partial class AccountsView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsView));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtgvAcc = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dtgvlogs = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlogs)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtgvAcc);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtgvlogs);
            this.splitContainer1.Size = new System.Drawing.Size(1044, 744);
            this.splitContainer1.SplitterDistance = 658;
            this.splitContainer1.TabIndex = 0;
            // 
            // dtgvAcc
            // 
            this.dtgvAcc.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvAcc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvAcc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvAcc.BackgroundColor = System.Drawing.Color.White;
            this.dtgvAcc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvAcc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAcc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.EditBtn});
            this.dtgvAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvAcc.Location = new System.Drawing.Point(0, 25);
            this.dtgvAcc.MultiSelect = false;
            this.dtgvAcc.Name = "dtgvAcc";
            this.dtgvAcc.RowHeadersVisible = false;
            this.dtgvAcc.RowTemplate.Height = 30;
            this.dtgvAcc.RowTemplate.ReadOnly = true;
            this.dtgvAcc.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvAcc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvAcc.Size = new System.Drawing.Size(658, 719);
            this.dtgvAcc.TabIndex = 4;
            this.dtgvAcc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAcc_CellClick);
            // 
            // View
            // 
            this.View.Frozen = true;
            this.View.HeaderText = "";
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Text = "View details";
            this.View.UseColumnTextForButtonValue = true;
            this.View.Width = 5;
            // 
            // EditBtn
            // 
            this.EditBtn.Frozen = true;
            this.EditBtn.HeaderText = "";
            this.EditBtn.MinimumWidth = 60;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.ReadOnly = true;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseColumnTextForButtonValue = true;
            this.EditBtn.Width = 60;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(658, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dtgvlogs
            // 
            this.dtgvlogs.AllowUserToAddRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvlogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvlogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvlogs.BackgroundColor = System.Drawing.Color.White;
            this.dtgvlogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvlogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvlogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvlogs.Location = new System.Drawing.Point(0, 0);
            this.dtgvlogs.MultiSelect = false;
            this.dtgvlogs.Name = "dtgvlogs";
            this.dtgvlogs.RowHeadersVisible = false;
            this.dtgvlogs.RowTemplate.Height = 30;
            this.dtgvlogs.RowTemplate.ReadOnly = true;
            this.dtgvlogs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvlogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvlogs.Size = new System.Drawing.Size(382, 744);
            this.dtgvlogs.TabIndex = 5;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Add account";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton2.Text = "Refresh";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // AccountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AccountsView";
            this.Size = new System.Drawing.Size(1044, 744);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAcc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvlogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgvAcc;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewButtonColumn EditBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dtgvlogs;
    }
}
