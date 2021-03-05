using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
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
