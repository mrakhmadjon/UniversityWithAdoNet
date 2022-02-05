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
            Student student = new Student()
            {
                FirstName = "Ali",
                LastName = "Jorayev",
                Age = 20,
                Course_id = 5,
                group_id = 1,
                PhoneNum = "1234567890"

            };
            
            StudentRepository rep = new StudentRepository();


            

            rep.Create(student);
            //rep.Read();
            Console.WriteLine();
        }
    }
}
