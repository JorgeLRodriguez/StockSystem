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
    public partial class PxEfrm : Form
    {
        public PxEfrm()
        {
            InitializeComponent();
        }
        private static PxEfrm instance = null;
        public static PxEfrm getInstance()
        {
            if (instance == null) { instance = new PxEfrm(); }
            return instance;
        }
    }
}
