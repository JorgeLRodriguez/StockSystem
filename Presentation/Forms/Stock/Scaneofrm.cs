using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UI.Forms.Impresion;

namespace UI.Stock
{
    public partial class Scaneofrm : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private List<TipoRechazo> _tipoRechazo;
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
        private void Scaneofrm_Load(object sender, EventArgs e)
        {
            Inicio();
        }
        private void CargarTiposRechazo()
        {
            _tipoRechazo = _serviciosAplicacion.Comprobante.GetTipoRechazo(_traductorUsuario).ToList();
            reasoncb.DisplayMember = "Descripcion";
            reasoncb.ValueMember = "ID";
            reasoncb.DataSource = _tipoRechazo;
            reasoncb.SelectedValue = 4;
        }
        private void CargarComprobante()
        {
            try
            {
                receiptcb.DisplayMember = "Descripcion";
                receiptcb.ValueMember = "ID";
                receiptcb.DataSource = _serviciosAplicacion.Comprobante.GetComprobanteScaneo().ToList();
            }
            catch(Exception ex)
            {
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
            }
        }
        private void receiptcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            maindg.Rows.Clear();
            scandg.Rows.Clear();
            receiptdg.Rows.Clear();
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
        private bool CompararScanConCodigo (string _codBarra)
        {
            foreach (var detalle in ((Comprobante)receiptcb.SelectedItem).ComprobanteDetalle.ToList())
            {
                if (detalle.Articulo.codigo_barra.Equals(_codBarra))
                {
                    foreach (DataGridViewRow row in maindg.Rows)
                    {
                        if(row.Cells[0].Value.Equals(detalle.linea) 
                            && row.Cells[1].Value.Equals(detalle.Articulo.BarraDesc)
                            && !row.Cells[2].Value.Equals(row.Cells[3].Value))
                        {
                            LoadScan(row.Cells[3], detalle);
                            return true;
                        }
                    }
                }
            }
            return false;
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
        private void LoadScan(DataGridViewCell cell, ComprobanteDetalle detalle)
        {
            int cant = 0;
            if (completecb.Checked) 
            {
                cant = detalle.cantidad - Convert.ToInt32(cell.Value);
                cell.Value = detalle.cantidad;
            }
            else
            {
                cant = 1;
                cell.Value = Convert.ToInt32(cell.Value) + 1;
            }
            LoadScandg(detalle, cant);
            LoadComp(detalle, cant);
        }
        private void LoadScandg(ComprobanteDetalle comprobanteDetalle, int cantidad)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                scandg.Rows.Add
                (
                scandg.RowCount + 1,
                comprobanteDetalle.Articulo.Codigo_fs,
                ((TipoRechazo)reasoncb.SelectedItem).Descripcion,
                _traductorUsuario.Traducir(ConstantesTexto.Suprimir)
                );
            }      
        }
        private void LoadComp(ComprobanteDetalle comprobanteDetalle, int cantidad)
        {
            foreach (DataGridViewRow row in receiptdg.Rows)
            {
                if (row.Cells[0].Value.Equals(comprobanteDetalle.Articulo.Codigo_fs)
                    && row.Cells[1].Value.Equals(((TipoRechazo)reasoncb.SelectedItem).ID))
                {
                    row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) + cantidad;
                    return;
                }
            }
            receiptdg.Rows.Add
            (
            comprobanteDetalle.Articulo.Codigo_fs,
            ((TipoRechazo)reasoncb.SelectedItem).ID,
            cantidad,
            //
            comprobanteDetalle.Articulo_ID
            );
        }
        private void UpdateMaindg (string barraDesc)
        {
            foreach (DataGridViewRow row in maindg.Rows)
            {
                if (row.Cells[1].Value.Equals(barraDesc)
                    && Convert.ToInt32(row.Cells[3].Value) > 0)
                {
                    row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) - 1;
                    return;
                }
            }
        }
        private void UpdateReceiptdg (string codigo, string tipoDesc)
        {
            foreach (DataGridViewRow row in receiptdg.Rows)
            {
                if (row.Cells[0].Value.Equals(codigo)
                    && row.Cells[1].Value.Equals
                    (_tipoRechazo
                    .Where(t => t.Descripcion.Equals(tipoDesc))
                    .Select(t => t.ID).FirstOrDefault()))
                {
                    row.Cells[2].Value = Convert.ToInt32(row.Cells[2].Value) - 1;
                    if (row.Cells[2].Value.Equals(0)) receiptdg.Rows.Remove(row);
                    return;
                }
            }
        }
        private bool CountScans()
        {
            foreach(DataGridViewRow row in maindg.Rows)
            {
                if (!row.Cells[2].Value.Equals(row.Cells[3].Value))
                {
                    return false;
                }
            }
            return true;
        }
        private void Inicio()
        {
            maindg.Rows.Clear();
            scandg.Rows.Clear();
            receiptdg.Rows.Clear();
            CargarTiposRechazo();
            CargarComprobante();
        }
        private void scandg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                string tipoDesc = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
                string codigo = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
                string barraDesc = ((Comprobante)receiptcb.SelectedItem).ComprobanteDetalle
                    .Where(cd => cd.Articulo.Codigo_fs == codigo)
                    .Select(cd => cd.Articulo.BarraDesc)
                    .FirstOrDefault();
                scandg.Rows.Remove(scandg.Rows[e.RowIndex]);
                UpdateMaindg(barraDesc);
                UpdateReceiptdg(codigo, tipoDesc);
            }
        }
        private void codetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!CompararScanConCodigo(codetxt.Text)) codetxt.Text = "";
                codetxt.SelectAll();
            }
        }
        private void dcbtn_Click(object sender, EventArgs e)
        {
            if (!CountScans()) { this.MostrarDialogoAdvertencia(_traductorUsuario, ConstantesTexto.AtItemSinScan); return; }
            try
            {
                var comp = (Comprobante)receiptcb.SelectedItem;
                Comprobante C = new Comprobante()
                {
                    Cliente_ID = comp.Cliente_ID,
                    id_tipo_comprobante = TipoComprobante.SIS.ToString(),
                    letra_comprobante = comp.letra_comprobante,
                    suc_comprobante = comp.suc_comprobante,
                    nro_remito_cliente = comp.nro_remito_cliente,
                    cierre = "D",
                    fecha_comprobante = DateTime.Now,
                };
                List<ComprobanteDetalle> CD = new List<ComprobanteDetalle>();
                if (maindg.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in receiptdg.Rows)
                    {
                        CD.Add(new ComprobanteDetalle()
                        {
                            Articulo_ID = Convert.ToInt32(row.Cells[3].Value),
                            linea =  row.Index + 1,
                            cantidad = Convert.ToInt32(row.Cells[2].Value),
                            id_tipo_rechazo = Convert.ToInt32(row.Cells[1].Value),
                            TipoRechazo = _tipoRechazo.Where(x => x.ID.Equals(row.Cells[1].Value)).FirstOrDefault()
                        });
                    }
                }
                C.ComprobanteDetalle = CD;
                C = _serviciosAplicacion.Comprobante.Create(C);
                comp.cierre = "D";
                _serviciosAplicacion.Comprobante.Update(comp);
                this.MostrarDialogoInformacion(_traductorUsuario, ConstantesTexto.ComprobanteGenerado);
                new printcompfrm(C, _serviciosAplicacion).ShowDialog();
                Inicio();
            }
            catch (Exception ex)
            {
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
            }
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
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
            receiptdg.Columns[0].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Codigo);
            receiptdg.Columns[1].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Motivo);
            receiptdg.Columns[2].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Cantidad);
            receiptlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Comprobante);
            reasonlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Motivo);
            voucherlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Comprobante);
            completecb.Text = _traductorUsuario.Traducir(ConstantesTexto.ComplCant);
            dcbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Cierre);
            expedbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Expedicion);
            CargarTiposRechazo();
        }
    }
}