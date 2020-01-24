namespace HealthCenter
{
    partial class ManageEventsPage
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.TitleTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionText.Location = new System.Drawing.Point(103, 159);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(309, 96);
            this.DescriptionText.TabIndex = 7;
            this.DescriptionText.Text = "";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTxt.Location = new System.Drawing.Point(103, 57);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(309, 96);
            this.TitleTxt.TabIndex = 6;
            this.TitleTxt.Text = "";
            // 
            // ManageEventsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.TitleTxt);
            this.Name = "ManageEventsPage";
            this.Size = new System.Drawing.Size(486, 307);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.RichTextBox TitleTxt;
    }
}
