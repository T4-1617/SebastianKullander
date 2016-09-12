using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerForm
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public string fullName()
        {
            return string.Format("{0} {1}", firstName, lastName);   
        }
    }

}
