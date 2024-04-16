using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaMais.Domain.Entities
{
    public class Cost : Entity
    {
        public string? Name { get; set; }
        public double Value { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }



    }
}
