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
    public partial class Scaneofrm : Form
    {
        public Scaneofrm()
        {
            InitializeComponent();
        }
        private static Scaneofrm instance = null;
        public static Scaneofrm getInstance()
        {
            if (instance == null) { instance = new Scaneofrm(); }
            return instance;
        }
    }
}
