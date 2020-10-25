namespace UI.Forms.Impresion
{
    partial class printcompfrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.copiacb = new System.Windows.Forms.ComboBox();
            this.copialab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Forms.Impresion.compbte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(635, 301);
            this.reportViewer1.TabIndex = 0;
            // 
            // copiacb
            // 
            this.copiacb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copiacb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.copiacb.FormattingEnabled = true;
            this.copiacb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.copiacb.Location = new System.Drawing.Point(653, 42);
            this.copiacb.Name = "copiacb";
            this.copiacb.Size = new System.Drawing.Size(121, 21);
            this.copiacb.TabIndex = 2;
            this.copiacb.SelectedIndexChanged += new System.EventHandler(this.copiacb_SelectedIndexChanged);
            // 
            // copialab
            // 
            this.copialab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copialab.Location = new System.Drawing.Point(654, 13);
            this.copialab.Name = "copialab";
            this.copialab.Size = new System.Drawing.Size(100, 23);
            this.copialab.TabIndex = 3;
            this.copialab.Text = "label1";
            // 
            // printcompfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 326);
            this.Controls.Add(this.copialab);
            this.Controls.Add(this.copiacb);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "printcompfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir comprobante";
            this.Load += new System.EventHandler(this.printcompfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox copiacb;
        private System.Windows.Forms.Label copialab;
    }
}