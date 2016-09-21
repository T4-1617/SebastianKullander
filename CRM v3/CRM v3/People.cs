using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_v3
{
    public abstract class People
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }

    public class Customer : People
    {
        public int CustomerID { get; set; }
    }

    public class Employee : People
    {
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public decimal wage { get; set; }
        
    }

    public class Supplier : People
    {
        public string Company { get; set; }
    }
}
