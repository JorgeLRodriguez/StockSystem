using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Reportes
{
    public partial class ListadoStockfrm : Form
    {
        public ListadoStockfrm()
        {
            InitializeComponent();
        }
        private static ListadoStockfrm instance = null;
        public static ListadoStockfrm getInstance()
        {
            if (instance == null) { instance = new ListadoStockfrm(); }
            return instance;
        }
    }
}
