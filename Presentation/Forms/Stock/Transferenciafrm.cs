using Domain.Contracts;
using Entities;
using Entities.Infraestructure;
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
    public partial class Transferenciafrm : Form , ISubscriptorCambioIdioma 
    {
        #region FormSettings
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static Transferenciafrm _instance = null;
        public Transferenciafrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static Transferenciafrm GetInstance(IServiciosAplicacion serviciosAplicacion)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new Transferenciafrm(serviciosAplicacion);
            return _instance;
        }
        #endregion
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            originlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Origen);
            destlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Destino);
        }

        private void depositlab_Click(object sender, EventArgs e)
        {

        }

        private void desctxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
