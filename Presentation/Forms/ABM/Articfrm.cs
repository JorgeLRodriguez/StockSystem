﻿using System;
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
    public partial class Articfrm : Form
    {
        public Articfrm()
        {
            InitializeComponent();
        }
        private static Articfrm instance = null;
        public static Articfrm getInstance()
        {
            if (instance == null) { instance = new Articfrm(); }
            return instance;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
