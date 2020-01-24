namespace HealthCenter
{
    partial class PersonSelectorPage
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
            this.dtgvPerson = new System.Windows.Forms.DataGridView();
            this.SelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPerson
            // 
            this.dtgvPerson.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtgvPerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvPerson.BackgroundColor = System.Drawing.Color.White;
            this.dtgvPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectBtn});
            this.dtgvPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvPerson.Location = new System.Drawing.Point(0, 0);
            this.dtgvPerson.MultiSelect = false;
            this.dtgvPerson.Name = "dtgvPerson";
            this.dtgvPerson.RowHeadersVisible = false;
            this.dtgvPerson.RowTemplate.Height = 30;
            this.dtgvPerson.RowTemplate.ReadOnly = true;
            this.dtgvPerson.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPerson.Size = new System.Drawing.Size(835, 606);
            this.dtgvPerson.TabIndex = 4;
            this.dtgvPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPerson_CellClick);
            // 
            // SelectBtn
            // 
            this.SelectBtn.Frozen = true;
            this.SelectBtn.HeaderText = "";
            this.SelectBtn.MinimumWidth = 60;
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.ReadOnly = true;
            this.SelectBtn.Text = "Select";
            this.SelectBtn.UseColumnTextForButtonValue = true;
            this.SelectBtn.Width = 60;
            // 
            // PersonSelectorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgvPerson);
            this.Name = "PersonSelectorPage";
            this.Size = new System.Drawing.Size(835, 606);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPerson;
        private System.Windows.Forms.DataGridViewButtonColumn SelectBtn;
    }
}
