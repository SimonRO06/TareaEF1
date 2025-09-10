using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; } // Is VARCHAR(80) in DB
        public string CountryId { get; set; } // Is VARCHAR(6) in DB and is foreign key to countries table and column name is "country_id"
        public int AudienceId { get; set; } // Is INT in DB and is foreign key to audiences table and column name is "audience_id"
        public string Cellphone { get; set; } // Is VARCHAR(20) in DB and is UNIQUE
        public string Email { get; set; } // Is VARCHAR(100) in DB and is UNIQUE
        public string Address { get; set; } // Is VARCHAR(120) in DB
    }
}