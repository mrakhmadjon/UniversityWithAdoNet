using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWithAdoNet.IRepositories;
using UniversityWithAdoNet.Models;

namespace UniversityWithAdoNet.Repositories
{
    internal class StudentRepository : IStudentRespository
    {
        NpgsqlConnection con = new NpgsqlConnection(Constants.DATAPATH);


        public void Create(Student stu)
        {
            
            con.Open();

            string query = "insert into student (firstname, lastname, age, course, group_id, phonenum)" +
                $"values('{stu.FirstName}', '{stu.LastName}', {stu.Age}, {stu.Course_id}, {stu.group_id}, '{stu.PhoneNum}')";

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);

            int created = cmd.ExecuteNonQuery();
            con.Close();
            if (created > 0)
                Console.WriteLine("Qo'shildi");
            else
                Console.WriteLine("Qo'shilmadi");
        }

        public void Delete(Student student)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student ReadAll()
        {
            
            return new Student();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
