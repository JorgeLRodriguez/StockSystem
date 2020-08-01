namespace UI.Stock
{
    partial class Recepcionfrm
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
            this.voucherPicker = new System.Windows.Forms.DateTimePicker();
            this.invlab = new System.Windows.Forms.Label();
            this.invoicetxt = new System.Windows.Forms.TextBox();
            this.invdetdataGrid = new System.Windows.Forms.DataGridView();
            this.savebtn = new System.Windows.Forms.Button();
            this.clientcbx = new System.Windows.Forms.ComboBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.articlecbdg = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantitytxtdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.invdetdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.ForeColor = System.Drawing.Color.White;
            this.clientlab.Location = new System.Drawing.Point(94, 121);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(75, 27);
            this.clientlab.TabIndex = 2;
            this.clientlab.Text = "Cliente";
            // 
            // datelab
            // 
            this.datelab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelab.ForeColor = System.Drawing.Color.White;
            this.datelab.Location = new System.Drawing.Point(94, 170);
            this.datelab.Name = "datelab";
            this.datelab.Size = new System.Drawing.Size(71, 27);
            this.datelab.TabIndex = 4;
            this.datelab.Text = "Fecha";
            // 
            // voucherPicker
            // 
            this.voucherPicker.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherPicker.CalendarForeColor = System.Drawing.Color.MediumSpringGreen;
            this.voucherPicker.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.voucherPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.voucherPicker.CalendarTitleForeColor = System.Drawing.Color.SeaShell;
            this.voucherPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voucherPicker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.voucherPicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.voucherPicker.Location = new System.Drawing.Point(173, 170);
            this.voucherPicker.Name = "voucherPicker";
            this.voucherPicker.Size = new System.Drawing.Size(118, 27);
            this.voucherPicker.TabIndex = 6;
            // 
            // invlab
            // 
            this.invlab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invlab.ForeColor = System.Drawing.Color.White;
            this.invlab.Location = new System.Drawing.Point(81, 220);
            this.invlab.Name = "invlab";
            this.invlab.Size = new System.Drawing.Size(95, 23);
            this.invlab.TabIndex = 7;
            this.invlab.Text = "Remito #";
            // 
            // invoicetxt
            // 
            this.invoicetxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicetxt.Location = new System.Drawing.Point(173, 220);
            this.invoicetxt.Name = "invoicetxt";
            this.invoicetxt.Size = new System.Drawing.Size(208, 27);
            this.invoicetxt.TabIndex = 8;
            // 
            // invdetdataGrid
            // 
            this.invdetdataGrid.AllowUserToAddRows = false;
            this.invdetdataGrid.AllowUserToDeleteRows = false;
            this.invdetdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invdetdataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articlecbdg,
            this.quantitytxtdg});
            this.invdetdataGrid.Location = new System.Drawing.Point(458, 57);
            this.invdetdataGrid.Name = "invdetdataGrid";
            this.invdetdataGrid.Size = new System.Drawing.Size(403, 468);
            this.invdetdataGrid.TabIndex = 9;
            this.invdetdataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invdetdataGrid_CellContentClick);
            // 
            // savebtn
            // 
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(202, 381);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(89, 31);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = global::UI.strings.Guardar;
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // clientcbx
            // 
            this.clientcbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientcbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientcbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientcbx.FormattingEnabled = true;
            this.clientcbx.Location = new System.Drawing.Point(173, 119);
            this.clientcbx.Name = "clientcbx";
            this.clientcbx.Size = new System.Drawing.Size(208, 29);
            this.clientcbx.TabIndex = 11;
            this.clientcbx.SelectedIndexChanged += new System.EventHandler(this.clientcbx_SelectedIndexChanged);
            // 
            // addbtn
            // 
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.Location = new System.Drawing.Point(202, 272);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(89, 31);
            this.addbtn.TabIndex = 12;
            this.addbtn.Text = "Agregar";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Location = new System.Drawing.Point(202, 327);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(89, 31);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "Eliminar";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // articlecbdg
            // 
            this.articlecbdg.HeaderText = "";
            this.articlecbdg.Name = "articlecbdg";
            this.articlecbdg.Width = 210;
            // 
            // quantitytxtdg
            // 
            this.quantitytxtdg.HeaderText = "";
            this.quantitytxtdg.Name = "quantitytxtdg";
            this.quantitytxtdg.Width = 150;
            // 
            // Recepcionfrm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.clientcbx);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.invdetdataGrid);
            this.Controls.Add(this.invoicetxt);
            this.Controls.Add(this.invlab);
            this.Controls.Add(this.voucherPicker);
            this.Controls.Add(this.datelab);
            this.Controls.Add(this.clientlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recepcionfrm";
            this.Text = "Recepcionfrm";
            this.Load += new System.EventHandler(this.Recepcionfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invdetdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.DateTimePicker voucherPicker;
        private System.Windows.Forms.Label invlab;
        private System.Windows.Forms.TextBox invoicetxt;
        private System.Windows.Forms.DataGridView invdetdataGrid;
        private System.Windows.Forms.Button savebtn;
        public System.Windows.Forms.ComboBox clientcbx;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridViewComboBoxColumn articlecbdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitytxtdg;
    }
}