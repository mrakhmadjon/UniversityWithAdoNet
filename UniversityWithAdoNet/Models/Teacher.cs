using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWithAdoNet.Models
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Subject_id { get; set; }

        public int Group_id { get; set; }
        public string Phone_Num { get; set; }
    }
}
