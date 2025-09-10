using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Polls
    {
        public int Id { get; set; }
        public string Name { get; set; } // In table VARCHAR(80) and UNIQUE
        public string Description { get; set; } // In table TEXT
        public bool IsActive { get; set; } // In table BOOLEAN
        public int CategoryPollId { get; set; } // Foreign key to CategoriesPolls and called categorypoll_id
    }
}