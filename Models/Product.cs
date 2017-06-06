using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scaffolding8.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Decimal? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public virtual Category Category { get; set; }
    }
}