using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.ABM
{
    public partial class Etiquetasfrm : Form
    {
        public Etiquetasfrm()
        {
            InitializeComponent();
        }
        private static Etiquetasfrm instance = null;
        public static Etiquetasfrm getInstance()
        {
            if (instance == null) { instance = new Etiquetasfrm(); }
            return instance;
        }
    }
}
