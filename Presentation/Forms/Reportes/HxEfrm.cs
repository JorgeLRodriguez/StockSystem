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
    public partial class HxEfrm : Form
    {
        public HxEfrm()
        {
            InitializeComponent();
        }
        private static HxEfrm instance = null;
        public static HxEfrm getInstance()
        {
            if (instance == null) { instance = new HxEfrm(); }
            return instance;
        }
    }
}
