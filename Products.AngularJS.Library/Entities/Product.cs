using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Products.AngularJS.Library.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
    }
}
