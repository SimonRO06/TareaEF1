using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class MembershipPeriods
    {
        public int Id { get; set; }
        public int MembershipId { get; set; }
        public int PeriodId { get; set; }
        public string Name { get; set; } // Is VARCHAR(80) in DB and is UNIQUE
        public string Description { get; set; } // Is TEXT in DB
        public decimal Price { get; set; } // Is DOUBLE in DB
        public string CompanyId { get; set; } // Is VARCHAR(20) in DB, is foreign key to companies table and column name is "companyId"
    }
}