using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    interface IStudentService : IPersonService
    {
        void calculateGPA();

    }
}
