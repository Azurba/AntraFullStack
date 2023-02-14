using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    internal interface IDepartmentService
    {
        Dictionary<double, DateTime> getBudget();
    }
}
