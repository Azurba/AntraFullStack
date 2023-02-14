using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment7
{
    class MyGenericRepository<T> : IRepository<T>
    {
        public void Add(T item) { }
        public void Remove(T item) { }
        public void Save() { }
        public IEnumerable<T> GetAll() { }
        public T GetById(int id) { }

        public MyGenericRepository() { 
            
        }



    }
}
https://dotnettutorials.net/lesson/generic-repository-pattern-csharp-mvc/