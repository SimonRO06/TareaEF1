using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Companies
    {
        public string Id { get; set; } // Is VARCHAR(20) in DB and is PRIMARY KEY
        public int TypeId { get; set; } // Is INT in DB and is foreign key to typesidentification table and column name is "type_id"
        public string Name { get; set; } // Is VARCHAR(80) in DB
        public int CategoryId { get; set; } // Is INT in DB and is foreign key to categories table and column name is "category_id"
        public string CountryId { get; set; } // Is VARCHAR(6) in DB and is foreign key to countries table and column name is "country_id"
        public int AudienceId { get; set; } // Is INT in DB and is foreign key to audiences table and column name is "audience_id"
        public string Cellphone { get; set; } // Is VARCHAR(15) in DB and is UNIQUE
        public string Email { get; set; } // Is VARCHAR(80) in DB and is UNIQUE
    }
}