using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationStudy
{
    /*
     * Extension methods allow us to modify types without recompiling, modifying the
     * original type or adding a new derived class
     * 
     * The class in which will contain the extension method must be static and
     * therefore, the method itself must be static (static classes can only
     * have static members)
     * 
     * The first paramether must use the keyword 'this' that will referece
     * the current type when using the method.
     * 
     * If the extension method is located in a different file than the file that
     * will be using it, you must import the namespace in that file.
     * Example, in this case the class ExtensionMethod is in a different file than
     * Program.cs, therefore, we must type in Program.cs: 'using EvaluationStudy'
     */
    public static class ExtensionMethod
    {
        public static bool isGreaterThan(this int i, int j)
        {
            return i > j;
        }
    }
}
