using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrm.Authorization.ApplicationLayer.Contract.Repository
{
    public interface IRepository<T>
    {
        int Insert(T obj);
        int Update(T obj);
        int DeleteById(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
