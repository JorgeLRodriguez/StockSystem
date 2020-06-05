using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using BLL;

namespace UI
{
    public partial class LogIn : Form
    {
        EUser E = new EUser();
        UserBLL UB = new UserBLL();
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            E.USR = "";
            E.PSW = "";
            UB.VerificarlogIn();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == strings.Usuario)
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = strings.Usuario;
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpsw_Enter(object sender, EventArgs e)
        {
            if (txtpsw.Text == strings.Contraseña)
            {
                txtpsw.Text = "";
                txtpsw.ForeColor = Color.LightGray;
                txtpsw.UseSystemPasswordChar = true;
            }
        }

        private void txtpsw_Leave(object sender, EventArgs e)
        {
            if (txtpsw.Text == "")
            {
                txtpsw.Text = strings.Contraseña;
                txtpsw.ForeColor = Color.DimGray;
                txtpsw.UseSystemPasswordChar = false;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
