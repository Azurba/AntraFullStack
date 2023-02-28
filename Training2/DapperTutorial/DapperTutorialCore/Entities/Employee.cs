using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorialCore.Entities
{
    public class Employee
    { 
        public int id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }

        //Navigation properties - To connect with the Department table. Just like a Foreign Key
        public Department department { get; set; }
    }
}
