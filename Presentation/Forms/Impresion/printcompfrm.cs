using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Services;
using Microsoft.Reporting.WinForms;
using System.IO;
using Microsoft.ReportingServices.Diagnostics.Internal;
using Language;

namespace UI.Forms.Impresion
{
    public partial class printcompfrm : Form
    {
        private ArticuloService AS;
        private ComprobanteService CS;
        public printcompfrm()
        {
            InitializeComponent();
            AS = new ArticuloService();
            CS = new ComprobanteService();
        }

        private void printcompfrm_Load(object sender, EventArgs e)
        {
            ReportParameter[] reportParameters = new ReportParameter[9];

            reportParameters[0] = new ReportParameter("informe", "Informe de Recepción", true);
            reportParameters[1] = new ReportParameter("cliente", strings.Cliente, true);
            reportParameters[2] = new ReportParameter("remito", strings.Remito, true);
            reportParameters[3] = new ReportParameter("copia", "Original", true);
            reportParameters[4] = new ReportParameter("comprobante", strings.Comprobante, true);
            reportParameters[5] = new ReportParameter("fecha", strings.Fecha, true);
            reportParameters[6] = new ReportParameter("codigo", "codigo", true);
            reportParameters[7] = new ReportParameter("descripcion", strings.Descripcion, true);
            reportParameters[8] = new ReportParameter("cantidad", strings.Cantidad, true);

            reportViewer1.LocalReport.SetParameters(reportParameters);

            BindingSource Articulo = new BindingSource();
            BindingSource Comprobante = new BindingSource();
            BindingSource ComprobanteDetalle = new BindingSource();

            Articulo.DataSource = AS.GetbyID(1);
            Comprobante.DataSource = CS.GetComprobante("a", "a", 1, 1);
            ComprobanteDetalle.DataSource = CS.GetComprobante("a", "a", 1, 1).ComprobanteDetalle;

            ReportDataSource ArticuloDS = new ReportDataSource("Articulo", Articulo);
            ReportDataSource ComprobanteDS = new ReportDataSource("Comprobante", Comprobante);
            ReportDataSource ComprobanteDetalleDS = new ReportDataSource("ComprobanteDetalle", ComprobanteDetalle);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ArticuloDS);
            this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDS);
            this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDetalleDS);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

            //        http://datazarblog.blogspot.com/2018/04/como-generar-un-reporte-con-parametros.html
            //https://si.ua.es/es/documentacion/informes-net/documentos/apuntes-de-referencia/origen-de-datos.pdf
            //http://joseluisgarciab.blogspot.com/2013/10/reportviewer-y-rdlc-ejemplo-facturacion.html
            //https://es.stackoverflow.com/questions/352717/reporte-sencillo-en-reportviewer-c-a%C3%B1adir-campos-de-2-datasets-distintos

        }
    }
}
