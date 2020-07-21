﻿using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public class MasterRepository <T> : IGenericRepository<T> where T : class
    {
        protected Repository _db;
        public MasterRepository()
        {
            _db = new Repository();
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
        public virtual List<T> Get(Expression<Func<T, bool>> whereExpression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderFunction = null, string includeEntities = "")
        {
            IQueryable<T> query = _db.Set<T>();

            if (whereExpression != null)
            {
                query = query.Where(whereExpression);
            }

            var entity = includeEntities.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var model in entity)
            {
                query = query.Include(model);
            }

            if (orderFunction != null)
            {
                query = orderFunction(query);
            }

            return query.ToList();
        }
        public virtual void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
        public virtual void Delete(int id)
        {
            var entity = _db.Set<T>().Find(id);
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }

        public virtual T Create(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
            return entity;
        }
    }
}
