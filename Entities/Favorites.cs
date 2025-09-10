using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Favorites
    {
        public int Id { get; set; }
        public int CustomerId { get; set; } // Is INT in DB and is foreign key to customers table and column name is "customer_id"
        public string CompanyId { get; set; } // Is VARCHAR(20) in DB and is foreign key to companies table and column name is "company_id"
    }
}