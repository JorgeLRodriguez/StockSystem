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
    public partial class Transferenciafrm : Form
    {
        public Transferenciafrm()
        {
            InitializeComponent();
        }
        private static Transferenciafrm instance = null;
        public static Transferenciafrm getInstance()
        {
            if (instance == null) { instance = new Transferenciafrm(); }
            return instance;
        }
    }
}
