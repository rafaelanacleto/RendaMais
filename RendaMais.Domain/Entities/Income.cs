using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RendaMais.Domain.Entities
{
    public class Income : Entity
    {
        public string? Name { get; set; }
        public double Value { get; set; }
    }
}
