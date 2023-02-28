using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DapperTutorialCore.Entities
{
    /*
    Create table Department(
    id int,
    Name varchar(30),
    Location varchar(40)
    
    */
    public class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //Navigation Properties - connect our Department table with Employee, just like a Foreign Key
        public List<Employee> Employee { get; set; }

    }
}
