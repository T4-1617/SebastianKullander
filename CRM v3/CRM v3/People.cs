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
    }

    public class Customer : People
    {
        public int CustomerID { get; set; }
    }

    public class Empoyee : People
    {
        public int EmployeeID { get; set; }
        public string Title { get; set; }
        public decimal wage { get; set; }
    }

    public class Supplier : People
    {
    }
}
