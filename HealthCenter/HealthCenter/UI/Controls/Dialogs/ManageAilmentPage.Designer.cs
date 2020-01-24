namespace HealthCenter
{
    partial class ManageAilmentPage
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTxt.Location = new System.Drawing.Point(138, 147);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(309, 20);
            this.nameTxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description:";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTxt.Location = new System.Drawing.Point(138, 173);
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(309, 96);
            this.DescriptionTxt.TabIndex = 6;
            this.DescriptionTxt.Text = "";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // ManageAilmentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.nameTxt);
            this.Name = "ManageAilmentPage";
            this.Size = new System.Drawing.Size(568, 434);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DescriptionTxt;
        private System.Windows.Forms.Label label1;
    }
}
