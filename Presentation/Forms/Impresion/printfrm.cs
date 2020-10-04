using Domain.Services;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Impresion
{
    public partial class printfrm : Form
    {
        PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        Bitmap bitmap;
        DataGridView data;
        private readonly ArticuloService ArcS;
        private Articulo articulo;
        public printfrm(DataGridView dataGridView)
        {
            InitializeComponent();
            data = dataGridView;
            ArcS = new ArticuloService();
            articulo = new Articulo();
            loaddg(data);
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            Print(this.printpanel);
        }
        private void Print (Panel panel)
        {
            PrinterSettings printerSettings = new PrinterSettings();
            printpanel = panel;
            bitmap = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bitmap, new Rectangle(0, 0, panel.Width, panel.Height));
            PrintPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_printPage);
            PrintPreviewDialog.ShowDialog();
        }
        private void printDocument_printPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(bitmap, (pagearea.Width/2) - (this.printpanel.Width/2), this.printpanel.Location.Y);
        }

        private void loaddg(DataGridView dataGridView)
        {
            dataGridView = data;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int index = dataGriddata.Rows.Add();
                int ID = Convert.ToInt32(row.Cells[index].Value.ToString());
                articulo = ArcS.GetbyID(ID);
                dataGriddata.Rows[index].Cells[0].Value = articulo.Codigo_fs;
                dataGriddata.Rows[index].Cells[1].Value = articulo.Descripcion;
                dataGriddata.Rows[index].Cells[2].Value = row.Cells[1].Value;

            }
        }

    }
}
