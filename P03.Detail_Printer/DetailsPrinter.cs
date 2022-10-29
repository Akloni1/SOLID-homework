using P03.Detail_Printer;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<EmployeeBase> employees;

        public DetailsPrinter(IList<EmployeeBase> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (Employee employee in this.employees)
            {
                employee.PrintDetails();


            }
        }


    }
}
