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
    public partial class Inventariofrm : Form
    {
        public Inventariofrm()
        {
            InitializeComponent();
        }
        private static Inventariofrm instance = null;
        public static Inventariofrm getInstance()
        {
            if (instance == null) { instance = new Inventariofrm(); }
            return instance;
        }
    }
}
