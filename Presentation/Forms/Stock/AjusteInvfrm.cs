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
    public partial class AjusteInvfrm : Form, ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static AjusteInvfrm _instance = null;
        public AjusteInvfrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static AjusteInvfrm GetInstance(IServiciosAplicacion serviciosAplicacion)
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new AjusteInvfrm(serviciosAplicacion);
            return _instance;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {

        }

        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            clientlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Cliente);
            datelab.Text = _traductorUsuario.Traducir(ConstantesTexto.Fecha);
            obslab.Text = _traductorUsuario.Traducir(ConstantesTexto.Observacion);
            savebtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Guardar);
        }
    }
}
