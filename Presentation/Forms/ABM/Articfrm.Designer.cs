using Language;

namespace UI.ABM
{
    partial class Articfrm
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
            this.clientlab = new System.Windows.Forms.Label();
            this.clientcb = new System.Windows.Forms.ComboBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.datadg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datadg)).BeginInit();
            this.SuspendLayout();
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.ForeColor = System.Drawing.Color.White;
            this.clientlab.Location = new System.Drawing.Point(52, 9);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(66, 23);
            this.clientlab.TabIndex = 0;
            this.clientlab.Text = "Cliente";
            // 
            // clientcb
            // 
            this.clientcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcb.FormattingEnabled = true;
            this.clientcb.Location = new System.Drawing.Point(124, 6);
            this.clientcb.Name = "clientcb";
            this.clientcb.Size = new System.Drawing.Size(121, 29);
            this.clientcb.TabIndex = 1;
            // 
            // savebtn
            // 
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(251, 6);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(94, 29);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = strings.Guardar;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // datadg
            // 
            this.datadg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datadg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadg.Location = new System.Drawing.Point(12, 50);
            this.datadg.Name = "datadg";
            this.datadg.Size = new System.Drawing.Size(910, 513);
            this.datadg.TabIndex = 3;
            // 
            // Articfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.datadg);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.clientcb);
            this.Controls.Add(this.clientlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articfrm";
            this.Text = "Articfrm";
            ((System.ComponentModel.ISupportInitialize)(this.datadg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.ComboBox clientcb;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.DataGridView datadg;
    }
}