using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    class Courses : ICourseService
    {
        protected List<Student>enrolledStudents = new List<Student>();
        protected string courseName { get; set; }

        public Courses(string courseName, List<Student> enrolledStudents) {
            foreach (Student s in enrolledStudents) { 
                this.enrolledStudents.Add(s);
            }
            
            this.courseName = courseName;   
        }

        public List<Student> getEnrolledStudents() {
            return enrolledStudents;
        }

        public int totalEnrolledStudents() {
            return enrolledStudents.Count();
        }


    }
}
