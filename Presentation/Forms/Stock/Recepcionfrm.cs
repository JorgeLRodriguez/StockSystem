using Domain.Models;
using Domain.Services;
using Entities;
using Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Impresion;

namespace UI.Stock
{
    public partial class Recepcionfrm : Form
    {
        private readonly ComprobanteService CbteS;
        private readonly ClienteService CnteS;
        private readonly ArticuloService ArcS;
        private printcompfrm printcompfrm;
        public Recepcionfrm()
        {
            InitializeComponent();
            CbteS = new ComprobanteService();
            CnteS = new ClienteService();
            ArcS = new ArticuloService();
        }
        private static Recepcionfrm instance = null;
        public static Recepcionfrm getInstance()
        {
            return instance = instance ?? new Recepcionfrm();
        }
        private void Recepcionfrm_Load(object sender, EventArgs e)
        {
            var list = CnteS.Get();
            clientcbx.DisplayMember = "Descripcion";
            clientcbx.ValueMember = "Id";
            clientcbx.DataSource = list;
            load_language();
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
                var list = ArcS.GetbyClient(Int32.Parse(clientcbx.SelectedValue.ToString()));
                articlecbdg.DisplayMember = "Descripcion";
                articlecbdg.ValueMember = "ID";
                articlecbdg.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, strings.Atencion, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            invdetdataGrid.EndEdit();
            try
            {
                Comprobante comprobante = new Comprobante
                {
                    id_cliente = Int32.Parse(clientcbx.SelectedValue.ToString()),
                    id_tipo_comprobante = typetxt.Text,
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
                            id_articulo = id_articulo,
                            cantidad = cantidad,
                            linea = row.Index + 1,
                        };
                        comprobanteDetalles.Add(comprobanteDetalle);
                    }
                }
                comprobante.ComprobanteDetalle = comprobanteDetalles;
                comprobante = CbteS.Create(comprobante);
                MessageBox.Show(strings.ComprobanteGenerado, strings.ProcesoCorrecto, MessageBoxButtons.OK);
                printcompfrm = new printcompfrm(comprobante);
                printcompfrm.Show();
                reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, strings.Atencion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void load_language()
        {
            invdetdataGrid.Columns[0].HeaderText = strings.Articulos.Substring(0, strings.Articulos.Length - 1);
            invdetdataGrid.Columns[1].HeaderText = strings.Cantidad;
            vouchertypelb.Text = strings.Tipo;
            letterlab.Text = strings.Letra;
            clientlab.Text = strings.Cliente;
            datelab.Text = strings.Fecha;
            invlab.Text = strings.Remito + " #";
            addbtn.Text = strings.Agregar;
            deletebtn.Text = strings.Eliminar;
            savebtn.Text = strings.Guardar;
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
    }
}