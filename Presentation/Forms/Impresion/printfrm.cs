using Domain.Contracts;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace UI.Forms.Impresion
{
    public partial class printfrm : Form
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        PrintPreviewDialog PrintPreviewDialog = new PrintPreviewDialog();
        PrintDocument printDocument = new PrintDocument();
        Bitmap bitmap;
        DataGridView data;
        private Articulo articulo;
        public printfrm(DataGridView dataGridView, IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            data = dataGridView;
            articulo = new Articulo();
            loaddg(data);
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
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
                articulo = _serviciosAplicacion.Articulo.GetByID(ID);
                dataGriddata.Rows[index].Cells[0].Value = articulo.Codigo_fs;
                dataGriddata.Rows[index].Cells[1].Value = articulo.Descripcion;
                dataGriddata.Rows[index].Cells[2].Value = row.Cells[1].Value;

            }
        }
    }
}
