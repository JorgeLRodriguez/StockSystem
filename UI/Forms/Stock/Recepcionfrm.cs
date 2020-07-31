using BLL.Models;
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
        private ArticleModel ArticleModel = new ArticleModel();
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
            var list = clientModel.GetClients();
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
            invdetdataGrid.Rows.Remove(invdetdataGrid.CurrentRow);
        }
        private void list_Articles ()
        {
            if (clientcbx.SelectedValue != null)
            {
                var list = ArticleModel.GetArticles().FindAll(e => e.IdCliente == Int32.Parse(clientcbx.SelectedValue.ToString()));
                DataGridViewComboBoxColumn articlecbdg = invdetdataGrid.Columns[0] as DataGridViewComboBoxColumn;
                articlecbdg.DisplayMember = "Descripcion";
                articlecbdg.ValueMember = "Id_articulo";
                articlecbdg.DataSource = list;
            }
        }
        private void invdetdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}