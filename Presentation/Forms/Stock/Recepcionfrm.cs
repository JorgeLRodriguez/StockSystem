using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Forms.Impresion;

namespace UI.Stock
{
    public partial class Recepcionfrm : Form , ISubscriptorCambioIdioma
    {
        #region FormSettings
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static Recepcionfrm _instance = null;
        private Recepcionfrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static Recepcionfrm GetInstance(IServiciosAplicacion serviciosAplicacion)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new Recepcionfrm(serviciosAplicacion);
            return _instance;
        }
        #endregion
        #region FormActions
        private void Recepcionfrm_Load(object sender, EventArgs e)
        {
            ListClients();
        }
        private void Clientcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListArticles();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            invdetdataGrid.Rows.Add();
        }
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (invdetdataGrid.Rows.Count == 0) return;
            invdetdataGrid.Rows.Remove(invdetdataGrid.CurrentRow);
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            invdetdataGrid.EndEdit();
            try
            {
                Comprobante comprobante = new Comprobante
                {
                    Cliente_ID = ((Cliente)clientcbx.SelectedValue).ID,
                    id_tipo_comprobante = TipoComprobante.SIR.ToString(),
                    letra_comprobante = lettertxt.Text,
                    suc_comprobante = int.Parse(subsidiarytxt.Text),
                    nro_remito_cliente = (remitotxt.Text).ToString().Trim(),
                    fecha_comprobante = voucherPicker.Value
                };
                List<ComprobanteDetalle> comprobanteDetalles = new List<ComprobanteDetalle>();
                if (invdetdataGrid.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in invdetdataGrid.Rows)
                    {
                        comprobanteDetalles.Add(new ComprobanteDetalle()
                        {
                            Articulo_ID = String.IsNullOrEmpty(row.Cells[0].EditedFormattedValue.ToString()) ? 0 : (int)row.Cells[0].Value,
                            cantidad = String.IsNullOrEmpty(row.Cells[1].EditedFormattedValue.ToString()) ? 0 : int.Parse(row.Cells[1].EditedFormattedValue.ToString()),
                            linea = row.Index + 1,
                        });
                    }
                }
                comprobante.ComprobanteDetalle = comprobanteDetalles;
                comprobante = _serviciosAplicacion.Comprobante.Create(comprobante);
                this.MostrarDialogoInformacion(_traductorUsuario, ConstantesTexto.ComprobanteGenerado);
                new printcompfrm(comprobante, _serviciosAplicacion).ShowDialog();
                new printetiq(comprobante, _serviciosAplicacion).ShowDialog();
                Reset();
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
        #endregion
        #region PrivateFunctions
        private void ListArticles()
        {
            try
            {
                DataGridViewComboBoxColumn articlecbdg = invdetdataGrid.Columns[0] as DataGridViewComboBoxColumn;
                articlecbdg.DisplayMember = nameof(Articulo.Descripcion);
                articlecbdg.ValueMember = nameof(Articulo.ID);
                articlecbdg.DataSource = _serviciosAplicacion.Articulo.GetByClient((Cliente)clientcbx.SelectedValue);
            }
            catch (Exception ex)
            {
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
            }
        }
        private void ListClients()
        {
            clientcbx.DisplayMember = nameof(Cliente.Descripcion);
            clientcbx.DataSource = _serviciosAplicacion.Cliente.Get();
        }
        private void Reset()
        {
            ListClients();
            ListArticles();
            voucherPicker.ResetText();
            remitotxt.Clear();
            invdetdataGrid.Rows.Clear();
        }
        #endregion
        #region Language
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            invdetdataGrid.Columns[0].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Articulos).Substring(0, _traductorUsuario.Traducir(ConstantesTexto.Articulos).Length - 1);
            invdetdataGrid.Columns[1].HeaderText = _traductorUsuario.Traducir(ConstantesTexto.Cantidad);
            vouchertypelb.Text = _traductorUsuario.Traducir(ConstantesTexto.Tipo);
            letterlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Letra);
            clientlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Cliente);
            datelab.Text = _traductorUsuario.Traducir(ConstantesTexto.Fecha);
            invlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Remito) + " #";
            addbtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Agregar);
            deletebtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Eliminar);
            savebtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Guardar);
            typetxt.Text = TipoComprobante.SIR.ToString();
            this.Text = _traductorUsuario.Traducir(ConstantesTexto.Recepcion);
        }
        #endregion
    }
}