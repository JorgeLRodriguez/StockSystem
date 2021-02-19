namespace UI.Stock
{
    partial class Transferenciafrm
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
            this.originlab = new System.Windows.Forms.Label();
            this.destlab = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depositlab = new System.Windows.Forms.Label();
            this.codfslab = new System.Windows.Forms.Label();
            this.desclab = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.codfstxt = new System.Windows.Forms.TextBox();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.palletlab = new System.Windows.Forms.Label();
            this.palletcb = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // originlab
            // 
            this.originlab.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originlab.ForeColor = System.Drawing.Color.White;
            this.originlab.Location = new System.Drawing.Point(167, 9);
            this.originlab.Name = "originlab";
            this.originlab.Size = new System.Drawing.Size(128, 48);
            this.originlab.TabIndex = 0;
            this.originlab.Text = "Origen";
            this.originlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destlab
            // 
            this.destlab.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destlab.ForeColor = System.Drawing.Color.White;
            this.destlab.Location = new System.Drawing.Point(106, 9);
            this.destlab.Name = "destlab";
            this.destlab.Size = new System.Drawing.Size(251, 48);
            this.destlab.TabIndex = 1;
            this.destlab.Text = "Destino";
            this.destlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 346);
            this.dataGridView1.TabIndex = 2;
            // 
            // depositlab
            // 
            this.depositlab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositlab.ForeColor = System.Drawing.Color.White;
            this.depositlab.Location = new System.Drawing.Point(9, 67);
            this.depositlab.Name = "depositlab";
            this.depositlab.Size = new System.Drawing.Size(42, 35);
            this.depositlab.TabIndex = 4;
            this.depositlab.Text = "Dep";
            this.depositlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.depositlab.Click += new System.EventHandler(this.depositlab_Click);
            // 
            // codfslab
            // 
            this.codfslab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codfslab.ForeColor = System.Drawing.Color.White;
            this.codfslab.Location = new System.Drawing.Point(157, 67);
            this.codfslab.Name = "codfslab";
            this.codfslab.Size = new System.Drawing.Size(60, 35);
            this.codfslab.TabIndex = 5;
            this.codfslab.Text = "Cod FS";
            this.codfslab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desclab
            // 
            this.desclab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclab.ForeColor = System.Drawing.Color.White;
            this.desclab.Location = new System.Drawing.Point(316, 66);
            this.desclab.Name = "desclab";
            this.desclab.Size = new System.Drawing.Size(46, 35);
            this.desclab.TabIndex = 6;
            this.desclab.Text = "Desc";
            this.desclab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(94, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // codfstxt
            // 
            this.codfstxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codfstxt.Location = new System.Drawing.Point(223, 70);
            this.codfstxt.Name = "codfstxt";
            this.codfstxt.Size = new System.Drawing.Size(87, 27);
            this.codfstxt.TabIndex = 8;
            // 
            // desctxt
            // 
            this.desctxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctxt.Location = new System.Drawing.Point(368, 70);
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(86, 27);
            this.desctxt.TabIndex = 9;
            this.desctxt.TextChanged += new System.EventHandler(this.desctxt_TextChanged);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 9;
            this.lineShape1.X2 = 453;
            this.lineShape1.Y1 = 108;
            this.lineShape1.Y2 = 108;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.White;
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.Enabled = false;
            this.rectangleShape1.Location = new System.Drawing.Point(9, 7);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(444, 55);
            // 
            // palletlab
            // 
            this.palletlab.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palletlab.ForeColor = System.Drawing.Color.White;
            this.palletlab.Location = new System.Drawing.Point(140, 66);
            this.palletlab.Name = "palletlab";
            this.palletlab.Size = new System.Drawing.Size(58, 35);
            this.palletlab.TabIndex = 11;
            this.palletlab.Text = "Pallet";
            this.palletlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // palletcb
            // 
            this.palletcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.palletcb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.palletcb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.palletcb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.palletcb.FormattingEnabled = true;
            this.palletcb.Location = new System.Drawing.Point(204, 69);
            this.palletcb.Name = "palletcb";
            this.palletcb.Size = new System.Drawing.Size(121, 28);
            this.palletcb.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.depositlab);
            this.panel1.Controls.Add(this.desctxt);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.desclab);
            this.panel1.Controls.Add(this.codfstxt);
            this.panel1.Controls.Add(this.codfslab);
            this.panel1.Controls.Add(this.originlab);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 477);
            this.panel1.TabIndex = 13;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.rectangleShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(460, 477);
            this.shapeContainer2.TabIndex = 8;
            this.shapeContainer2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.destlab);
            this.panel2.Controls.Add(this.palletcb);
            this.panel2.Controls.Add(this.palletlab);
            this.panel2.Controls.Add(this.shapeContainer3);
            this.panel2.Location = new System.Drawing.Point(469, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 477);
            this.panel2.TabIndex = 14;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.rectangleShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(465, 477);
            this.shapeContainer3.TabIndex = 13;
            this.shapeContainer3.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape2.BorderColor = System.Drawing.Color.White;
            this.rectangleShape2.BorderWidth = 2;
            this.rectangleShape2.Enabled = false;
            this.rectangleShape2.Location = new System.Drawing.Point(6, 7);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(456, 55);
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 5;
            this.lineShape2.X2 = 459;
            this.lineShape2.Y1 = 108;
            this.lineShape2.Y2 = 108;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 119);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(456, 346);
            this.dataGridView2.TabIndex = 10;
            // 
            // Transferenciafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(43)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(934, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transferenciafrm";
            this.Text = "Transferenciafrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label originlab;
        private System.Windows.Forms.Label destlab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label depositlab;
        private System.Windows.Forms.Label codfslab;
        private System.Windows.Forms.Label desclab;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox codfstxt;
        private System.Windows.Forms.TextBox desctxt;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label palletlab;
        private System.Windows.Forms.ComboBox palletcb;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
    }
}