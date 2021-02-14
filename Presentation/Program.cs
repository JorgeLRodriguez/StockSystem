using Domain;
using Domain.Contracts;
using Domain.Models;
using Entities.Infraestructure;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using UI.Properties;

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
            ConfigurarLogPath();
            var ServiciosAplicacion = new ServiciosAplicacionModel(ConfigGlobal.Instance);
            var TraductorUsuario = ServiciosAplicacion.TraductorUsuario;
            ConfigurarIdiomaPorDefecto(TraductorUsuario);
            if (!ComprobarIntegridadDelSistema(TraductorUsuario))
                return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn(ServiciosAplicacion));
        }
        public static void ConfigurarIdiomaPorDefecto(ITraductorUsuario traductorUsuario)
        {
            var codigoIdiomaPorDefecto = Settings.Default.Idioma;
            var idiomaPorDefecto =
                traductorUsuario.IdiomasSoportados.Single(
                    i => i.CodigoIso.Equals(codigoIdiomaPorDefecto, StringComparison.InvariantCultureIgnoreCase));
            traductorUsuario.IdiomaPreferido = idiomaPorDefecto;

            Thread.CurrentThread.CurrentCulture = new CultureInfo(codigoIdiomaPorDefecto);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(codigoIdiomaPorDefecto);
        }
        public static bool ComprobarIntegridadDelSistema(ITraductorUsuario traductorUsuario)
        {
            try
            {
                var integridadSistema = new IntegridadSistema(Settings.Default.Corrupto);
                integridadSistema.ComprobarIntegridad();
            }
            catch (IntegridadSistema.SistemaCorruptoException ex)
            {
                MessageBox.Show(traductorUsuario.Traducir(ex.ConstanteError), traductorUsuario.Traducir(ConstantesTexto.Stock),
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public static void ConfigurarLogPath()
        {
            ConfigGlobal.Instance.LogPath = Settings.Default.LogPath;
        }
    }
}
