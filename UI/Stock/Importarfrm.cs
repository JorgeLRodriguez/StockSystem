using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class Importarfrm : Form
    {
        public Importarfrm()
        {
            InitializeComponent();
        }
        private static Importarfrm instance = null;
        public static Importarfrm getInstance()
        {
            if (instance == null) { instance = new Importarfrm(); }
            return instance;
        }
    }
}
