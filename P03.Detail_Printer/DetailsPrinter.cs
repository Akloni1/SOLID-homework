﻿using P03.Detail_Printer;
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

                /*if (employee is Manager)
                {
                    this.PrintManager((Manager)employee);
                }
                else
                {
                    this.PrintEmployee(employee);
                }*/
            }
        }

       /* private void PrintEmployee(Employee employee)
        {
            Console.WriteLine(employee.Name);
        }

        private void PrintManager(Manager manager)
        {
            Console.WriteLine(manager.Name);
            Console.WriteLine(string.Join(Environment.NewLine, manager.Documents));
        }*/
    }
}