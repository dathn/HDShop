﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace HDShop.Data.Infrastructure
{
    //định nghĩa các phương thức có sẵn
    public interface IRepository<T> where T : class
    {
        //Marks an entity as new
        T Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity as removed
        T Delete(T entity);

        T Delete(int id);

        //Delete multi record
        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes = null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);

        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}