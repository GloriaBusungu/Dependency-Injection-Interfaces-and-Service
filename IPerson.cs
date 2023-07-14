using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesDotNetCore.Interfaces
{
    public interface IPerson
    {
        void GetPersonNames();
        int PersonAge();
        DateTime PersonDOB();
    }
}
