using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class Scaneofrm : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private List<Comprobante> Comprobantes;
        private List<TipoRechazo> TipoRechazos;
        private static Scaneofrm _instance = null;
        public Scaneofrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static Scaneofrm getInstance(IServiciosAplicacion serviciosAplicacion)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new Scaneofrm(serviciosAplicacion);
            return _instance;
        }
        private void CargarTiposRechazo()
        {
            TipoRechazos = _serviciosAplicacion.Comprobante.GetTipoRechazo(_traductorUsuario).ToList();
            reasoncb.DisplayMember = "Descripcion";
            reasoncb.ValueMember = "ID";
            reasoncb.DataSource = TipoRechazos;
            reasoncb.SelectedValue = 4;
        }
        private void CargarComprobante()
        {
            try
            {
                Comprobantes = _serviciosAplicacion.Comprobante.GetComprobanteScaneo().ToList();
                receiptcb.DisplayMember = "Descripcion";
                receiptcb.ValueMember = "ID";
                receiptcb.DataSource = Comprobantes;
            }
            catch(Exception ex)
            {
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
            }
        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            maindg.Columns[0].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Linea);
            maindg.Columns[1].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Articulos).Substring(0, _traductorUsuario.Traducir(ConstantesTexto.Articulos).Length - 1);
            maindg.Columns[2].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Cantidad);
            maindg.Columns[3].HeaderText = "Scan";
            scandg.Columns[0].HeaderText = "#";
            scandg.Columns[1].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Codigo);
            scandg.Columns[2].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Motivo);
            receiptlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Comprobante);
            reasonlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Motivo);
            voucherlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Comprobante);
            completecb.Text = _traductorUsuario.Traducir(ConstantesTexto.ComplCant);
            pcbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.CierreParcial);
            dcbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.CierreDef);
            expedbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Expedicion);
            CargarTiposRechazo();
        }
        private void Scaneofrm_Load(object sender, EventArgs e)
        {
            CargarTiposRechazo();
            CargarComprobante();
        }
        private void receiptcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            maindg.Rows.Clear();
            var comprobante = (Comprobante)receiptcb.SelectedItem;
            comprobante.ComprobanteDetalle.ToList().ForEach(x => LoadMainDg(x));
            if (comprobante.id_tipo_comprobante.Equals(TipoComprobante.SPK.ToString()))
            {
                expedbtn.Visible = true;
            }
            else
            {
                expedbtn.Visible = false;
            }
        }
        private void CompararScanConCodigo (string _codBarra)
        {
            var comprobanteDetalles = ((Comprobante)receiptcb.SelectedItem).ComprobanteDetalle.ToList();

            foreach (var detalle in comprobanteDetalles)
            {
                if (detalle.Articulo.codigo_barra.Equals(_codBarra)) LoadScandg(detalle);
            }
        }
        private void LoadMainDg(ComprobanteDetalle comprobanteDetalle)
        {
            maindg.Rows.Add(
                comprobanteDetalle.linea,
                comprobanteDetalle.Articulo.BarraDesc,
                comprobanteDetalle.cantidad,
                0
                );
        }
        private void LoadScandg(ComprobanteDetalle comprobanteDetalle)
        {
            scandg.Rows.Add(
                scandg.RowCount + 1,
                comprobanteDetalle.Articulo.Codigo_fs,
                ((TipoRechazo)reasoncb.SelectedItem).Descripcion,
                _traductorUsuario.Traducir(ConstantesTexto.Suprimir)
                );
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void codetxt_TextChanged(object sender, EventArgs e)
        {
            CompararScanConCodigo(codetxt.Text);
            codetxt.SelectAll();

        }
        private void scandg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                scandg.Rows.Remove(scandg.Rows[e.RowIndex]);
            }
        }
    }
}
