namespace SourceManagerMCMG
{
    partial class SourceManagerMCMG
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.downloadPb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL:";
            // 
            // tb_url
            // 
            this.tb_url.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tb_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.Location = new System.Drawing.Point(50, 26);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(243, 54);
            this.tb_url.TabIndex = 1;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.SystemColors.ControlDark;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Location = new System.Drawing.Point(301, 26);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 54);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // downloadPb
            // 
            this.downloadPb.Location = new System.Drawing.Point(301, 86);
            this.downloadPb.Name = "downloadPb";
            this.downloadPb.Size = new System.Drawing.Size(102, 23);
            this.downloadPb.TabIndex = 3;
            // 
            // SourceManagerMCMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(415, 116);
            this.Controls.Add(this.downloadPb);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SourceManagerMCMG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SourceManagerMCMG";
            this.Load += new System.EventHandler(this.SourceManagerMCMG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ProgressBar downloadPb;
    }
}

