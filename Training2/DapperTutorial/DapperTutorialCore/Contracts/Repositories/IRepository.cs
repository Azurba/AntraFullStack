using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialCore.Contracts.Repositories
{
    public interface IRepository<T>
    {
        int Insert(Task obj);
        int Update(Task obj);
        int DeleteById(int id);
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}
