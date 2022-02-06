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
                                                                                    
            Console.WriteLine("Guruhini bilmoqchi bolgan studentni ID sini kiriting");
            Console.WriteLine(rep.GetStudentGroup(getStudentInfo.GetStudentId()));

            #endregion

        }
    }
}
