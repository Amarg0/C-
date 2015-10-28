using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePr
{
    class Student
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public string Name { get; set; }

        public int EnrollYear { get; set; }

        public Student(int id, int groupId, string name, int enrollYear)
        {
            Id = id;
            GroupId = groupId;
            Name = name;
            EnrollYear = enrollYear;
        }

    }
}
