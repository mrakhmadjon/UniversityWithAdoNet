using Npgsql;
using System;
using System.Collections.Generic;
using UniversityWithAdoNet.GetInfo;
using UniversityWithAdoNet.IRepositories;
using UniversityWithAdoNet.Models;
using UniversityWithAdoNet.Repositories;


namespace UniversityWithAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudentRepository rep = new StudentRepository();
            GetStudentInfo getStudentInfo = new GetStudentInfo();
            ITeacherRepository teacherRepository = new TeacherRepository();

            #region student create
            //rep.Create(getStudentInfo.GetStudent());
            #endregion

            #region student delete

            //rep.Delete(getStudentInfo.GetStudentId());

            #endregion

            #region student update
            //rep.Update(getStudentInfo.GetStudentUpdateInfo());
            #endregion

            #region student getbyid

            //Student stu = rep.GetById(getStudentInfo.GetStudentId());

            //if (stu == null)
            //    Console.WriteLine(1001);

            #endregion

            #region student readall
            //IList<Student> students = rep.ReadAll();
            //foreach (Student student in students)
            //    Console.WriteLine(student.FirstName);
            #endregion

            #region student group 

            //Console.WriteLine("Guruhini bilmoqchi bolgan studentni ID sini kiriting");
            //Console.WriteLine(rep.GetStudentGroup(getStudentInfo.GetStudentId()));

            #endregion

            #region student getteacherandsubject

            //string studentTeacherSubject = rep.GetStudentTeacherAndSubject(getStudentInfo.GetStudentId());
            //Console.WriteLine(studentTeacherSubject);

            #endregion


           
                                                                
                        


            #region ReadAllTeacher

            //IList<Teacher> teachers  = teacherRepository.ReadAll();
            //foreach (var teacher in teachers)
            //{
            //    Console.WriteLine(teacher.Id + " " +  teacher.FirstName + " " + teacher.LastName + " "+ teacher.Phone_Num);
            //}

            #endregion

            #region GetTeacherById

            //Teacher teacher = teacherRepository.ReadById(getStudentInfo.GetStudentId());


            //Console.WriteLine(teacher.Id + " " +  teacher.FirstName + " " + teacher.LastName + " "+ teacher.Phone_Num);


            #endregion

            #region getstudentsofteacher

            //IList<Student> studentsOfTeacher = teacherRepository.GetStudents(getStudentInfo.GetStudentId());
            //if (studentsOfTeacher.Count == 0)
            //    Console.WriteLine("Bu ustozni oquvchisi yoq yoki bunday ustozni uzi yoq");
            //else 
            //    foreach (var st in studentsOfTeacher)
            //{
            //    Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            //}
            #endregion


            #region TeacherUpdate

            //teacherRepository.Update(GetTeacherInfo.GetTeacherInf());


            #endregion


        }
    }
}
