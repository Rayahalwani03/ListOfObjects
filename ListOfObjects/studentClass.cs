using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfObjects
{
    public class studentClass
    {

        public studentClass(int id, string name, string department)
        {
            this.id = id;
            this.name = name;
            this.department = department;
        }

        public int id { get; set; }

        public string name { get; set; }

        public string department { get; set; }
    }
}
