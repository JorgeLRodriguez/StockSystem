﻿using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class TipoRechazo
    {
        #region "Constantes de Evento"
        public const int ProductoVencido = 1;
        public const int ProductoDefectuoso = 2;
        public const int EmbalajeDefectuoso = 3;
        public const int ProductoApto = 4;

        #endregion 
        [Key]
        public int ID { get; set; }
        public string Descripcion { get; set; }
    }
}
