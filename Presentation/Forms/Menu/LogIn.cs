using System;
using System.Windows.Forms;
using Domain.Models;
using Domain.Services;
using Language;

namespace UI
{
    public partial class LogIn : Form
    {
        private readonly UsuarioService US;
        private readonly MainMenufrm MMfrm;
        public LogIn()
        {
            InitializeComponent();
            US = new UsuarioService();
            MMfrm = new MainMenufrm();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            usrlab.Text = strings.Usuario + ":";
            pswlab.Text = strings.Contraseña + ":";
            btnlogin.Text = strings.Acceder;
        }
        private void Clean()
        {
            txtuser.Clear();
            txtpsw.Clear();
            txtuser.Focus();
            Cursor = Cursors.Arrow;
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                US.LogIn(txtuser.Text, txtpsw.Text);
                MMfrm.Show();
                Hide();
            }
            catch (Exception ex)
            {
                Clean();
                MessageBox.Show(ex.Message, strings.Atencion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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