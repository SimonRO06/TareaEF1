using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class Memberships
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } // Is TEXT in DB
    }
}