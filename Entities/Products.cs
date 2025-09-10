using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } // Is VARCHAR(60) in DB
        public string Detail { get; set; } // Is TEXT in DB
        public decimal Price { get; set; } // Is DOUBLE in DB
        public int TypeProductId { get; set; } // Is INT in DB, is foreign key to typesProducts table and column name is "typeproductid"
        public string Image { get; set; } // Is VARCHAR(80) in DB
    }
}