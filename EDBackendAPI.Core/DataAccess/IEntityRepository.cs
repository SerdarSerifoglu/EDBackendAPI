using EDBackendAPI.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EDBackendAPI.Core.DataAccess
{
    /*
     class: tip oalrak class olmalı anlamına gelmiyor. reference tip olan birşey anlamına gelmekte. 
     IEntity 'den türemiş olmalı 
     new() bu T new'lenebilir olmalı interfacelerin gelmesini engelledik.
     */
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
