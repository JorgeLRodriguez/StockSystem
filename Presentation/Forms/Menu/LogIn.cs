using System;
using System.Windows.Forms;
using Domain.Models;
using Language;

namespace UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            try
            {
                if (String.IsNullOrEmpty(txtuser.Text) || String.IsNullOrEmpty(txtpsw.Text)) throw new ApplicationException(strings.logInEmptyorNull);
                SecurityModel S = new SecurityModel();
                S.VerifyAccess(txtuser.Text, txtpsw.Text);
                MainMenufrm mainMenufrm = new MainMenufrm();
                mainMenufrm.Show();
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
        private void Clean()
        {
            txtuser.Clear();
            txtpsw.Clear();
            txtuser.Focus();
            Cursor = Cursors.Arrow;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            usrlab.Text = strings.Usuario +":";
            pswlab.Text = strings.Contraseña + ":";
            btnlogin.Text = strings.Acceder;
        }
    }
}