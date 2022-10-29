using P03.Detail_Printer;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Manager : EmployeeBase, IReport
    {
        public Manager(string name, ICollection<string> documents) : base(name)
        {
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine(Name);
            Console.WriteLine(string.Join(Environment.NewLine, Documents));
        }
    }
}
