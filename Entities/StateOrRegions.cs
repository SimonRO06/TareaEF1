using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TareaEF1.Entities
{
    public class StateOrRegions
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string CountryId { get; set; }
        public string Code3166 { get; set; }
        public int SubdivisionId { get; set; }
    }
}