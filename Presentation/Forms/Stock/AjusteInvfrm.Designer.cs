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
            this.datelab = new System.Windows.Forms.Label();
            this.obslab = new System.Windows.Forms.Label();
            this.obstxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientcbx = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.savebtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.ForeColor = System.Drawing.Color.White;
            this.clientlab.Location = new System.Drawing.Point(46, 8);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(68, 26);
            this.clientlab.TabIndex = 0;
            this.clientlab.Text = "Cliente";
            this.clientlab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // datelab
            // 
            this.datelab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelab.ForeColor = System.Drawing.Color.White;
            this.datelab.Location = new System.Drawing.Point(287, 8);
            this.datelab.Name = "datelab";
            this.datelab.Size = new System.Drawing.Size(60, 26);
            this.datelab.TabIndex = 3;
            this.datelab.Text = "Fecha";
            this.datelab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // obslab
            // 
            this.obslab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obslab.ForeColor = System.Drawing.Color.White;
            this.obslab.Location = new System.Drawing.Point(478, 8);
            this.obslab.Name = "obslab";
            this.obslab.Size = new System.Drawing.Size(124, 26);
            this.obslab.TabIndex = 5;
            this.obslab.Text = "Observacion";
            this.obslab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // obstxt
            // 
            this.obstxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obstxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obstxt.Location = new System.Drawing.Point(608, 8);
            this.obstxt.Name = "obstxt";
            this.obstxt.Size = new System.Drawing.Size(314, 26);
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
            // clientcbx
            // 
            this.clientcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientcbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientcbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcbx.FormattingEnabled = true;
            this.clientcbx.Location = new System.Drawing.Point(120, 6);
            this.clientcbx.Name = "clientcbx";
            this.clientcbx.Size = new System.Drawing.Size(161, 29);
            this.clientcbx.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(353, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // savebtn
            // 
            this.savebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.savebtn.IconColor = System.Drawing.Color.White;
            this.savebtn.IconSize = 27;
            this.savebtn.Location = new System.Drawing.Point(805, 432);
            this.savebtn.Name = "savebtn";
            this.savebtn.Rotation = 0D;
            this.savebtn.Size = new System.Drawing.Size(117, 33);
            this.savebtn.TabIndex = 13;
            this.savebtn.Text = "Guardar";
            this.savebtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // AjusteInvfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(934, 477);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.clientcbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.obstxt);
            this.Controls.Add(this.obslab);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datelab);
            this.Controls.Add(this.clientlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjusteInvfrm";
            this.Text = "AjusteInvfrm";
            this.Load += new System.EventHandler(this.AjusteInvfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.Label obslab;
        private System.Windows.Forms.TextBox obstxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox clientcbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton savebtn;
    }
}