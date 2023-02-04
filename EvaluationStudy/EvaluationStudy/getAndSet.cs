using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationStudy
{
    public class getAndSet
    {
        private string _name = " I need to get this";
        private string name2 = "I need to get this 2";

        //Prefered way of doing
        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        //Another way of doing it
        public string getName2() {
            return name2;
        }

        public void setName2(string value) {
            name2 = value;
        }

    }
}
