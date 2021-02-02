using System;
using System.Collections.Generic;
using ClassLibrary1.Data_Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClassLibrary1;

namespace DAL.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly DbContext _db = null;
        protected DbSet<T> entities = null;

        public Repository()
        {
            _db = new UserDb();
            entities = _db.Set<T>();
        }

        //public Repository(UserDb db)
        //{
        //    // _db = ConnectionFactory.CreateConnection();
        //    this._db = db;
        //    entities = db.Set<T>();
        //}

        
        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            entities.Add(entity);
            _db.SaveChanges();
            
            
        }

        public bool Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
