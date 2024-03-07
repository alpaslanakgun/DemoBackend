using System;
using System.Collections.Generic;
using System.Text;

namespace DemoBackend.Entities.Concrete
{
    public  class Product
    {
        public int ProductID { get; set; }
        public string  ProductName { get; set; }
        public int  CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal  UnitPrice  { get; set; }
        public short UnitsInStock { get; set; }
    }
}
