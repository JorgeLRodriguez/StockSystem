using Domain.Services;
using Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms.Impresion
{
    public partial class printetiq : Form
    {
        private EtiquetaService ES;
        private ComprobanteService CS;
        private IEnumerable<Etiqueta> E;
        private Comprobante C;
        public printetiq(Comprobante comprobante)
        {
            InitializeComponent();
            ES = new EtiquetaService();
            CS = new ComprobanteService();
            C = comprobante;
        }
        private void printetiq_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                BindingSource Comprobante = new BindingSource();
                BindingSource Cliente = new BindingSource();
                BindingSource Articulo = new BindingSource();
                BindingSource Etiqueta = new BindingSource();

                ES.Create(C);
                E = ES.GetbyIDComp(C);
                C = CS.GetComprobanteByID(C.ID);

                Articulo.DataSource = C.ComprobanteDetalle.Select(x => x.Articulo);
                Comprobante.DataSource = C;
                Etiqueta.DataSource = E.ToList();
                Cliente.DataSource = C.Cliente;

                ReportDataSource ArticuloDS = new ReportDataSource("Articulo", Articulo);
                ReportDataSource ComprobanteDS = new ReportDataSource("Comprobante", Comprobante);
                ReportDataSource EtiquetaDS = new ReportDataSource("Etiqueta", Etiqueta);
                ReportDataSource ClienteDS = new ReportDataSource("Cliente", Cliente);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(ArticuloDS);
                this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDS);
                this.reportViewer1.LocalReport.DataSources.Add(EtiquetaDS);
                this.reportViewer1.LocalReport.DataSources.Add(ClienteDS);
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
                Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {

            }
        }
    }
}
