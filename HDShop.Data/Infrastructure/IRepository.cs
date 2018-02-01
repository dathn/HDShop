﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace HDShop.Data.Infrastructure
{
    //định nghĩa các phương thức có sẵn
    public interface IRepository<T> where T : class
    {
        //Marks an entity as new
        void Add(T entity);

        //Marks an entity as modified
        void Update(T entity);

        //Marks an entity as removed
        void Delete(int id);

        //Delete multi record
        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);

        IQueryable<T> GetMulti(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}