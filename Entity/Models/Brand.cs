using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class Brand : Core.Persistence.Repositories.Entity
    {
        public string Name { get; set; }
        public Brand()
        {

        }
        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

    }
}
