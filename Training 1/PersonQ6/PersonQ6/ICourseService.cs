using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    interface ICourseService
    {
        List<Student> getEnrolledStudents();
        int totalEnrolledStudents();

    }
}
