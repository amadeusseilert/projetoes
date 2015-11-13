using SweetMonitor.dao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;

namespace SweetMonitor.dal
{
    public interface IGenericDataManager<T> where T : class
    {
        void Add(params T[] items);
        void Update(params T[] items);
        void Remove(params T[] items);
    }

    public class GenericDataManager<T> : IGenericDataManager<T> where T : class
    {
        public void Add(params T[] items)
        {
            using (var context = new DAO())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Added;
                }
                context.SaveChanges();
            }
        }

        public void Remove(params T[] items)
        {
            using (var context = new DAO())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();
            }
        }

        public void Update(params T[] items)
        {
            using (var context = new DAO())
            {
                foreach (T item in items)
                {
                    context.Entry(item).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }
    }
}