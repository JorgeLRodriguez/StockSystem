using Domain;
using Domain.Contracts;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms.Impresion;

namespace UI
{
    static class Program 
    { 
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var ServiciosAplicacion = new ServiciosAplicacionModel(ConfigGlobal.Instance);
            var TraductorUsuario = ServiciosAplicacion.TraductorUsuario;
            ConfigurarIdiomaPorDefecto(TraductorUsuario);
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(ServiciosAplicacion));
            //Application.Run(new printcompfrm());
        }

        public static void ConfigurarIdiomaPorDefecto(ITraductorUsuario traductorUsuario)
        {
            var codigoIdiomaPorDefecto = "en-US";
            var idiomaPorDefecto =
                traductorUsuario.IdiomasSoportados.Single(
                    i => i.CodigoIso.Equals(codigoIdiomaPorDefecto, StringComparison.InvariantCultureIgnoreCase));
            traductorUsuario.IdiomaPreferido = idiomaPorDefecto;
        }
    }
}
