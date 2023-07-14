using ExamplesDotNetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesDotNetCore.Repositories
{
    public class PersonRepository : IPerson
    {
        public void GetPersonNames()
        {
            Console.WriteLine("My name is Romanus");
            Console.WriteLine("My Age is " + PersonAge());
            Console.WriteLine("My DOB is " + PersonDOB());
        }
        public int PersonAge()
        {
            int MyAge = 7;
            return MyAge;
        }
        public DateTime PersonDOB()
        {
            DateTime MyDOB = DateTime.Now.AddYears(-7);
            return MyDOB;
        }
    }
}
