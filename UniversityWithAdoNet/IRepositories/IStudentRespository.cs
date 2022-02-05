using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWithAdoNet.Models;

namespace UniversityWithAdoNet.IRepositories
{
     interface IStudentRespository
    {
        void Create(Student student);
        IList<Student> ReadAll();

        Student GetById(int id);
        void Update(Student student);

        void Delete(int id);

        string GetStudentGroupAndTeacher(int id);
    }
}
