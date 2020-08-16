using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace UI
{
    public partial class LogIn : Form
    {
        SecurityModel UB = new SecurityModel();
        public LogIn()
        {
            InitializeComponent();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            User usr = new User();

            try
            {
                if (UB.VerifyAccess(txtuser.Text, txtpsw.Text) != null)
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
                        txtuser.Clear();
                        txtpsw.Clear();
                        txtuser.Focus();
                        Cursor = Cursors.Arrow;
                        break;
                    case "logInEmptyorNull":
                        MessageBox.Show(strings.logInEmptyorNull, "¡" + strings.Atencion + "!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtuser.Clear();
                        txtpsw.Clear();
                        txtuser.Focus();
                        Cursor = Cursors.Arrow;
                        break;
                    default:
                        Cursor = Cursors.Arrow;
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
    }
}