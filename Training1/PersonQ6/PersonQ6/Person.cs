using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    class Person : IPersonService
    {
        protected int age { get; set; }
        protected decimal salary { get; set; }

        protected List<string>address = new List<string>();

        public Person() {
            age = 0;
            salary = 0;
        }

        public Person(int age, decimal salary, List<string> address) { 
            this.age = age;
            this.salary = salary;
            this.address = address;
        }

        public decimal calculateSalary() {
            return 0;
        }

        public List<string> getAddress() {
            return address;
        }

        public void addAddress(string addr) { 
            address.Add(addr);

        }
    }
}
