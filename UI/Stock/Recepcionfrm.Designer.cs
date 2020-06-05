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
            this.titlelab = new System.Windows.Forms.Label();
            this.clientlab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datelab = new System.Windows.Forms.Label();
            this.voucherPicker = new System.Windows.Forms.DateTimePicker();
            this.invlab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titlelab
            // 
            this.titlelab.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelab.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.titlelab.Location = new System.Drawing.Point(12, 9);
            this.titlelab.Name = "titlelab";
            this.titlelab.Size = new System.Drawing.Size(316, 61);
            this.titlelab.TabIndex = 1;
            this.titlelab.Text = "Recepcion";
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.clientlab.Location = new System.Drawing.Point(17, 90);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(102, 34);
            this.clientlab.TabIndex = 2;
            this.clientlab.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Location = new System.Drawing.Point(119, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // datelab
            // 
            this.datelab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelab.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.datelab.Location = new System.Drawing.Point(177, 90);
            this.datelab.Name = "datelab";
            this.datelab.Size = new System.Drawing.Size(90, 34);
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
            this.voucherPicker.Location = new System.Drawing.Point(272, 93);
            this.voucherPicker.Name = "voucherPicker";
            this.voucherPicker.Size = new System.Drawing.Size(134, 32);
            this.voucherPicker.TabIndex = 6;
            // 
            // invlab
            // 
            this.invlab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invlab.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.invlab.Location = new System.Drawing.Point(423, 94);
            this.invlab.Name = "invlab";
            this.invlab.Size = new System.Drawing.Size(123, 34);
            this.invlab.TabIndex = 7;
            this.invlab.Text = "Remito #";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(552, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 30);
            this.textBox1.TabIndex = 8;
            // 
            // Recepcionfrm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.invlab);
            this.Controls.Add(this.voucherPicker);
            this.Controls.Add(this.datelab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clientlab);
            this.Controls.Add(this.titlelab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recepcionfrm";
            this.Text = "Recepcionfrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label titlelab;
        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.DateTimePicker voucherPicker;
        private System.Windows.Forms.Label invlab;
        private System.Windows.Forms.TextBox textBox1;
    }
}