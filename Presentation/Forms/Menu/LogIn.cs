using System;
using System.Windows.Forms;
using Domain.Contracts;
using Domain.Services;
using Entities;

namespace UI
{
    public partial class LogIn : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private readonly UsuarioService US;
        public LogIn(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();

            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);

            US = new UsuarioService();
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
                new MainMenufrm().Show();
                Hide();
            }
            catch (ErrorDeValidacionException ex)
            {
                Clean();
                this.MostrarDialogoError(_traductorUsuario, ex.Message + "." + ex.InnerException.ToString());
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