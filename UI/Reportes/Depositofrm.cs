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
    public partial class Depositofrm : Form
    {
        public Depositofrm()
        {
            InitializeComponent();
        }
        private static Depositofrm instance = null;
        public static Depositofrm getInstance()
        {
            if (instance == null) { instance = new Depositofrm(); }
            return instance;
        }
    }
}
