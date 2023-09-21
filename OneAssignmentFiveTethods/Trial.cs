using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAssignmentFiveTethods
{
    public class Trial
    {
        public static string MyFifthMethod(string firstName, string lastName)
        {
            string last = lastName.ToUpper();
            string first = $"{firstName[0].ToString().ToUpper()}" +
               $"{firstName.ToLower().Substring(1)}";

            return $"{last}, {first}";
        }
    }
}
