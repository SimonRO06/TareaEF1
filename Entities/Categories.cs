using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Categories
    {
        public int Id { get; set; }
        public string Description { get; set; } // Is VARCHAR(60) in DB
    }
}