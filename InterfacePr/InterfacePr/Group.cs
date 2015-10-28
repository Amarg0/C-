using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePr
{
    class Group
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Group(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}
