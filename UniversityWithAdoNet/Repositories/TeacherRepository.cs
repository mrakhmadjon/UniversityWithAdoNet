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
    internal class TeacherRepository : ITeacherRepository
    {
        NpgsqlConnection con = new NpgsqlConnection(Constants.DATAPATH);

        public IList<Student> GetStudentsOfTeacher(int group_id)
        {
            try
            {
                con.Open();

                string query = $"select student.* from teacher join \"group\" on teacher.group_id = \"group\".id  join student on \"group\".id = student.group_id where teacher.id  = {group_id}";

                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                IList<Student> result = new List<Student>();
                while (reader.Read())
                {
                    result.Add(new Student()
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
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
           

        }

        public IList<Teacher> ReadAll()
        {
            try
            {
                con.Open();
                string query = "select * from teacher";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                IList<Teacher> teachers = new List<Teacher>();

                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    teachers.Add(new Teacher()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone_Num = reader.GetString(3),
                        Group_id = reader.GetInt32(4),
                        Subject_id = reader.GetInt32(5)

                    });
                }
                con.Close();

                return teachers;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Teacher ReadById(int id)
        {
         
            try
            {
                con.Open();
                string query = $"select * from teacher where id = {id}";
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                IList<Teacher> teachers = new List<Teacher>();

                NpgsqlDataReader reader = cmd.ExecuteReader();

                

                reader.Read();
                
                
                Teacher teacher = new Teacher()
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Phone_Num = reader.GetString(3),
                        Group_id = reader.GetInt32(4),
                        Subject_id = reader.GetInt32(5)

                    };
               
                con.Close();

                return teacher;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message) ;
            }
        }

        public void Update(Teacher teacher)
        {
            try
            {
                con.Open();
                string query = $"update teacher SET firstname = '{teacher.FirstName}',lastname = '{teacher.LastName}',phonenum = '{teacher.Phone_Num}',group_id = {teacher.Group_id},subject_id = {teacher.Subject_id} where id = {teacher.Id}";

                NpgsqlCommand cmd = new NpgsqlCommand(query, con);

                int isUpdated = cmd.ExecuteNonQuery();

                if (isUpdated > 0)
                    Console.WriteLine("Yangilandi");
                else
                    Console.WriteLine("Yangilanishda Xatolik");


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           
        
        }

       
    }
}
