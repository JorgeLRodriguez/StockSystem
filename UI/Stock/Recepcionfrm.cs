using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Stock
{
    public partial class Recepcionfrm : Form
    {
        public Recepcionfrm()
        {

            InitializeComponent();

        }
        //Singleton
        private static Recepcionfrm instance = null;     
        public static Recepcionfrm getInstance()
        {
            if (instance == null) { instance = new Recepcionfrm(); }
            return instance;
        }
    }
}
