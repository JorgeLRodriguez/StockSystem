using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class NumeratorRepository : INumeratorRepository
    {
        protected Repository _db;
        public Numerador Create(Numerador entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Numerador> Get()
        {
            throw new NotImplementedException();
        }

        public Numerador Get(string id_tipo_comprobante, string letra, int sucursal)
        {
            Numerador numerador = new Numerador();
            using (_db = new Repository())
            {
                var query = from u in _db.Numerador
                            where u.id_tipo_comprobante == id_tipo_comprobante &&
                            u.letra == letra &&
                            u.sucursal == sucursal
                            select u;
                numerador.ID = query.FirstOrDefault<Numerador>().ID;
                numerador.id_tipo_comprobante = query.FirstOrDefault<Numerador>().id_tipo_comprobante;
                numerador.letra = query.FirstOrDefault<Numerador>().letra;
                numerador.sucursal = query.FirstOrDefault<Numerador>().sucursal;
                numerador.numero = query.FirstOrDefault<Numerador>().numero;
            }
            return numerador;
        }

        public List<Numerador> Get(Expression<Func<Numerador, bool>> whereExpression = null, Func<IQueryable<Numerador>, IOrderedQueryable<Numerador>> orderFunction = null, string includeModels = "")
        {
            throw new NotImplementedException();
        }

        public Numerador GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Numerador numerador)
        {
            using (_db = new Repository())
            {
                _db.Entry(numerador).State = EntityState.Modified;
                _db.SaveChanges();
            }
        }
    }
}