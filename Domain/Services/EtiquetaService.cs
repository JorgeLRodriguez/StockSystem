using Domain.Models;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class EtiquetaService
    {
        private readonly EtiquetaModel etiquetaModel = new EtiquetaModel();
        public void Create(Comprobante comprobante)
        {
            etiquetaModel.Create(comprobante);
        }
        public IEnumerable<Etiqueta> GetbyIDComp(Comprobante comprobante)
        {
            return etiquetaModel.GetbyIDComp(comprobante);
        }
    }
}
