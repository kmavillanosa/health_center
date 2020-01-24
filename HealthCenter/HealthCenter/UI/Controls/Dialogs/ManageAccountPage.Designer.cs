namespace HealthCenter
{
    partial class ManageAccountPage
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
            this.uname = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.CbAccessLevel = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uname.Location = new System.Drawing.Point(161, 119);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(334, 20);
            this.uname.TabIndex = 0;
            // 
            // pw
            // 
            this.pw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pw.Location = new System.Drawing.Point(161, 145);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(334, 20);
            this.pw.TabIndex = 1;
            // 
            // CbAccessLevel
            // 
            this.CbAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CbAccessLevel.FormattingEnabled = true;
            this.CbAccessLevel.Location = new System.Drawing.Point(161, 171);
            this.CbAccessLevel.Name = "CbAccessLevel";
            this.CbAccessLevel.Size = new System.Drawing.Size(334, 21);
            this.CbAccessLevel.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(161, 198);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(334, 21);
            this.cbStatus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Access level:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // ManageAccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.CbAccessLevel);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.uname);
            this.Name = "ManageAccountPage";
            this.Size = new System.Drawing.Size(590, 336);
            this.Load += new System.EventHandler(this.ManageAccountPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.ComboBox CbAccessLevel;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
