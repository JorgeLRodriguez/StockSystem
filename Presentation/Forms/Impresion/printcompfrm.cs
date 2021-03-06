﻿using Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Domain.Contracts;
using Entities.Infraestructure;

namespace UI.Forms.Impresion
{
    public partial class printcompfrm : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private Comprobante _comprobante;
        public printcompfrm(Comprobante comprobante, IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _comprobante = comprobante;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        private void printcompfrm_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            copiacb.Items.Add(_traductorUsuario.Traducir(ConstantesTexto.Original));
            copiacb.Items.Add(_traductorUsuario.Traducir(ConstantesTexto.Duplicado));
            copiacb.Items.Add(_traductorUsuario.Traducir(ConstantesTexto.Triplicado));

            copialab.Text = _traductorUsuario.Traducir(ConstantesTexto.SeleCopia) + ":";

            ReportParameter[] reportParameters = new ReportParameter[10];

            reportParameters[0] = new ReportParameter("informe", GetNombreInforme(_comprobante.id_tipo_comprobante), true);
            reportParameters[1] = new ReportParameter("cliente", _traductorUsuario.Traducir(ConstantesTexto.Cliente), true);
            reportParameters[2] = new ReportParameter("remito", _traductorUsuario.Traducir(ConstantesTexto.Remito), true);
            reportParameters[3] = new ReportParameter("copia", _traductorUsuario.Traducir(ConstantesTexto.Original), true);
            reportParameters[4] = new ReportParameter("comprobante", _traductorUsuario.Traducir(ConstantesTexto.Comprobante), true);
            reportParameters[5] = new ReportParameter("fecha", _traductorUsuario.Traducir(ConstantesTexto.Fecha), true);
            reportParameters[6] = new ReportParameter("codigo", _traductorUsuario.Traducir(ConstantesTexto.Codigo), true);
            reportParameters[7] = new ReportParameter("descripcion", _traductorUsuario.Traducir(ConstantesTexto.Descripcion), true);
            reportParameters[8] = new ReportParameter("cantidad", _traductorUsuario.Traducir(ConstantesTexto.Cantidad), true);
            reportParameters[9] = new ReportParameter("cantidadtotal", _traductorUsuario.Traducir(ConstantesTexto.CantidadTotal), true);

            reportViewer1.LocalReport.SetParameters(reportParameters);

            BindingSource Articulo = new BindingSource();
            BindingSource Comprobante = new BindingSource();
            BindingSource ComprobanteDetalle = new BindingSource();
            BindingSource Cliente = new BindingSource();
            BindingSource TipoRechazo = new BindingSource();

            Articulo.DataSource = _comprobante.ComprobanteDetalle.Select(x => x.Articulo);
            Comprobante.DataSource = _comprobante;
            ComprobanteDetalle.DataSource = _comprobante.ComprobanteDetalle;
            Cliente.DataSource = _comprobante.Cliente;
            TipoRechazo.DataSource = _comprobante.ComprobanteDetalle.Select(x => x.TipoRechazo ?? new TipoRechazo());

            ReportDataSource ArticuloDS = new ReportDataSource("Articulo", Articulo);
            ReportDataSource ComprobanteDS = new ReportDataSource("Comprobante", Comprobante);
            ReportDataSource ComprobanteDetalleDS = new ReportDataSource("ComprobanteDetalle", ComprobanteDetalle);
            ReportDataSource ClienteDS = new ReportDataSource("Cliente", Cliente);
            ReportDataSource TipoRechazoDS = new ReportDataSource("TipoRechazo", TipoRechazo);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ArticuloDS);
            this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDS);
            this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDetalleDS);
            this.reportViewer1.LocalReport.DataSources.Add(ClienteDS);
            this.reportViewer1.LocalReport.DataSources.Add(TipoRechazoDS);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            Cursor = Cursors.Default;
        }
        private void copiacb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportParameter reportParameter = new ReportParameter("copia", copiacb.SelectedItem.ToString(), true);
            reportViewer1.LocalReport.SetParameters(reportParameter);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
        private string GetNombreInforme(string tipoComprobante)
        {
            switch (tipoComprobante)
            {
                case "SIR":
                    return _traductorUsuario.Traducir(ConstantesTexto.InformeRecepcion);
                case "SIS":
                    return _traductorUsuario.Traducir(ConstantesTexto.InformeScaneo);
                default:
                    return String.Empty;
            }
        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            this.Text = _traductorUsuario.Traducir(ConstantesTexto.ImpComprobante);
        }
    }
}