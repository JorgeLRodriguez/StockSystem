using System;

namespace UI.Stock
{
    partial class Pickingfrm
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
            this.printbtn = new System.Windows.Forms.Button();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.showconfcb = new System.Windows.Forms.CheckBox();
            this.pickingdg = new System.Windows.Forms.DataGridView();
            this.printdg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pickingdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printdg)).BeginInit();
            this.SuspendLayout();
            // 
            // printbtn
            // 
            this.printbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printbtn.FlatAppearance.BorderSize = 1;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.White;
            this.printbtn.Location = new System.Drawing.Point(65, 12);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(87, 35);
            this.printbtn.TabIndex = 0;
            this.printbtn.Text = strings.Imprimir;
            this.printbtn.UseVisualStyleBackColor = true;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmbtn.FlatAppearance.BorderSize = 1;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.Color.White;
            this.confirmbtn.Location = new System.Drawing.Point(158, 12);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(105, 35);
            this.confirmbtn.TabIndex = 1;
            this.confirmbtn.Text = strings.Conf;
            this.confirmbtn.UseVisualStyleBackColor = true;
            // 
            // showconfcb
            // 
            this.showconfcb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showconfcb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showconfcb.ForeColor = System.Drawing.Color.White;
            this.showconfcb.Location = new System.Drawing.Point(291, 15);
            this.showconfcb.Name = "showconfcb";
            this.showconfcb.Size = new System.Drawing.Size(189, 24);
            this.showconfcb.TabIndex = 2;
            this.showconfcb.Text = strings.MostrarConf;
            this.showconfcb.UseVisualStyleBackColor = true;
            // 
            // pickingdg
            // 
            this.pickingdg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pickingdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pickingdg.Location = new System.Drawing.Point(23, 60);
            this.pickingdg.Name = "pickingdg";
            this.pickingdg.Size = new System.Drawing.Size(406, 486);
            this.pickingdg.TabIndex = 3;
            // 
            // printdg
            // 
            this.printdg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.printdg.Location = new System.Drawing.Point(455, 60);
            this.printdg.Name = "printdg";
            this.printdg.Size = new System.Drawing.Size(444, 486);
            this.printdg.TabIndex = 4;
            // 
            // Pickingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(26)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(934, 577);
            this.Controls.Add(this.printdg);
            this.Controls.Add(this.pickingdg);
            this.Controls.Add(this.showconfcb);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.printbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pickingfrm";
            this.Text = "Pickingfrm";
            ((System.ComponentModel.ISupportInitialize)(this.pickingdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printdg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.CheckBox showconfcb;
        private System.Windows.Forms.DataGridView pickingdg;
        private System.Windows.Forms.DataGridView printdg;
    }
}