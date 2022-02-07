using System;

using UniversityWithAdoNet.Models;

namespace UniversityWithAdoNet.GetInfo
{
    internal class GetStudentInfo
    {
        public  Student GetStudent()
        {
            
            Console.WriteLine("Firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Course");
            int course = int.Parse(Console.ReadLine());
            Console.WriteLine("Group id ");
            int groupId = int.Parse(Console.ReadLine());
            Console.WriteLine("Phone number");
            string phone = Console.ReadLine();


            Student student = new Student()
            {
               
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                Course_id = course,
                group_id = groupId,
                PhoneNum = phone

            };
            return student;
        }

        public  Student GetStudentUpdateInfo()
        {

            Console.WriteLine("O'zgartirmoqchi bolgan studentni idsini kiriting");
            int _id = int.Parse(Console.ReadLine());
            Console.WriteLine("Firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Course");
            int course = int.Parse(Console.ReadLine());
            Console.WriteLine("Group id ");
            int groupId = int.Parse(Console.ReadLine());
            Console.WriteLine("Phone number");
            string phone = Console.ReadLine();


            Student student = new Student()
            {
                Id = _id,
                FirstName = firstname,
                LastName = lastname,
                Age = age,
                Course_id = course,
                group_id = groupId,
                PhoneNum = phone

            };
            return student;
        }

        public int GetStudentId()
        {
        DelStart:
            int getId;
            try
            {
                Console.WriteLine("ID ni kiriting");
                getId = int.Parse(Console.ReadLine());

            }
            catch
            {

                Console.WriteLine("Id ni int tipida kiriting");
                goto DelStart;
            }
            return getId;
        }
    }
}
