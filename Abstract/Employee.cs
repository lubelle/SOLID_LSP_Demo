﻿using SOLID_LSP_DEMO.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_DEMO.Abstract
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Employee()
        {

        }
        public Employee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public override string ToString()
        {
            return string.Format("ID: {0} Name: {1}", this.ID, this.Name);
        }

        public decimal GetMinimumSalary()
        {
            throw new NotImplementedException();
        }

        public abstract decimal CalculateBonus(decimal salary);
    }
}