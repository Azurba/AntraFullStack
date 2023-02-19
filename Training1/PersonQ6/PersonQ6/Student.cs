using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    class Student : Person, IStudentService
    {
        //course name and grade
        protected Dictionary<Courses, decimal> courses = new Dictionary<Courses, decimal>();
        protected decimal GPA { get; set; }

        public Student() { }

        public Student(int age, decimal salary, List<string> address, Dictionary<Courses, decimal>courses, decimal GPA) 
        {
            this.age= age;
            this.salary= salary;
            this.address= address;
            this.courses=courses;
            this. GPA= GPA;
        }

        public void calculateGPA() { 
            
            
        }

}
}
