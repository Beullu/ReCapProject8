﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implement4e eden bir nesne olabilir!
    //new() : newlebilir olmalı
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        //filtreleme
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

      
    }   
    
}
