using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class Pickingfrm : Form, ISubscriptorCambioIdioma
    {
        #region FormSettings
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static Pickingfrm _instance = null;
        private Comprobante C = new Comprobante();
        private IEnumerable<Comprobante> list;
        public Pickingfrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static Pickingfrm GetInstance(IServiciosAplicacion serviciosAplicacion)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new Pickingfrm(serviciosAplicacion);
            return _instance;
        }
        #endregion
        #region FormActions
        private void printbtn_Click(object sender, EventArgs e)
        {
            if (SavePDF(reportViewer1))
            {
                try
                {
                    UpdateComp("I", C);
                }
                catch (Exception ex)
                {
                    this.MostrarDialogoError(_traductorUsuario, ex.Message);
                }
            }
        }
        private void maindg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            C = list.Where(x => x.Descripcion.Equals(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString()))
                    .FirstOrDefault();
            EnabledButtons(C);
            LoadReportViewerData(C);
        }
        private void confirmbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, _traductorUsuario.Traducir(ConstantesTexto.ConfComprobante), this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    UpdateComp("C", C);
                    this.MostrarDialogoInformacion(_traductorUsuario, ConstantesTexto.ProcCorrecto);
                }
                catch (Exception ex)
                {
                    this.MostrarDialogoError(_traductorUsuario, ex.Message);
                }
            }
        }
        #endregion
        #region PrivateFunctions
        private void CargarComprobantes()
        {
            list = _serviciosAplicacion.Comprobante.GetComprobantePicking();
            foreach (var item in list)
            {
                maindg.Rows.Add(
                    item.Cliente.Descripcion,
                    item.Descripcion,
                    item.fecha_comprobante,
                    GetStatus(item.cierre)
                    );         
            }
        }
        private string GetStatus(string cierre)
        {
            switch (cierre)
            {
                case "I":
                    return _traductorUsuario.Traducir(ConstantesTexto.Impreso);
                case "C":
                    return _traductorUsuario.Traducir(ConstantesTexto.Conf);
                case "D":
                    return _traductorUsuario.Traducir(ConstantesTexto.Despachado);
                default:
                    return _traductorUsuario.Traducir(ConstantesTexto.NoImpreso);
            }
        }
        private void LoadReportViewerParameters()
        {
            ReportParameter[] reportParameters = new ReportParameter[12];
            reportParameters[0] = new ReportParameter("informe", _traductorUsuario.Traducir(ConstantesTexto.InformePicking), true);
            reportParameters[1] = new ReportParameter("cliente", _traductorUsuario.Traducir(ConstantesTexto.Cliente), true);
            reportParameters[2] = new ReportParameter("remito", _traductorUsuario.Traducir(ConstantesTexto.Remito), true);
            reportParameters[3] = new ReportParameter("copia", _traductorUsuario.Traducir(ConstantesTexto.Original), true);
            reportParameters[4] = new ReportParameter("comprobante", _traductorUsuario.Traducir(ConstantesTexto.Comprobante), true);
            reportParameters[5] = new ReportParameter("fecha", _traductorUsuario.Traducir(ConstantesTexto.Fecha), true);
            reportParameters[6] = new ReportParameter("codigo", _traductorUsuario.Traducir(ConstantesTexto.Codigo), true);
            reportParameters[7] = new ReportParameter("descripcion", _traductorUsuario.Traducir(ConstantesTexto.Descripcion), true);
            reportParameters[8] = new ReportParameter("cantidad", _traductorUsuario.Traducir(ConstantesTexto.Cantidad), true);
            reportParameters[9] = new ReportParameter("cantidadtotal", _traductorUsuario.Traducir(ConstantesTexto.CantidadTotal), true);
            reportParameters[10] = new ReportParameter("destinatario", _traductorUsuario.Traducir(ConstantesTexto.Destinatario), true);
            reportParameters[11] = new ReportParameter("cp", _traductorUsuario.Traducir(ConstantesTexto.CodigoPostal), true);
            reportViewer1.LocalReport.SetParameters(reportParameters);
        }
        private void LoadReportViewerData(Comprobante _comprobante)
        {
            Cursor = Cursors.WaitCursor;
            BindingSource Articulo = new BindingSource();
            BindingSource Comprobante = new BindingSource();
            BindingSource ComprobanteDetalle = new BindingSource();
            BindingSource Cliente = new BindingSource();
            BindingSource TipoRechazo = new BindingSource();
            BindingSource Destinatario = new BindingSource();
            Articulo.DataSource = _comprobante.ComprobanteDetalle.Select(x => x.Articulo);
            Comprobante.DataSource = _comprobante;
            ComprobanteDetalle.DataSource = _comprobante.ComprobanteDetalle;
            Cliente.DataSource = _comprobante.Cliente;
            TipoRechazo.DataSource = _comprobante.ComprobanteDetalle.Select(x => x.TipoRechazo ?? new TipoRechazo());
            Destinatario.DataSource = _comprobante.Destinatario;
            ReportDataSource ArticuloDS = new ReportDataSource(nameof(Articulo), Articulo);
            ReportDataSource ComprobanteDS = new ReportDataSource(nameof(Comprobante), Comprobante);
            ReportDataSource ComprobanteDetalleDS = new ReportDataSource(nameof(ComprobanteDetalle), ComprobanteDetalle);
            ReportDataSource ClienteDS = new ReportDataSource(nameof(Cliente), Cliente);
            ReportDataSource TipoRechazoDS = new ReportDataSource(nameof(TipoRechazo), TipoRechazo);
            ReportDataSource DestinatarioDS = new ReportDataSource(nameof(Destinatario), Destinatario);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(ArticuloDS);
            this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDS);
            this.reportViewer1.LocalReport.DataSources.Add(ComprobanteDetalleDS);
            this.reportViewer1.LocalReport.DataSources.Add(ClienteDS);
            this.reportViewer1.LocalReport.DataSources.Add(TipoRechazoDS);
            this.reportViewer1.LocalReport.DataSources.Add(DestinatarioDS);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
            Cursor = Cursors.Default;
        }
        private void Inicio()
        {
            maindg.Rows.Clear();
            CargarComprobantes();
            LoadReportViewerParameters();
            C = list.FirstOrDefault();
            EnabledButtons(C);
            LoadReportViewerData(C);
            reportViewer1.RefreshReport();
        }
        private void UpdateComp(string cierre, Comprobante C)
        {
            C.cierre = cierre;
            _serviciosAplicacion.Comprobante.Update(C);
            Inicio();
        }
        public bool SavePDF(ReportViewer viewer)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.FileName = C.Descripcion;
                save.Filter = "PDF|*.pdf";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");
                    using (FileStream stream = new FileStream(save.FileName, FileMode.Create))
                    {
                        stream.Write(Bytes, 0, Bytes.Length);
                    }
                    return true;
                }
            }
            return false;
        }
        private void EnabledButtons(Comprobante C)
        {
            if (C.cierre == null)
            {
                printbtn.Enabled = true;
                confirmbtn.Enabled = false;
            }
            else
            {
                printbtn.Enabled = false;
                confirmbtn.Enabled = true;
            }
        }
        #endregion
        #region Language
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            maindg.Columns[0].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Cliente);
            maindg.Columns[1].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Comprobante);
            maindg.Columns[2].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Fecha);
            maindg.Columns[3].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Estado);
            printbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Imprimir);
            confirmbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Conf);
            Inicio();
        }
        #endregion
    }
}
