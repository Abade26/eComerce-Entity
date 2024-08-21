using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eComerce.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        public ICollection<Usuario>? Usuario { get; set; }
    }
}
