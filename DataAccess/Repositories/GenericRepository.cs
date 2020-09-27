using DataAccess.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repositories
{
    public class GenericRepository <T> : IGenericRepository<T> where T : IdentityBase, new()
    {
        protected Repository _db;
        public GenericRepository(Repository repository)
        {
            _db = repository;
        }
        public List<ValidationResult> ValidateModel(T model)
        {
            ValidationContext v = new ValidationContext(model);
            List<ValidationResult> r = new List<ValidationResult>();

            bool validate = Validator.TryValidateObject(model, v, r, true);

            if (validate)
            {
                return null;
            }
            else
            {
                return r;
            }
        }
        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        string includeProperties = "")
        {
            IQueryable<T> query = _db.Set<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            var entity = includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var model in entity)
            {
                query = query.Include(model);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            return query.ToList();
        }
        public virtual void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(int id)
        {
            var entity = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(entity);
        }

        public virtual T Create(T entity)
        {
            _db.Set<T>().Add(entity);
            return entity;
        }

        public T GetById(int id)
        {
            return _db.Set<T>().SingleOrDefault(x => x.ID == id);
        }
        public virtual void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}