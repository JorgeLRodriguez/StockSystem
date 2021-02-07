using Domain.Contracts;
using Entities;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace UI
{
    public partial class configfrm : Form , ISubscriptorCambioIdioma
    {
        private readonly ITraductorUsuario _traductorUsuario;
        private readonly IServiciosAplicacion _serviciosAplicacion;
        private static configfrm _instance = null;
        private configfrm(IServiciosAplicacion serviciosAplicacion)
        {
            InitializeComponent();
            _serviciosAplicacion = serviciosAplicacion;
            _traductorUsuario = serviciosAplicacion.TraductorUsuario;
            this.EnlazarmeConServiciosDeTraduccion(_traductorUsuario);
        }
        public static configfrm getInstance(IServiciosAplicacion serviciosAplicacion)
        {
            return _instance = _instance ?? new configfrm(serviciosAplicacion);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                string idioma = comboBox1.SelectedValue.ToString();

                if (idioma == "Español")
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (checkedListBox1.SelectedIndex == 1)
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo("");
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var codigoIdiomaPorDefecto = "es-AR";
            var idiomaPorDefecto =
                _traductorUsuario.IdiomasSoportados.Single(
                    i => i.CodigoIso.Equals(codigoIdiomaPorDefecto, StringComparison.InvariantCultureIgnoreCase));
            _traductorUsuario.IdiomaPreferido = idiomaPorDefecto;
        }
        public void IdiomaCambiado(Idioma nuevoIdioma)
        {
            
        }
    }
}
