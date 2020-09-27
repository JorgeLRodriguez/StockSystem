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

namespace UI.Stock
{
    public partial class Recepcionfrm : Form
    {

        private readonly ComprobanteService VoucherService = new ComprobanteService();
        public Recepcionfrm()
        {
            InitializeComponent();
        }
        private static Recepcionfrm instance = null;
        public static Recepcionfrm getInstance()
        {
            if (instance == null) { instance = new Recepcionfrm(); }
            return instance;
        }
        private void Recepcionfrm_Load(object sender, EventArgs e)
        {
            ClienteModel clientModel = new ClienteModel();
            var list = clientModel.Get();
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
            if (clientcbx.SelectedValue != null)
            {
                ArticuloService articleService = new ArticuloService();
                var list = articleService.Get().FindAll(e => e.IdCliente == Int32.Parse(clientcbx.SelectedValue.ToString()));
                if (!list.Any())
                {
                    MessageBox.Show("El Cliente elegido no tiene artículos cargados en el sistema", strings.Atencion, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataGridViewComboBoxColumn articlecbdg = invdetdataGrid.Columns[0] as DataGridViewComboBoxColumn;
                articlecbdg.DisplayMember = "Descripcion";
                articlecbdg.ValueMember = "ID";
                articlecbdg.DataSource = list;
            }
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(numbertxt.Text)) throw new Exception(strings.ErrorCampoVacio);
                if (!ValidateNumber(numbertxt.Text)) throw new Exception(strings.ErrorValorNumerico+": "+invlab.Text);

                Comprobante comprobante = new Comprobante
                {
                    id_cliente = Int32.Parse(clientcbx.SelectedValue.ToString()),
                    id_tipo_comprobante = typetxt.Text,
                    letra_comprobante = lettertxt.Text,
                    suc_comprobante = int.Parse(subsidiarytxt.Text),
                    nro_remito_cliente = numbertxt.Text,
                    fecha_comprobante = voucherPicker.Value,
                    CreatedBy = Environment.UserName,
                    CreatedOn = DateTime.Now
                };

                if (invdetdataGrid.Rows.Count == 0) throw new Exception("Debe ingresar líneas."); //agregar string

                List<ComprobanteDetalle> comprobanteDetalles = new List<ComprobanteDetalle>();

                foreach (DataGridViewRow row in invdetdataGrid.Rows)
                {
                    if (String.IsNullOrEmpty(row.Cells[0].EditedFormattedValue.ToString()) || String.IsNullOrEmpty(row.Cells[1].EditedFormattedValue.ToString())) throw new NullReferenceException(strings.ErrorCampoVacio);
                    ComprobanteDetalle comprobanteDetalle = new ComprobanteDetalle
                    {
                        id_articulo = (int)row.Cells[0].Value,
                        cantidad = Int32.Parse(row.Cells[1].EditedFormattedValue.ToString()),
                        id_tipo_rechazo = 1,
                        linea = row.Index,
                        id_pallet = 111,
                        CreatedBy = Environment.UserName,
                        CreatedOn = DateTime.Now
                    };
                    comprobanteDetalles.Add(comprobanteDetalle);
                }
                comprobante.ComprobanteDetalle = comprobanteDetalles;
                VoucherService.Create(comprobante);
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
        private bool ValidateNumber(String value)
        {
            if (!int.TryParse(value.ToString(), out int number))
            {
                return false;
            }
            return true;
        }
    }
}