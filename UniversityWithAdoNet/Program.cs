using Npgsql;
using System;
using UniversityWithAdoNet.Models;
using UniversityWithAdoNet.Repositories;

namespace UniversityWithAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository rep = new StudentRepository();

            #region Create
            //Student student = new Student()
            //{
            //    FirstName = "Sardor",
            //    LastName = "Jorayev",
            //    Age = 20,
            //    Course_id = 5,
            //    group_id = 1,
            //    PhoneNum = "1234567890000"

            //};


            //rep.Create(student);
            #endregion

            #region student delete
            //DelStart:
            //int delId;
            //try
            //{
            //    Console.WriteLine("Delete qilmoqchi bo'lgan studentni ID sini kiriting");
            //     delId = int.Parse(Console.ReadLine());

            //}
            //catch 
            //{

            //    Console.WriteLine("Id ni int tipida kiriting");
            //    goto DelStart;
            //}
            //rep.Delete(delId);

            #endregion

            #region student update



            //Console.WriteLine("O'zgartirmoqchi bolgan studentni idsini kiriting");
            //int _id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Firstname");
            //string firstname = Console.ReadLine();
            //Console.WriteLine("Lastname");
            //string lastname = Console.ReadLine();
            //Console.WriteLine("Age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Course");
            //int course = int.Parse(Console.ReadLine());
            //Console.WriteLine("Group id ");
            //int groupId = int.Parse(Console.ReadLine());
            //Console.WriteLine("Phone number");
            //string phone = Console.ReadLine();


            //Student student = new Student()
            //{
            //    Id = _id,
            //    FirstName = firstname,
            //    LastName = lastname,
            //    Age = age,
            //    Course_id = course,
            //    group_id = groupId,
            //    PhoneNum = phone

            //};

            //rep.Update(student);

            #endregion

            #region student getbyid


            Console.WriteLine("Id ni kiriting");
            int id = int.Parse(Console.ReadLine());
            Student stu = rep.GetById(id);

            if (stu == null)
                Console.WriteLine(1001);

            #endregion

        }
    }
}
