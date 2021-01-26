using System.Windows.Forms;
using Language;

namespace UI.Stock
{
    partial class Scaneofrm
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
            this.receiptlab = new System.Windows.Forms.Label();
            this.receiptcb = new System.Windows.Forms.ComboBox();
            this.reasonlab = new System.Windows.Forms.Label();
            this.reasoncb = new System.Windows.Forms.ComboBox();
            this.completecb = new System.Windows.Forms.CheckBox();
            this.maindg = new System.Windows.Forms.DataGridView();
            this.scandg = new System.Windows.Forms.DataGridView();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pcbtn = new System.Windows.Forms.Button();
            this.dcbtn = new System.Windows.Forms.Button();
            this.receiptdg = new System.Windows.Forms.DataGridView();
            this.movdg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scandg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movdg)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptlab
            // 
            this.receiptlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptlab.ForeColor = System.Drawing.Color.White;
            this.receiptlab.Location = new System.Drawing.Point(55, 9);
            this.receiptlab.Name = "receiptlab";
            this.receiptlab.Size = new System.Drawing.Size(124, 23);
            this.receiptlab.TabIndex = 0;
            this.receiptlab.Text = "Comprobante";
            // 
            // receiptcb
            // 
            this.receiptcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptcb.FormattingEnabled = true;
            this.receiptcb.Location = new System.Drawing.Point(185, 6);
            this.receiptcb.Name = "receiptcb";
            this.receiptcb.Size = new System.Drawing.Size(121, 29);
            this.receiptcb.TabIndex = 1;
            // 
            // reasonlab
            // 
            this.reasonlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonlab.ForeColor = System.Drawing.Color.White;
            this.reasonlab.Location = new System.Drawing.Point(322, 9);
            this.reasonlab.Name = "reasonlab";
            this.reasonlab.Size = new System.Drawing.Size(76, 23);
            this.reasonlab.TabIndex = 2;
            this.reasonlab.Text = "Motivo";
            // 
            // reasoncb
            // 
            this.reasoncb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reasoncb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reasoncb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasoncb.FormattingEnabled = true;
            this.reasoncb.Location = new System.Drawing.Point(404, 6);
            this.reasoncb.Name = "reasoncb";
            this.reasoncb.Size = new System.Drawing.Size(121, 29);
            this.reasoncb.TabIndex = 3;
            // 
            // completecb
            // 
            this.completecb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completecb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completecb.ForeColor = System.Drawing.Color.White;
            this.completecb.Location = new System.Drawing.Point(531, 8);
            this.completecb.Name = "completecb";
            this.completecb.Size = new System.Drawing.Size(195, 24);
            this.completecb.TabIndex = 4;
            this.completecb.Text = "CompletarCantidad";
            this.completecb.UseVisualStyleBackColor = true;
            // 
            // maindg
            // 
            this.maindg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maindg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindg.Location = new System.Drawing.Point(12, 114);
            this.maindg.Name = "maindg";
            this.maindg.Size = new System.Drawing.Size(594, 444);
            this.maindg.TabIndex = 5;
            // 
            // scandg
            // 
            this.scandg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scandg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scandg.Location = new System.Drawing.Point(619, 54);
            this.scandg.Name = "scandg";
            this.scandg.Size = new System.Drawing.Size(303, 136);
            this.scandg.TabIndex = 6;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(12, 54);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(594, 53);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // pcbtn
            // 
            this.pcbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbtn.FlatAppearance.BorderSize = 0;
            this.pcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pcbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcbtn.ForeColor = System.Drawing.Color.White;
            this.pcbtn.Location = new System.Drawing.Point(619, 524);
            this.pcbtn.Name = "pcbtn";
            this.pcbtn.Size = new System.Drawing.Size(150, 34);
            this.pcbtn.TabIndex = 10;
            this.pcbtn.Text = "Cierre Parcial";
            this.pcbtn.UseVisualStyleBackColor = true;
            // 
            // dcbtn
            // 
            this.dcbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dcbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dcbtn.FlatAppearance.BorderSize = 0;
            this.dcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dcbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcbtn.ForeColor = System.Drawing.Color.White;
            this.dcbtn.Location = new System.Drawing.Point(772, 524);
            this.dcbtn.Name = "dcbtn";
            this.dcbtn.Size = new System.Drawing.Size(150, 34);
            this.dcbtn.TabIndex = 11;
            this.dcbtn.Text = "Cierre Definitivo";
            this.dcbtn.UseVisualStyleBackColor = true;
            // 
            // receiptdg
            // 
            this.receiptdg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receiptdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptdg.Location = new System.Drawing.Point(619, 214);
            this.receiptdg.Name = "receiptdg";
            this.receiptdg.Size = new System.Drawing.Size(303, 136);
            this.receiptdg.TabIndex = 12;
            // 
            // movdg
            // 
            this.movdg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.movdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movdg.Location = new System.Drawing.Point(619, 376);
            this.movdg.Name = "movdg";
            this.movdg.Size = new System.Drawing.Size(303, 136);
            this.movdg.TabIndex = 13;
            // 
            // Scaneofrm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.movdg);
            this.Controls.Add(this.receiptdg);
            this.Controls.Add(this.dcbtn);
            this.Controls.Add(this.pcbtn);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.scandg);
            this.Controls.Add(this.maindg);
            this.Controls.Add(this.completecb);
            this.Controls.Add(this.reasoncb);
            this.Controls.Add(this.reasonlab);
            this.Controls.Add(this.receiptcb);
            this.Controls.Add(this.receiptlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scaneofrm";
            this.Text = "Scaneofrm";
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scandg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label receiptlab;
        private System.Windows.Forms.ComboBox receiptcb;
        private System.Windows.Forms.Label reasonlab;
        private System.Windows.Forms.ComboBox reasoncb;
        private System.Windows.Forms.CheckBox completecb;
        private System.Windows.Forms.DataGridView maindg;
        private System.Windows.Forms.DataGridView scandg;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button pcbtn;
        private System.Windows.Forms.Button dcbtn;
        private System.Windows.Forms.DataGridView receiptdg;
        private System.Windows.Forms.DataGridView movdg;
    }
}