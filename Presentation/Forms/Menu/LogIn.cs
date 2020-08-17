using System;
using System.Windows.Forms;
using Domain.Models;

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
                SecurityModel S = new SecurityModel();
                if (S.VerifyAccess(txtuser.Text, txtpsw.Text) != null)
                {
                    MainMenufrm mainMenufrm = new MainMenufrm();
                    mainMenufrm.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                switch (ex.Message.ToString())
                {
                    case "LogInIncorrecto":
                        MessageBox.Show(strings.LogInIncorrecto, "¡" + strings.Atencion + "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clean();
                        break;
                    case "logInEmptyorNull":
                        MessageBox.Show(strings.logInEmptyorNull, "¡" + strings.Atencion + "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Clean();
                        break;
                    default:
                        Clean();
                        MessageBox.Show(ex.Message, "");
                        return;
                }
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