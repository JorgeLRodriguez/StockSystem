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
    public partial class Layoutfrm : Form
    {
        public Layoutfrm()
        {
            InitializeComponent();
        }
        private static Layoutfrm instance = null;
        public static Layoutfrm getInstance()
        {
            if (instance == null) { instance = new Layoutfrm(); }
            return instance;
        }
    }
}
