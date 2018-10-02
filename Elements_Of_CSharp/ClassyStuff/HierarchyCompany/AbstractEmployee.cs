using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyStuff
{
    abstract class AbstractEmployee
    {
        private string name;
        private int salary;
        public virtual void GetJobName() { }
        public virtual int GetSalary() { return salary; }
    }
}
