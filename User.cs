using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class User
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public override int GetHashCode()
        {
            return $"{Name} - {SurName}".GetHashCode();
        }

        public override string ToString()
        {
            return $" \n {Name} {SurName}";
        }
       
    }
}
