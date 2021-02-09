using DataAccess.Contracts;
using Entities.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
    internal class CalculadoraIntegridadDVRepository : ICalculadoraIntegridadDVRepository
    {
        private readonly DatabaseContext _context;
        private readonly ICalculadoraDVRepository _calculadoraDv;
        public CalculadoraIntegridadDVRepository(DatabaseContext context)
        {
            _context = context;
            _calculadoraDv = new CalculadoraDVRepository();
        }
        public bool ComprobarIntegridad(Type tipoEntidad)
        {
            var entityDbSet = (IQueryable)_context.Set(tipoEntidad);
            return this.IsEntityCorrupted(entityDbSet, tipoEntidad);
        }
        private bool IsEntityCorrupted(IQueryable entityDbSet, Type entityType)
        {
            var crcs = new List<byte[]>();
            foreach (IDigitoVerificadorHorizontal entity in entityDbSet.AsNoTracking())
            {
                //Aborto si ya encontre un registro corrupto
                if (!_calculadoraDv.EsValido(entity))
                    return true;

                crcs.Add(entity.DVH);
            }
            //Si nunca grabe entidades de este tipo, ni tampoco tengo un DVV, puede darse este caso y no debe fallar
            var digitoVerificadorVerticalGuardado = _context.Set<DigitoVerificadorVertical>().Find(entityType.FullName);
            if (digitoVerificadorVerticalGuardado == null && crcs.Count == 0)
                return false;
            //Calculo el hash vertical con todos los CRC individuales y lo comparo con lo que tengo almacenado
            var verticalChecksum = _calculadoraDv.CalcularDigitoVerificadorDesdeMultiplesDigitos(crcs);
            return !verticalChecksum.SequenceEqual(digitoVerificadorVerticalGuardado.Checksum);
        }
    }
}
