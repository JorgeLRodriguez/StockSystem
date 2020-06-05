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
    public partial class Pickingfrm : Form
    {
        public Pickingfrm()
        {
            InitializeComponent();
        }
        private static Pickingfrm instance = null;
        public static Pickingfrm getInstance()
        {
            if (instance == null) { instance = new Pickingfrm(); }
            return instance;
        }
    }
}
