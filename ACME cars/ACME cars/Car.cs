using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME_cars
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public bool Rented { get; set; }
        public string CustomerName { get; set; }

        public string MakeModel
        {
            get
            {
                return string.Format("{0} {1}", Make, Model);
            }
        }
    }
}
