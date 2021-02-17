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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scaneofrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            this.receiptlab = new System.Windows.Forms.Label();
            this.receiptcb = new System.Windows.Forms.ComboBox();
            this.reasonlab = new System.Windows.Forms.Label();
            this.reasoncb = new System.Windows.Forms.ComboBox();
            this.completecb = new System.Windows.Forms.CheckBox();
            this.dcbtn = new System.Windows.Forms.Button();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.codetxt = new System.Windows.Forms.TextBox();
            this.receiptdg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scandg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdg)).BeginInit();
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
            // dcbtn
            // 
            this.dcbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dcbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dcbtn.FlatAppearance.BorderSize = 0;
            this.dcbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dcbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcbtn.ForeColor = System.Drawing.Color.White;
            this.dcbtn.Location = new System.Drawing.Point(619, 524);
            this.dcbtn.Name = "dcbtn";
            this.dcbtn.Size = new System.Drawing.Size(303, 34);
            this.dcbtn.TabIndex = 11;
            this.dcbtn.Text = "Cierre Definitivo";
            this.dcbtn.UseVisualStyleBackColor = true;
            this.dcbtn.Click += new System.EventHandler(this.dcbtn_Click);
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
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.maindg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lineatxtdg,
            this.articulotxtdg,
            this.quantitytxtdg,
            this.scantxtdg});
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.maindg.DefaultCellStyle = dataGridViewCellStyle39;
            this.maindg.GridColor = System.Drawing.Color.White;
            this.maindg.Location = new System.Drawing.Point(12, 123);
            this.maindg.MultiSelect = false;
            this.maindg.Name = "maindg";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maindg.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.maindg.RowHeadersVisible = false;
            this.maindg.Size = new System.Drawing.Size(594, 435);
            this.maindg.TabIndex = 14;
            // 
            // lineatxtdg
            // 
            this.lineatxtdg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.lineatxtdg.DefaultCellStyle = dataGridViewCellStyle38;
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
            this.scanlab.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.voucherlab.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            this.scandg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scandg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scandg.CausesValidation = false;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scandg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.scandg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scandg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.scandg.DefaultCellStyle = dataGridViewCellStyle43;
            this.scandg.GridColor = System.Drawing.Color.White;
            this.scandg.Location = new System.Drawing.Point(619, 80);
            this.scandg.MultiSelect = false;
            this.scandg.Name = "scandg";
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle44.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scandg.RowHeadersDefaultCellStyle = dataGridViewCellStyle44;
            this.scandg.RowHeadersVisible = false;
            this.scandg.Size = new System.Drawing.Size(303, 197);
            this.scandg.TabIndex = 27;
            this.scandg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scandg_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // codetxt
            // 
            this.codetxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codetxt.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxt.Location = new System.Drawing.Point(12, 54);
            this.codetxt.Name = "codetxt";
            this.codetxt.Size = new System.Drawing.Size(593, 52);
            this.codetxt.TabIndex = 28;
            this.codetxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codetxt_KeyDown);
            // 
            // receiptdg
            // 
            this.receiptdg.AllowUserToAddRows = false;
            this.receiptdg.AllowUserToDeleteRows = false;
            this.receiptdg.AllowUserToOrderColumns = true;
            this.receiptdg.AllowUserToResizeRows = false;
            this.receiptdg.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.receiptdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptdg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.receiptdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptdg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.idart});
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.receiptdg.DefaultCellStyle = dataGridViewCellStyle47;
            this.receiptdg.GridColor = System.Drawing.Color.White;
            this.receiptdg.Location = new System.Drawing.Point(619, 306);
            this.receiptdg.MultiSelect = false;
            this.receiptdg.Name = "receiptdg";
            dataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.receiptdg.RowHeadersDefaultCellStyle = dataGridViewCellStyle48;
            this.receiptdg.RowHeadersVisible = false;
            this.receiptdg.Size = new System.Drawing.Size(303, 197);
            this.receiptdg.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle46;
            this.dataGridViewTextBoxColumn5.HeaderText = "";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // idart
            // 
            this.idart.HeaderText = "";
            this.idart.Name = "idart";
            this.idart.Visible = false;
            // 
            // Scaneofrm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.receiptdg);
            this.Controls.Add(this.codetxt);
            this.Controls.Add(this.scandg);
            this.Controls.Add(this.voucherlab);
            this.Controls.Add(this.scanlab);
            this.Controls.Add(this.expedbtn);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.maindg);
            this.Controls.Add(this.dcbtn);
            this.Controls.Add(this.completecb);
            this.Controls.Add(this.reasoncb);
            this.Controls.Add(this.reasonlab);
            this.Controls.Add(this.receiptcb);
            this.Controls.Add(this.receiptlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scaneofrm";
            this.Text = "Scaneofrm";
            this.Load += new System.EventHandler(this.Scaneofrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maindg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scandg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label receiptlab;
        private System.Windows.Forms.ComboBox receiptcb;
        private System.Windows.Forms.Label reasonlab;
        private System.Windows.Forms.ComboBox reasoncb;
        private System.Windows.Forms.CheckBox completecb;
        private System.Windows.Forms.Button dcbtn;
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
        private DataGridView receiptdg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn idart;
    }
}