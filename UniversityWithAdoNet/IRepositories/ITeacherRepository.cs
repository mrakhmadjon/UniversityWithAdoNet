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
       
        IList<Teacher> ReadAll();

        Teacher ReadById(int id);

        void Update(Teacher student);

        IList<Student> GetStudents(int group_id);
        
    }
}
