using Domain.Contracts;
using Entities.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class ValidateModel<T> : IValidateModel<T> where T : class
    {
        #region "Singleton"
        private static readonly Lazy<IValidateModel<T>> _default = new Lazy<IValidateModel<T>>(() => new ValidateModel<T>());
        public static IValidateModel<T> Default
        {
            get { return _default.Value; }
        }
        #endregion
        public void Validar(T model)
        {
            ValidationContext v = new ValidationContext(model);
            List<ValidationResult> r = new List<ValidationResult>();

            if (!Validator.TryValidateObject(model, v, r, true)) throw new Exception(string.Join(" ", r));
        }
        public void Validar(List<T> list)
        {
            if (list.Count == 0) throw new Exception(ConstantesTexto.ErrorFaltanLineas);
            list.ForEach(x => Validar(x));
        }
    }
}