using P03.Detail_Printer;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee : EmployeeBase, IReport
    {
        public Employee(string name) : base(name)
        {
        }

        public void PrintDetails()
        {
            Console.WriteLine(Name);
        }

    }
}
