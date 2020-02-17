using SOLID_LSP_DEMO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_DEMO.Implementation
{
    class TemporaryEmployee : Employee
    {
        public TemporaryEmployee()
        {

        }
        public TemporaryEmployee(int id, string name) : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return (salary * .01M);
        }

        public override decimal GetMinimumSalary()
        {
            return 10000;
        }
    }
}
