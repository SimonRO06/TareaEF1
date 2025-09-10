using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class CategoriesPolls
    {
        public int Id { get; set; }
        public string Name { get; set; } // In table VARCHAR(80) and UNIQUE
    }
}