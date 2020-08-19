using Domain.Models;
using Domain.Services;
using Entities;
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
        private VoucherService VoucherService = new VoucherService();
        private VoucherModel VoucherModel = new VoucherModel();
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
            ClientModel clientModel = new ClientModel();
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
            if (invdetdataGrid.Rows.Count == 0)
            {
                return;
            }
            invdetdataGrid.Rows.Remove(invdetdataGrid.CurrentRow);
        }
        private void list_Articles()
        {
            if (clientcbx.SelectedValue != null)
            {
                ArticleService articleService = new ArticleService();
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
        private void invdetdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Comprobante comprobante = new Comprobante();

                comprobante.id_cliente = Int32.Parse(clientcbx.SelectedValue.ToString());
                comprobante.id_tipo_comprobante = typetxt.Text;
                comprobante.letra_comprobante = lettertxt.Text;
                comprobante.suc_comprobante = int.Parse(subsidiarytxt.Text);
                comprobante.nro_remito_cliente = numbertxt.Text;
                comprobante.fecha_comprobante = voucherPicker.Value;
                comprobante.CreatedBy = Environment.UserName;
                comprobante.CreatedOn = DateTime.Now;

                List<ComprobanteDetalle> comprobanteDetalles = new List<ComprobanteDetalle>();

                foreach (DataGridViewRow row in invdetdataGrid.Rows)
                {
                    ComprobanteDetalle comprobanteDetalle = new ComprobanteDetalle();
                    comprobanteDetalle.id_articulo = (int)row.Cells[0].Value;
                    comprobanteDetalle.cantidad = Int32.Parse(row.Cells[1].EditedFormattedValue.ToString());
                    comprobanteDetalle.id_tipo_rechazo = 1;
                    comprobanteDetalle.linea = row.Index;
                    comprobanteDetalle.id_pallet = 111;
                    comprobanteDetalle.CreatedBy = Environment.UserName;
                    comprobanteDetalle.CreatedOn = DateTime.Now;
                    comprobanteDetalles.Add(comprobanteDetalle);
                }
                comprobante.ComprobanteDetalle = comprobanteDetalles;
                VoucherService.Create(comprobante);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, strings.Atencion);
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
    }
}