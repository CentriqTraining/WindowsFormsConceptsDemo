using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseObjects.Interfacess
{
   public  interface IRepository<T> : INotifyCollectionChanged
    {
        T Find(int id);
        List<T> GetAll();
        bool Update(T item);
        bool Delete(T item);
        bool Delete(int id);
        bool Insert(T item);
    }
}
