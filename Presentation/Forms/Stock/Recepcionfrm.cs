﻿using Domain.Models;
using Domain.Services;
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
        private ClientModel clientModel = new ClientModel();
        private ArticleService articleService = new ArticleService();
        private VoucherService VoucherService = new VoucherService();
        private VoucherModel VoucherModel = new VoucherModel();
        private VoucherDetailModel VoucherDetail = new VoucherDetailModel();
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
            var list = clientModel.Get();
            clientcbx.DisplayMember = "Descripcion";
            clientcbx.ValueMember = "Id";
            clientcbx.DataSource = list;
            invdetdataGrid.Columns[0].HeaderText = "Articulo"; //cambiar por string
            invdetdataGrid.Columns[1].HeaderText = "Cantidad"; //cambiar por string
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

            List<VoucherDetailModel> voucherDetailList = new List<VoucherDetailModel>();
            VoucherModel.Id_cliente = Int32.Parse(clientcbx.SelectedValue.ToString());
            VoucherModel.Id_tipo_comprobante = typetxt.Text;
            VoucherModel.Letra_comprobante = lettertxt.Text;
            VoucherModel.Nro_remito_cliente = numbertxt.Text;
            VoucherModel.Num_comprobante = 1;
            VoucherModel.Observaciones = "Prueba";
            VoucherModel.Suc_comprobante = Int16.Parse(subsidiarytxt.Text);
            VoucherModel.Fecha_comprobante = voucherPicker.Value;

            try
            {
                foreach (DataGridViewRow row in invdetdataGrid.Rows)
                {
                    VoucherDetail.Id_articulo = (int)row.Cells[0].Value;
                    VoucherDetail.Cantidad = Int32.Parse(row.Cells[1].EditedFormattedValue.ToString());
                    VoucherDetail.Id_tipo_rechazo = 1;
                    VoucherDetail.Linea = row.Index;
                    VoucherDetail.Id_pallet = 111;

                    voucherDetailList.Add(VoucherDetail);
                }
                VoucherService.Save(VoucherModel, voucherDetailList);
                MessageBox.Show("Proceso Correcto.", "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, strings.Atencion);
            }
            
        }
    }
}