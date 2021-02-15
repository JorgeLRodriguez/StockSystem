using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scaneofrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receiptlab = new System.Windows.Forms.Label();
            this.receiptcb = new System.Windows.Forms.ComboBox();
            this.reasonlab = new System.Windows.Forms.Label();
            this.reasoncb = new System.Windows.Forms.ComboBox();
            this.completecb = new System.Windows.Forms.CheckBox();
            this.pcbtn = new System.Windows.Forms.Button();
            this.dcbtn = new System.Windows.Forms.Button();
            this.receiptdg = new System.Windows.Forms.DataGridView();
            this.maindg = new System.Windows.Forms.DataGridView();
            this.lineatxtdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articulotxtdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitytxtdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scantxtdg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.expedbtn = new System.Windows.Forms.Button();
            this.scanlab = new System.Windows.Forms.Label();
            this.voucherlab = new System.Windows.Forms.Label();
            this.scandg = new System.Windows.Forms.DataGridView();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scandg)).BeginInit();
            this.SuspendLayout();
            // 
            // receiptlab
            // 
            this.receiptlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptlab.ForeColor = System.Drawing.Color.White;
            this.receiptlab.Location = new System.Drawing.Point(62, 13);
            this.receiptlab.Name = "receiptlab";
            this.receiptlab.Size = new System.Drawing.Size(124, 23);
            this.receiptlab.TabIndex = 0;
            this.receiptlab.Text = "Comprobante";
            this.receiptlab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptcb
            // 
            this.receiptcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.receiptcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.receiptcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptcb.FormattingEnabled = true;
            this.receiptcb.Location = new System.Drawing.Point(192, 10);
            this.receiptcb.Name = "receiptcb";
            this.receiptcb.Size = new System.Drawing.Size(174, 29);
            this.receiptcb.TabIndex = 1;
            this.receiptcb.SelectedIndexChanged += new System.EventHandler(this.receiptcb_SelectedIndexChanged);
            // 
            // reasonlab
            // 
            this.reasonlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasonlab.ForeColor = System.Drawing.Color.White;
            this.reasonlab.Location = new System.Drawing.Point(372, 13);
            this.reasonlab.Name = "reasonlab";
            this.reasonlab.Size = new System.Drawing.Size(76, 23);
            this.reasonlab.TabIndex = 2;
            this.reasonlab.Text = "Motivo";
            this.reasonlab.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // reasoncb
            // 
            this.reasoncb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reasoncb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasoncb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reasoncb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reasoncb.FormattingEnabled = true;
            this.reasoncb.Location = new System.Drawing.Point(454, 10);
            this.reasoncb.Name = "reasoncb";
            this.reasoncb.Size = new System.Drawing.Size(267, 29);
            this.reasoncb.TabIndex = 3;
            // 
            // completecb
            // 
            this.completecb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.completecb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completecb.ForeColor = System.Drawing.Color.White;
            this.completecb.Location = new System.Drawing.Point(727, 12);
            this.completecb.Name = "completecb";
            this.completecb.Size = new System.Drawing.Size(195, 24);
            this.completecb.TabIndex = 4;
            this.completecb.Text = "CompletarCantidad";
            this.completecb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.completecb.UseVisualStyleBackColor = true;
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
            this.receiptdg.Location = new System.Drawing.Point(619, 306);
            this.receiptdg.Name = "receiptdg";
            this.receiptdg.Size = new System.Drawing.Size(303, 212);
            this.receiptdg.TabIndex = 12;
            // 
            // maindg
            // 
            this.maindg.AllowUserToAddRows = false;
            this.maindg.AllowUserToDeleteRows = false;
            this.maindg.AllowUserToOrderColumns = true;
            this.maindg.AllowUserToResizeRows = false;
            this.maindg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maindg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.maindg.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.maindg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineatxtdg,
            this.articulotxtdg,
            this.quantitytxtdg,
            this.scantxtdg});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maindg.DefaultCellStyle = dataGridViewCellStyle3;
            this.maindg.GridColor = System.Drawing.Color.White;
            this.maindg.Location = new System.Drawing.Point(12, 123);
            this.maindg.MultiSelect = false;
            this.maindg.Name = "maindg";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindg.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.maindg.RowHeadersVisible = false;
            this.maindg.Size = new System.Drawing.Size(594, 435);
            this.maindg.TabIndex = 14;
            // 
            // lineatxtdg
            // 
            this.lineatxtdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.lineatxtdg.DefaultCellStyle = dataGridViewCellStyle2;
            this.lineatxtdg.HeaderText = "";
            this.lineatxtdg.Name = "lineatxtdg";
            this.lineatxtdg.ReadOnly = true;
            this.lineatxtdg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lineatxtdg.Width = 19;
            // 
            // articulotxtdg
            // 
            this.articulotxtdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articulotxtdg.HeaderText = "";
            this.articulotxtdg.Name = "articulotxtdg";
            this.articulotxtdg.ReadOnly = true;
            // 
            // quantitytxtdg
            // 
            this.quantitytxtdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantitytxtdg.HeaderText = "";
            this.quantitytxtdg.Name = "quantitytxtdg";
            this.quantitytxtdg.ReadOnly = true;
            // 
            // scantxtdg
            // 
            this.scantxtdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.scantxtdg.HeaderText = "";
            this.scantxtdg.Name = "scantxtdg";
            this.scantxtdg.ReadOnly = true;
            this.scantxtdg.Width = 19;
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(12, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(15, 15);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 23;
            this.btnclose.TabStop = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // expedbtn
            // 
            this.expedbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expedbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expedbtn.FlatAppearance.BorderSize = 0;
            this.expedbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expedbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expedbtn.ForeColor = System.Drawing.Color.White;
            this.expedbtn.Location = new System.Drawing.Point(619, 524);
            this.expedbtn.Name = "expedbtn";
            this.expedbtn.Size = new System.Drawing.Size(303, 34);
            this.expedbtn.TabIndex = 24;
            this.expedbtn.Text = "Expedición";
            this.expedbtn.UseVisualStyleBackColor = true;
            // 
            // scanlab
            // 
            this.scanlab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scanlab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scanlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanlab.ForeColor = System.Drawing.Color.White;
            this.scanlab.Location = new System.Drawing.Point(619, 54);
            this.scanlab.Name = "scanlab";
            this.scanlab.Size = new System.Drawing.Size(303, 23);
            this.scanlab.TabIndex = 25;
            this.scanlab.Text = "Scan";
            this.scanlab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // voucherlab
            // 
            this.voucherlab.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.voucherlab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.voucherlab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voucherlab.ForeColor = System.Drawing.Color.White;
            this.voucherlab.Location = new System.Drawing.Point(619, 280);
            this.voucherlab.Name = "voucherlab";
            this.voucherlab.Size = new System.Drawing.Size(303, 23);
            this.voucherlab.TabIndex = 26;
            this.voucherlab.Text = "Comprobante";
            this.voucherlab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scandg
            // 
            this.scandg.AllowUserToAddRows = false;
            this.scandg.AllowUserToDeleteRows = false;
            this.scandg.AllowUserToOrderColumns = true;
            this.scandg.AllowUserToResizeRows = false;
            this.scandg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scandg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scandg.CausesValidation = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scandg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.scandg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scandg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scandg.DefaultCellStyle = dataGridViewCellStyle7;
            this.scandg.GridColor = System.Drawing.Color.White;
            this.scandg.Location = new System.Drawing.Point(619, 80);
            this.scandg.MultiSelect = false;
            this.scandg.Name = "scandg";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scandg.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.scandg.RowHeadersVisible = false;
            this.scandg.Size = new System.Drawing.Size(303, 197);
            this.scandg.TabIndex = 27;
            this.scandg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scandg_CellContentClick);
            // 
            // codetxt
            // 
            this.codetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codetxt.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(12, 54);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(593, 52);
            this.codetxt.TabIndex = 28;
            this.codetxt.TextChanged += new System.EventHandler(this.codetxt_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn4.HeaderText = "";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.Width = 19;
            // 
            // Scaneofrm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.scandg);
            this.Controls.Add(this.voucherlab);
            this.Controls.Add(this.scanlab);
            this.Controls.Add(this.expedbtn);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.maindg);
            this.Controls.Add(this.receiptdg);
            this.Controls.Add(this.dcbtn);
            this.Controls.Add(this.pcbtn);
            this.Controls.Add(this.completecb);
            this.Controls.Add(this.reasoncb);
            this.Controls.Add(this.reasonlab);
            this.Controls.Add(this.receiptcb);
            this.Controls.Add(this.receiptlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scaneofrm";
            this.Text = "Scaneofrm";
            this.Load += new System.EventHandler(this.Scaneofrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receiptdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scandg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label receiptlab;
        private System.Windows.Forms.ComboBox receiptcb;
        private System.Windows.Forms.Label reasonlab;
        private System.Windows.Forms.ComboBox reasoncb;
        private System.Windows.Forms.CheckBox completecb;
        private System.Windows.Forms.Button pcbtn;
        private System.Windows.Forms.Button dcbtn;
        private System.Windows.Forms.DataGridView receiptdg;
        private DataGridView maindg;
        private PictureBox btnclose;
        private DataGridViewTextBoxColumn lineatxtdg;
        private DataGridViewTextBoxColumn articulotxtdg;
        private DataGridViewTextBoxColumn quantitytxtdg;
        private DataGridViewTextBoxColumn scantxtdg;
        private Button expedbtn;
        private Label scanlab;
        private Label voucherlab;
        private DataGridView scandg;
        private TextBox codetxt;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn dataGridViewTextBoxColumn4;
    }
}