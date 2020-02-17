﻿using SOLID_LSP_DEMO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_DEMO.Implementation
{
    class ContractEmployee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee()
        {

        }
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 8500;
        }
    }
}
