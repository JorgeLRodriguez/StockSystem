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
    public partial class IxCfrm : Form
    {
        public IxCfrm()
        {
            InitializeComponent();
        }
        private static IxCfrm instance = null;
        public static IxCfrm getInstance()
        {
            if (instance == null) { instance = new IxCfrm(); }
            return instance;
        }
    }
}
