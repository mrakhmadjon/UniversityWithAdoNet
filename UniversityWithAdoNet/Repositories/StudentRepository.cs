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
    internal class StudentRepository : IStudentRepository
    {
        NpgsqlConnection con = new NpgsqlConnection(Constants.DATAPATH);


        public void Create(Student stu)
        {
            
            con.Open();
            try
            {                                                                                 
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
            catch (Exception ex)
            {

                Console.WriteLine("Student malumotlarini toldirayotgan Xatolik\n" + ex.Message);
            }

            
        }

        public void Delete(int _id)
        {
            con.Open();

            string delQuery = $"delete from student where id = {_id}";
            NpgsqlCommand cmd = new NpgsqlCommand(delQuery, con);

            int isDeleted = cmd.ExecuteNonQuery();
            if (isDeleted > 0)
                Console.WriteLine("Bu id dagi student o'chirildi");
            else
                Console.WriteLine("bunday Id dagi inson yo'q");
        }

        public Student GetById(int _id)
        {
            con.Open();
            try
            {
                string query = $"select * from student where id = {_id}";

                NpgsqlCommand com = new NpgsqlCommand(query, con);

                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                Student student = new Student()
                {

                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Age = reader.GetInt32(3),
                    Course_id = reader.GetInt32(4),
                    group_id = reader.GetInt32(5),
                    PhoneNum = reader.GetString(6)
                };

                con.Close();
                return student;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public string GetStudentGroup(int id)
        {
            con.Open();
            try
            {
                string query = $"select student.firstname,name from\"group\" join  \"student\" on \"group\".id = \"student\".group_id where \"student\".id = {id}";

                NpgsqlCommand com = new NpgsqlCommand(query, con);

                NpgsqlDataReader reader = com.ExecuteReader();
                reader.Read();
                return reader.GetString(0) + " " + reader.GetString(1);
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
           
        }

        public string GetStudentTeacherAndSubject(int id)
        {
            con.Open();
            try
            {
                string query = "select student.firstname, teacher.firstname,\"subject\".name  from student" +
                           "join \"group\" on student.group_id = \"group\".id" +
                           "join teacher on \"group\".id = teacher.group_id" +
                           "join \"subject\" on teacher.subject_id = subject.id" +
                           $"where student.id = {id}";
                                                                                                             
                NpgsqlCommand com = new NpgsqlCommand(query, con);

                NpgsqlDataReader reader = com.ExecuteReader();

                return "Student " + reader.GetString(0) + "Teacher " + reader.GetString(1) + "Subject" + reader.GetString(2);

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
           
           
        }

        public IList<Student> ReadAll()
        {

            con.Open();

            string query = "select * from student";

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            
            IList<Student> students = new List<Student>();

            NpgsqlDataReader reader =  cmd.ExecuteReader();
            while (reader.Read())
            {
                students.Add(new Student()
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Age = reader.GetInt32(3),
                    Course_id = reader.GetInt32(4),
                    group_id = reader.GetInt32(5),
                    PhoneNum = reader.GetString(6)
                });
            }
            con.Close();
            return students;

        }

        public void Update(Student student)
        {
            con.Open();
            try
            {
                string updQuery = $"update student set firstname = '{student.FirstName}',lastname = '{student.LastName}', age = {student.Age}" +
                $"course = {student.Course_id}, group_id = {student.group_id},phonenum = '{student.PhoneNum}' where id = {student.Id}";
                NpgsqlCommand cmd = new NpgsqlCommand(updQuery, con);

                int isUpdated = cmd.ExecuteNonQuery();

                if (isUpdated > 0)
                    Console.WriteLine("Yangilandi");
                else
                    Console.WriteLine("Yangilashda Xatolik Yuz Berdi");
            }
            catch (Exception ex)
            {

                Console.WriteLine( ex.Message) ;
            }
            con.Close();

        }
    }
}
