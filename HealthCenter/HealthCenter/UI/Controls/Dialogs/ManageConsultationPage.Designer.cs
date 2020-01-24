namespace HealthCenter.UI
{
    partial class ManageConsultationPage
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
            this.ailmentCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DiagnosisTxt = new System.Windows.Forms.RichTextBox();
            this.RemarksTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ailmentCb
            // 
            this.ailmentCb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ailmentCb.FormattingEnabled = true;
            this.ailmentCb.Location = new System.Drawing.Point(114, 51);
            this.ailmentCb.Name = "ailmentCb";
            this.ailmentCb.Size = new System.Drawing.Size(309, 21);
            this.ailmentCb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ailment:";
            // 
            // DiagnosisTxt
            // 
            this.DiagnosisTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DiagnosisTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DiagnosisTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiagnosisTxt.Location = new System.Drawing.Point(114, 78);
            this.DiagnosisTxt.Name = "DiagnosisTxt";
            this.DiagnosisTxt.Size = new System.Drawing.Size(309, 96);
            this.DiagnosisTxt.TabIndex = 1;
            this.DiagnosisTxt.Text = "";
            // 
            // RemarksTxt
            // 
            this.RemarksTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemarksTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RemarksTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RemarksTxt.Location = new System.Drawing.Point(114, 180);
            this.RemarksTxt.Name = "RemarksTxt";
            this.RemarksTxt.Size = new System.Drawing.Size(309, 96);
            this.RemarksTxt.TabIndex = 2;
            this.RemarksTxt.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diagnosis:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remarks:";
            // 
            // ManageConsultationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemarksTxt);
            this.Controls.Add(this.DiagnosisTxt);
            this.Controls.Add(this.ailmentCb);
            this.Name = "ManageConsultationPage";
            this.Size = new System.Drawing.Size(510, 353);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DiagnosisTxt;
        private System.Windows.Forms.RichTextBox RemarksTxt;
        private System.Windows.Forms.ComboBox ailmentCb;
    }
}
