using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management
{
    public class Order
    {
        public int Id { get; set; }
        public int Numberofitems { get; set; }
        public string date { get; set; }
        public int Total { get; set; }
    }
}
