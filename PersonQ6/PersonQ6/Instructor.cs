using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    class Instructor : Person, IInstructorService
    {
        protected string department { get; set; }
        protected bool head { get; set; }
        protected int yearsExperience { get; set; }


        public Instructor() {
            this.department = "Default department";
            this.head = false;
            yearsExperience = 0;

        }
        public Instructor(int age, decimal salary, List<string> address, string department, bool isHead, int yearsExperience)
        {
            this.age = age;
            this.salary = salary;
            this.address = address;
            this.department= department;
            this.head= isHead;
            this.yearsExperience= yearsExperience;
        }

        public decimal calculateExtraSalary(int yearsExperience) {
            return salary + (yearsExperience * 500);
        }

    }
}
