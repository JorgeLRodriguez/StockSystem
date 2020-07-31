using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class configfrm : Form
    {
        public configfrm()
        {
            InitializeComponent();
        }
        private static configfrm instance = null;
        public static configfrm getInstance()
        {
            if (instance == null) { instance = new configfrm(); }
            return instance;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                string idioma = comboBox1.SelectedValue.ToString();

                if (idioma == "Español")
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


                if (checkedListBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
