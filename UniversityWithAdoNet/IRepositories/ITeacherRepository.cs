using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWithAdoNet.Models;

namespace UniversityWithAdoNet.IRepositories
{
    internal interface ITeacherRepository
    {
       
        Teacher Read();

        void Update(Teacher student);

        
    }
}
