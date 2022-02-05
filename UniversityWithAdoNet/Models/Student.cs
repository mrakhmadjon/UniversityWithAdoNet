using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWithAdoNet.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public int Course_id { get; set; }

        public int group_id { get; set; }
        public string PhoneNum  { get; set; }


    }
}
