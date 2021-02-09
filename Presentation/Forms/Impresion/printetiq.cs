using Domain.Contracts;
using Entities;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI.Forms.Impresion
{
    public partial class printetiq : Form, ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private Comprobante C;
        public printetiq(Comprobante comprobante, IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            C = comprobante;
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            
        }
        private void printetiq_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            IEnumerable<Etiqueta> E;
            try
            {
                BindingSource Comprobante = new BindingSource();
                BindingSource Cliente = new BindingSource();
                BindingSource Articulo = new BindingSource();
                BindingSource Etiqueta = new BindingSource();

                //_serviciosAplicacion.Etiqueta.Create(C);
                //E = _serviciosAplicacion.Etiqueta.GetbyIDComp(C);
                C = _serviciosAplicacion.Comprobante.GetComprobanteByID(C.ID);

                Articulo.DataSource = C.ComprobanteDetalle.Select(x => x.Articulo);
                Comprobante.DataSource = C;
                Etiqueta.DataSource = C.Etiquetas.ToList();
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
