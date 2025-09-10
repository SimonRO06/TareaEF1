using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Rates
    {
        public int CustomerId { get; set; } // Foreign key to Customers, primary key and called customer_id
        public int CompanyId { get; set; } // Foreign key to Companies, primary key and called company_id
        public int PollId { get; set; } // Foreign key to Polls, primary key and called poll_id
        public DateTime DateRating { get; set; } // In table DATETIME and default to now()
        public decimal Rate { get; set; } // In table DOUBLE
    }
}