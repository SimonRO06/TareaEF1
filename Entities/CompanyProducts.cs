using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class CompanyProducts
    {
        public int CompanyId { get; set; } // Foreign key to Companies and is primary key
        public int ProductId { get; set; } // Foreign key to Products and is primary key
        public decimal Price { get; set; } // Is DOUBLE in DB
        public int UnitOfMeasureId { get; set; } // Foreign key to UnitOfMeasure
    }
}