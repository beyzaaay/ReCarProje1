using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmanı diğer katmanları referans almaz yani northwinde ya da başka bir veritabanına bağlı olamaz
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lernebilir demek
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);  //datadaki filtreleme işlemleri yapmak için kullandık
        T Get(Expression<Func<T, bool>> filter);  //tüm datayı getirir
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
