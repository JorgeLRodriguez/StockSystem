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
    public partial class AjusteInvfrm : Form
    {
        public AjusteInvfrm()
        {
            InitializeComponent();
        }
        private static AjusteInvfrm instance = null;
        public static AjusteInvfrm getInstance()
        {
            if (instance == null) { instance = new AjusteInvfrm(); }
            return instance;
        }
    }
}
