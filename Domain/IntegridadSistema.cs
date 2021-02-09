using DataAccess.Contracts;
using DataAccess.Repositories;
using Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    /// <summary>
    /// Encapsula funciones de rutina basada en dígitos verificadores para determinar la integridad del repositorio de datos
    /// </summary>
    public class IntegridadSistema
    {
        private readonly bool _estaCorrupto;
        private readonly IUnitOfWorkRepository _unitOfWorkRepository;
        public class SistemaCorruptoException : Exception
        {
            public string ConstanteError { get; set; }
            public string[] EntidadesAfectadas { get; set; }
            public SistemaCorruptoException(IEnumerable<string> entidadesAfectadas)
            {
                this.ConstanteError = "ErrorSistemaCorrupto";
                this.EntidadesAfectadas = entidadesAfectadas.ToArray();
            }
        }
        //TODO: Este constructor esta solo a modo de ejemplo
        public IntegridadSistema(bool estaCorrupto)
        {
            _estaCorrupto = estaCorrupto;
            _unitOfWorkRepository = UnitOfWorkRepository.Default;
        }
        public void ComprobarIntegridad()
        {
            var corruptedEntityNames = new List<string>();
            var tipoEntidadConDigitoVerificador = typeof(IDigitoVerificadorHorizontal);
            var tiposSoportadosConDigitoVerificador = this.EnumerarTiposCompatibles(tipoEntidadConDigitoVerificador);
            foreach (var tipoEntidad in tiposSoportadosConDigitoVerificador)
            {
                if (_unitOfWorkRepository.CalculadoraIntegridadDVRepository.ComprobarIntegridad(tipoEntidad))
                    corruptedEntityNames.Add(tipoEntidad.FullName);
            }
            //Reviento si al menos existe una entidad corrupta
            if (_estaCorrupto || corruptedEntityNames.Any())
                throw new SistemaCorruptoException(corruptedEntityNames);
        }
        private IEnumerable<Type> EnumerarTiposCompatibles(Type tipoEsperado)
        {
            return typeof(Entities.Infraestructure.Usuario).Assembly
                .GetTypes()
                .Where(entityType => entityType.IsClass
                                     && !entityType.IsAbstract
                                     && tipoEsperado.IsAssignableFrom(entityType));
        }
    }
}
