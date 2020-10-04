namespace UI.Forms.Impresion
{
    partial class printfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printpanel = new System.Windows.Forms.Panel();
            this.voulab = new System.Windows.Forms.Label();
            this.numberlab = new System.Windows.Forms.Label();
            this.datelab = new System.Windows.Forms.Label();
            this.invlab = new System.Windows.Forms.Label();
            this.letterlab = new System.Windows.Forms.Label();
            this.clientlab = new System.Windows.Forms.Label();
            this.titlelab = new System.Windows.Forms.Label();
            this.dataGriddata = new System.Windows.Forms.DataGridView();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.groupBoxnum = new System.Windows.Forms.GroupBox();
            this.checkedListBoxnum = new System.Windows.Forms.CheckedListBox();
            this.btnselectprinter = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.despacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddata)).BeginInit();
            this.groupBoxnum.SuspendLayout();
            this.SuspendLayout();
            // 
            // printpanel
            // 
            this.printpanel.BackColor = System.Drawing.Color.White;
            this.printpanel.Controls.Add(this.voulab);
            this.printpanel.Controls.Add(this.numberlab);
            this.printpanel.Controls.Add(this.datelab);
            this.printpanel.Controls.Add(this.invlab);
            this.printpanel.Controls.Add(this.letterlab);
            this.printpanel.Controls.Add(this.clientlab);
            this.printpanel.Controls.Add(this.titlelab);
            this.printpanel.Controls.Add(this.dataGriddata);
            this.printpanel.Controls.Add(this.shapeContainer1);
            this.printpanel.Location = new System.Drawing.Point(13, 13);
            this.printpanel.Name = "printpanel";
            this.printpanel.Size = new System.Drawing.Size(562, 425);
            this.printpanel.TabIndex = 0;
            // 
            // voulab
            // 
            this.voulab.BackColor = System.Drawing.Color.White;
            this.voulab.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voulab.Location = new System.Drawing.Point(329, 10);
            this.voulab.Name = "voulab";
            this.voulab.Size = new System.Drawing.Size(141, 29);
            this.voulab.TabIndex = 8;
            this.voulab.Text = "Comprobante:";
            // 
            // numberlab
            // 
            this.numberlab.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberlab.Location = new System.Drawing.Point(221, 50);
            this.numberlab.Name = "numberlab";
            this.numberlab.Size = new System.Drawing.Size(109, 24);
            this.numberlab.TabIndex = 7;
            this.numberlab.Text = "ORIGINAL";
            // 
            // datelab
            // 
            this.datelab.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelab.Location = new System.Drawing.Point(329, 37);
            this.datelab.Name = "datelab";
            this.datelab.Size = new System.Drawing.Size(74, 29);
            this.datelab.TabIndex = 6;
            this.datelab.Text = "Fecha:";
            // 
            // invlab
            // 
            this.invlab.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invlab.Location = new System.Drawing.Point(3, 71);
            this.invlab.Name = "invlab";
            this.invlab.Size = new System.Drawing.Size(86, 24);
            this.invlab.TabIndex = 5;
            this.invlab.Text = "Remito:";
            // 
            // letterlab
            // 
            this.letterlab.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letterlab.Location = new System.Drawing.Point(263, 10);
            this.letterlab.Name = "letterlab";
            this.letterlab.Size = new System.Drawing.Size(29, 29);
            this.letterlab.TabIndex = 3;
            this.letterlab.Text = "X";
            this.letterlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientlab
            // 
            this.clientlab.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientlab.Location = new System.Drawing.Point(3, 39);
            this.clientlab.Name = "clientlab";
            this.clientlab.Size = new System.Drawing.Size(76, 27);
            this.clientlab.TabIndex = 2;
            this.clientlab.Text = "Cliente:";
            // 
            // titlelab
            // 
            this.titlelab.BackColor = System.Drawing.Color.White;
            this.titlelab.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelab.Location = new System.Drawing.Point(3, 10);
            this.titlelab.Name = "titlelab";
            this.titlelab.Size = new System.Drawing.Size(207, 29);
            this.titlelab.TabIndex = 1;
            this.titlelab.Text = "Informe de recepción";
            // 
            // dataGriddata
            // 
            this.dataGriddata.AllowUserToAddRows = false;
            this.dataGriddata.AllowUserToDeleteRows = false;
            this.dataGriddata.AllowUserToResizeColumns = false;
            this.dataGriddata.AllowUserToResizeRows = false;
            this.dataGriddata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGriddata.BackgroundColor = System.Drawing.Color.White;
            this.dataGriddata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGriddata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGriddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.despacho});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGriddata.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGriddata.GridColor = System.Drawing.Color.White;
            this.dataGriddata.Location = new System.Drawing.Point(3, 101);
            this.dataGriddata.MultiSelect = false;
            this.dataGriddata.Name = "dataGriddata";
            this.dataGriddata.ReadOnly = true;
            this.dataGriddata.RowHeadersVisible = false;
            this.dataGriddata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGriddata.ShowCellErrors = false;
            this.dataGriddata.ShowCellToolTips = false;
            this.dataGriddata.ShowEditingIcon = false;
            this.dataGriddata.ShowRowErrors = false;
            this.dataGriddata.Size = new System.Drawing.Size(556, 321);
            this.dataGriddata.TabIndex = 0;
            this.dataGriddata.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(562, 425);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Location = new System.Drawing.Point(256, 8);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(40, 33);
            // 
            // groupBoxnum
            // 
            this.groupBoxnum.Controls.Add(this.checkedListBoxnum);
            this.groupBoxnum.Location = new System.Drawing.Point(581, 13);
            this.groupBoxnum.Name = "groupBoxnum";
            this.groupBoxnum.Size = new System.Drawing.Size(139, 95);
            this.groupBoxnum.TabIndex = 1;
            this.groupBoxnum.TabStop = false;
            this.groupBoxnum.Text = "Impresiones";
            // 
            // checkedListBoxnum
            // 
            this.checkedListBoxnum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBoxnum.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxnum.FormattingEnabled = true;
            this.checkedListBoxnum.Items.AddRange(new object[] {
            "ORIGINAL",
            "DUPLICADO",
            "TRIPLICADO",
            "CUADRUPLICADO"});
            this.checkedListBoxnum.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxnum.Name = "checkedListBoxnum";
            this.checkedListBoxnum.Size = new System.Drawing.Size(126, 64);
            this.checkedListBoxnum.TabIndex = 0;
            // 
            // btnselectprinter
            // 
            this.btnselectprinter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnselectprinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnselectprinter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselectprinter.Location = new System.Drawing.Point(605, 114);
            this.btnselectprinter.Name = "btnselectprinter";
            this.btnselectprinter.Size = new System.Drawing.Size(95, 32);
            this.btnselectprinter.TabIndex = 2;
            this.btnselectprinter.Text = "Impresora";
            this.btnselectprinter.UseVisualStyleBackColor = true;
            // 
            // printbtn
            // 
            this.printbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(605, 161);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(95, 32);
            this.printbtn.TabIndex = 3;
            this.printbtn.Text = "Imprimir";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitbtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(605, 209);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(95, 32);
            this.exitbtn.TabIndex = 4;
            this.exitbtn.Text = "Salir";
            this.exitbtn.UseVisualStyleBackColor = true;
            // 
            // codigo
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.descripcion.DefaultCellStyle = dataGridViewCellStyle3;
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // cantidad
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // despacho
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.despacho.DefaultCellStyle = dataGridViewCellStyle5;
            this.despacho.HeaderText = "";
            this.despacho.Name = "despacho";
            this.despacho.ReadOnly = true;
            // 
            // printfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.btnselectprinter);
            this.Controls.Add(this.groupBoxnum);
            this.Controls.Add(this.printpanel);
            this.Name = "printfrm";
            this.Text = "Impresión de comprobante";
            this.printpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGriddata)).EndInit();
            this.groupBoxnum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel printpanel;
        private System.Windows.Forms.Label titlelab;
        private System.Windows.Forms.Label clientlab;
        private System.Windows.Forms.Label invlab;
        private System.Windows.Forms.Label letterlab;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label voulab;
        private System.Windows.Forms.Label numberlab;
        private System.Windows.Forms.Label datelab;
        private System.Windows.Forms.GroupBox groupBoxnum;
        private System.Windows.Forms.CheckedListBox checkedListBoxnum;
        private System.Windows.Forms.Button btnselectprinter;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.DataGridView dataGriddata;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn despacho;
    }
}