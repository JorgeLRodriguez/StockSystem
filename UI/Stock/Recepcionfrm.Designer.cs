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
            this.clientbtn = new System.Windows.Forms.Button();
            this.datelab = new System.Windows.Forms.Label();
            this.voucherPicker = new System.Windows.Forms.DateTimePicker();
            this.invlab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.invdetdataGrid = new System.Windows.Forms.DataGridView();
            this.savebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.invdetdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.ForeColor = System.Drawing.Color.White;
            this.clientlab.Location = new System.Drawing.Point(100, 9);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(75, 27);
            this.clientlab.TabIndex = 2;
            this.clientlab.Text = strings.Cliente;
            // 
            // clientbtn
            // 
            this.clientbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientbtn.ForeColor = System.Drawing.Color.White;
            this.clientbtn.Location = new System.Drawing.Point(171, 5);
            this.clientbtn.Name = "clientbtn";
            this.clientbtn.Size = new System.Drawing.Size(36, 31);
            this.clientbtn.TabIndex = 3;
            this.clientbtn.Text = "...";
            this.clientbtn.UseVisualStyleBackColor = true;
            // 
            // datelab
            // 
            this.datelab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelab.ForeColor = System.Drawing.Color.White;
            this.datelab.Location = new System.Drawing.Point(244, 9);
            this.datelab.Name = "datelab";
            this.datelab.Size = new System.Drawing.Size(71, 27);
            this.datelab.TabIndex = 4;
            this.datelab.Text = strings.Fecha;
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
            this.voucherPicker.Location = new System.Drawing.Point(321, 9);
            this.voucherPicker.Name = "voucherPicker";
            this.voucherPicker.Size = new System.Drawing.Size(134, 27);
            this.voucherPicker.TabIndex = 6;
            // 
            // invlab
            // 
            this.invlab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invlab.ForeColor = System.Drawing.Color.White;
            this.invlab.Location = new System.Drawing.Point(482, 9);
            this.invlab.Name = "invlab";
            this.invlab.Size = new System.Drawing.Size(95, 23);
            this.invlab.TabIndex = 7;
            this.invlab.Text = strings.Remito + " #";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(574, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 27);
            this.textBox1.TabIndex = 8;
            // 
            // invdetdataGrid
            // 
            this.invdetdataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.invdetdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invdetdataGrid.Location = new System.Drawing.Point(104, 73);
            this.invdetdataGrid.Name = "invdetdataGrid";
            this.invdetdataGrid.Size = new System.Drawing.Size(757, 432);
            this.invdetdataGrid.TabIndex = 9;
            // 
            // savebtn
            // 
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.White;
            this.savebtn.Location = new System.Drawing.Point(772, 6);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(89, 31);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = strings.Guardar;
            this.savebtn.UseVisualStyleBackColor = true;
            // 
            // Recepcionfrm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.invdetdataGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.invlab);
            this.Controls.Add(this.voucherPicker);
            this.Controls.Add(this.datelab);
            this.Controls.Add(this.clientbtn);
            this.Controls.Add(this.clientlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recepcionfrm";
            this.Text = "Recepcionfrm";
            ((System.ComponentModel.ISupportInitialize)(this.invdetdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.Button clientbtn;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.DateTimePicker voucherPicker;
        private System.Windows.Forms.Label invlab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView invdetdataGrid;
        private System.Windows.Forms.Button savebtn;
    }
}