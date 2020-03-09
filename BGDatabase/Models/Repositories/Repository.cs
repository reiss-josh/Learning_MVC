using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BGDatabase.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private GameStoreDataContext context = null;

        protected DbSet<T> DbSet
        {
            get; set;
        }

        public Repository()
        {
            context = new GameStoreDataContext();
            DbSet = context.Set<T>();
        }

        public Repository(GameStoreDataContext context)
        {
            this.context = context;
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}