using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWithAdoNet.Models;

namespace UniversityWithAdoNet.IRepositories
{
     interface IStudentRepository
    {
        void Create(Student student);
        IList<Student> ReadAll();

        Student GetById(int id);
        void Update(Student student);

        void Delete(int id);

        string GetStudentGroup(int id);

        string GetStudentTeacherAndSubject(int id);
    }
}
