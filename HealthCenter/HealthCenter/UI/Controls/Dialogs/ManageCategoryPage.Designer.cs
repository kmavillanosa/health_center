namespace HealthCenter
{
    partial class ManageCategoryPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.ValueTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Value:";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTxt.Location = new System.Drawing.Point(123, 171);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(309, 96);
            this.DescriptionTxt.TabIndex = 10;
            this.DescriptionTxt.Text = "";
            // 
            // ValueTxt
            // 
            this.ValueTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ValueTxt.Location = new System.Drawing.Point(123, 145);
            this.ValueTxt.Name = "ValueTxt";
            this.ValueTxt.Size = new System.Drawing.Size(309, 20);
            this.ValueTxt.TabIndex = 9;
            // 
            // ManageCategoryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.ValueTxt);
            this.Name = "ManageCategoryPage";
            this.Size = new System.Drawing.Size(543, 458);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DescriptionTxt;
        private System.Windows.Forms.TextBox ValueTxt;
    }
}
