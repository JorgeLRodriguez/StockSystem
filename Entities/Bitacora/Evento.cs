using System.ComponentModel.DataAnnotations;

namespace Entities.Bitacora
{
    /// <summary>
    /// Modela los tipos de eventos que registran entradas en la bitácora
    /// </summary>
    public class Evento
    {
        #region "Constantes de Evento"
        public const int UsuarioIngresoAlSistema = 1;
        public const int UsuarioSalioDelSistema = 2;
        public const int UsuarioFalloIngresandoCredenciales = 3;
        public const int ComprobanteGenerado = 4;

        #endregion 
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
