using System;
using System.Windows.Forms;
using Domain.Contracts;
using Entities;
using Entities.Infraestructure;

namespace UI
{
    public partial class LogIn : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        public LogIn(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
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
                var userLogIn = _serviciosAplicacion.Usuario;
                userLogIn.IniciarSesion(txtuser.Text, txtpsw.Text);
                new MainMenufrm(_serviciosAplicacion).Show();
                Hide();
            }
            catch (Exception ex)
            {
                Clean();
                this.MostrarDialogoError(_traductorUsuario, ex.Message);
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
            this.Text = _traductorUsuario.Traducir(ConstantesTexto.Login);
        }
    }
}