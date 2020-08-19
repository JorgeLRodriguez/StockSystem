using Language;

namespace UI.Stock
{
    partial class AjusteInvfrm
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
            this.clientbtn = new System.Windows.Forms.Button();
            this.clienttxt = new System.Windows.Forms.TextBox();
            this.datelab = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.obslab = new System.Windows.Forms.Label();
            this.obstxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.ForeColor = System.Drawing.Color.White;
            this.clientlab.Location = new System.Drawing.Point(50, 9);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(68, 26);
            this.clientlab.TabIndex = 0;
            this.clientlab.Text = strings.Cliente;
            this.clientlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientbtn
            // 
            this.clientbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientbtn.ForeColor = System.Drawing.Color.White;
            this.clientbtn.Location = new System.Drawing.Point(124, 9);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(32, 26);
            this.clientbtn.TabIndex = 1;
            this.clientbtn.Text = "...";
            this.clientbtn.UseVisualStyleBackColor = true;
            // 
            // clienttxt
            // 
            this.clienttxt.Enabled = false;
            this.clienttxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienttxt.Location = new System.Drawing.Point(162, 9);
            this.clienttxt.Name = "clienttxt";
            this.clienttxt.Size = new System.Drawing.Size(166, 27);
            this.clienttxt.TabIndex = 2;
            // 
            // datelab
            // 
            this.datelab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelab.ForeColor = System.Drawing.Color.White;
            this.datelab.Location = new System.Drawing.Point(334, 10);
            this.datelab.Name = "datelab";
            this.datelab.Size = new System.Drawing.Size(60, 26);
            this.datelab.TabIndex = 3;
            this.datelab.Text = strings.Fecha;
            this.datelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(400, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // obslab
            // 
            this.obslab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obslab.ForeColor = System.Drawing.Color.White;
            this.obslab.Location = new System.Drawing.Point(502, 9);
            this.obslab.Name = "obslab";
            this.obslab.Size = new System.Drawing.Size(127, 26);
            this.obslab.TabIndex = 5;
            this.obslab.Text = strings.Observacion;
            this.obslab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // obstxt
            // 
            this.obstxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obstxt.Enabled = false;
            this.obstxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstxt.Location = new System.Drawing.Point(618, 9);
            this.obstxt.Name = "obstxt";
            this.obstxt.Size = new System.Drawing.Size(304, 27);
            this.obstxt.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 382);
            this.dataGridView1.TabIndex = 7;
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(825, 433);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(97, 35);
            this.savebtn.TabIndex = 8;
            this.savebtn.Text = strings.Guardar;
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // AjusteInvfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(934, 477);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.obstxt);
            this.Controls.Add(this.obslab);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datelab);
            this.Controls.Add(this.clienttxt);
            this.Controls.Add(this.clientbtn);
            this.Controls.Add(this.clientlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjusteInvfrm";
            this.Text = "AjusteInvfrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.Button clientbtn;
        private System.Windows.Forms.TextBox clienttxt;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label obslab;
        private System.Windows.Forms.TextBox obstxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button savebtn;
    }
}