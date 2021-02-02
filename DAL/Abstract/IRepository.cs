using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> GetAll();
            T Get(long id);
            void Insert(T entity);
            bool Update(T entity);
            bool Delete(T entity);
        }
}



