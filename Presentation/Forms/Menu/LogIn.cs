using System;
using System.Windows.Forms;
using Domain.Contracts;
using Domain.Services;
using Entities;
using Language;

namespace UI
{
    public partial class LogIn : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private readonly UsuarioService US;
        private readonly MainMenufrm MMfrm;
        public LogIn(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();

            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);

            US = new UsuarioService();
            MMfrm = new MainMenufrm();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            //usrlab.Text = strings.Usuario + ":";
            //pswlab.Text = strings.Contraseña + ":";
            //btnlogin.Text = strings.Acceder;
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
                //MessageBox.Show(ex.Message, strings.Atencion, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            usrlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Usuario) + ":";
            pswlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Contraseña) + ":";
            btnlogin.Text = _traductorUsuario.Traducir(ConstantesTexto.Acceder);
        }
    }
}