using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Benefits
    {
        public int Id { get; set; }
        public string Description { get; set; } // Is VARCHAR(80) in DB
        public string Detail { get; set; } // Is TEXT in DB
    }
}