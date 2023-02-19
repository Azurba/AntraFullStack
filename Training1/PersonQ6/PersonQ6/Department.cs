using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonQ6
{
    class Department : IDepartmentService
    {
        protected Instructor head { get; set; }
        //value of the budget and start and end date for the school year
        protected Dictionary<double, DateTime> budget = new Dictionary<double, DateTime>();

        protected string departmentName { get; set; } = "DefaultName";

        Department() {
            List<string> defaultAddress = new List<string>();
            defaultAddress.Add("None");
            head = new Instructor(-1, -1, defaultAddress, this.departmentName, true, -1);

            budget.Add(0, DateTime.Now);

        }

        Department(Instructor head, Dictionary<double, DateTime> budget) {
            this.head = head;
            this.budget = budget;
        }

        public Dictionary<double, DateTime> getBudget() {
            return budget;
        }

    }
}
