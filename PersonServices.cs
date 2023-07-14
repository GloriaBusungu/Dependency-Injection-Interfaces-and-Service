using ExamplesDotNetCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesDotNetCore.Services
{
    public class PersonServices
    {
        private readonly IPerson _myPerson;
        public PersonServices(IPerson myPerson)
        {
            _myPerson = myPerson;
        }
        public void TestMyServiceMessage()
        {
            _myPerson.GetPersonNames();
            _myPerson.PersonDOB();
            _myPerson.PersonAge();
        }
    }
}
