using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Detail_Printer
{
    public abstract class EmployeeBase
    {
        public string Name { get; set; }
        public EmployeeBase(string name)
        {
            this.Name = name;
        }
    }
}
