using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Forms.Impresion;
using System.Threading;

namespace UI.Stock
{
    public partial class Recepcionfrm : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static Recepcionfrm _instance = null;
        //private printcompfrm printcompfrm;
        //private printetiq printetiq;
        private Recepcionfrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static Recepcionfrm getInstance(IServiciosAplicacion serviciosAplicacion)
        {
            return _instance = _instance ?? new Recepcionfrm(serviciosAplicacion);
        }
        private void Recepcionfrm_Load(object sender, EventArgs e)
        {
            var list = _serviciosAplicacion.Cliente.Get();
            clientcbx.DisplayMember = "Descripcion";
            clientcbx.ValueMember = "Id";
            clientcbx.DataSource = list;
        }
        private void clientcbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_Articles();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            invdetdataGrid.Rows.Add();
        }
        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (invdetdataGrid.Rows.Count == 0) return;
            invdetdataGrid.Rows.Remove(invdetdataGrid.CurrentRow);
        }
        private void list_Articles()
        {
            try
            {
                DataGridViewComboBoxColumn articlecbdg = invdetdataGrid.Columns[0] as DataGridViewComboBoxColumn;
                var list = _serviciosAplicacion.Articulo.GetByClient(int.Parse(clientcbx.SelectedValue.ToString()));
                articlecbdg.DisplayMember = "Descripcion";
                articlecbdg.ValueMember = "ID";
                articlecbdg.DataSource = list;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "strings.Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            invdetdataGrid.EndEdit();
            try
            {
                Comprobante comprobante = new Comprobante
                {
                    Cliente_ID = Int32.Parse(clientcbx.SelectedValue.ToString()),
                    id_tipo_comprobante = "SIR",
                    letra_comprobante = lettertxt.Text,
                    suc_comprobante = int.Parse(subsidiarytxt.Text),
                    nro_remito_cliente = (maskednumber.Text).ToString().Trim(),
                    fecha_comprobante = voucherPicker.Value,
                    CreatedBy = Environment.UserName,
                    CreatedOn = DateTime.Now
                };

                List<ComprobanteDetalle> comprobanteDetalles = new List<ComprobanteDetalle>();
                if (invdetdataGrid.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in invdetdataGrid.Rows)
                    {
                        int cantidad = String.IsNullOrEmpty(row.Cells[1].EditedFormattedValue.ToString()) ? -1 : int.Parse(row.Cells[1].EditedFormattedValue.ToString());
                        int id_articulo = String.IsNullOrEmpty(row.Cells[0].EditedFormattedValue.ToString()) ? -1 : (int)row.Cells[0].Value;

                        ComprobanteDetalle comprobanteDetalle = new ComprobanteDetalle
                        {
                            Articulo_ID = id_articulo,
                            cantidad = cantidad,
                            linea = row.Index + 1,
                        };
                        comprobanteDetalles.Add(comprobanteDetalle);
                    }
                }
                comprobante.ComprobanteDetalle = comprobanteDetalles;
                comprobante = _serviciosAplicacion.Comprobante.Create(comprobante);
                this.MostrarDialogoInformacion(_traductorUsuario, ConstantesTexto.ComprobanteGenerado);
                //MessageBox.Show("strings.ComprobanteGenerado", "strings.ProcesoCorrecto", MessageBoxButtons.OK);
                new printcompfrm(comprobante, _serviciosAplicacion).ShowDialog();
                new printetiq(comprobante, _serviciosAplicacion).ShowDialog();
                reset();
            }
            catch (Exception ex)
            {
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
                //MessageBox.Show(ex.Message, "strings.Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void maskednumber_Enter(object sender, EventArgs e)
        {
            maskednumber.SelectionStart = 0;
        }
        private void maskednumber_Click(object sender, EventArgs e)
        {
            maskednumber.Select(0, 0);
        }
        private void reset()
        {
            list_Articles();
            voucherPicker.ResetText();
            maskednumber.Clear();
            invdetdataGrid.Rows.Clear();
        }
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
            this.Text = _traductorUsuario.Traducir(ConstantesTexto.Recepcion);
        }
    }
}