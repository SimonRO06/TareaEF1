using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class QualityProducts
    {
        public int ProductId { get; set; } // Foreign key to Products, primary key and called product_id
        public int CustomerId { get; set; } // Foreign key to Companies, primary key and called company_id
        public int PollId { get; set; } // Foreign key to Polls, primary key and called poll_id
        public string CompanyId { get; set; } // Foreign key to Companies, primary key and called company_id
        public DateTime DateRating { get; set; } // In table DATETIME and default to now()
        public decimal Rate { get; set; } // In table DOUBLE
    }
}