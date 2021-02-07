using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    /// <summary>
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    /// </summary>
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
