using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy
{
    class Problem
    {
        public bool Status { get; set; }
        public string Name { get; set; }
        public string Additional { get; set; }

        public Problem(bool status, string name, string additional)
        {
            Status = status;
            Name = name;
            Additional = additional;
        }

        public string ProblemStatus()
        {
            if (Status)
                return "Решена";
            else
            {
                return "Не решена";
            }
        }
    }
}
