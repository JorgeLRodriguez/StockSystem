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
        private void ListClients()
        {
            clientcbx.DisplayMember = nameof(Cliente.Descripcion);
            clientcbx.DataSource = _serviciosAplicacion.Cliente.Get();
        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            clientlab.Text = _traductorUsuario.Traducir(ConstantesTexto.Cliente);
            datelab.Text = _traductorUsuario.Traducir(ConstantesTexto.Fecha);
            obslab.Text = _traductorUsuario.Traducir(ConstantesTexto.Observacion);
            savebtn.Text = _traductorUsuario.Traducir(ConstantesTexto.Guardar);
        }

        private void AjusteInvfrm_Load(object sender, EventArgs e)
        {
            ListClients();
        }
    }
}
