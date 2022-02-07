using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWithAdoNet.Models;

namespace UniversityWithAdoNet.GetInfo
{
    internal class GetTeacherInfo
    {
        public static Teacher GetTeacherInf()
        {
            Console.WriteLine("Yangilamoqchi bolgan teacherni ID si");
            int teacher_id = int.Parse(Console.ReadLine());
            Console.WriteLine("Firstname");
            string firstname = Console.ReadLine();
            Console.WriteLine("Lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Group id ");
            int groupId = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject Id");
            int subject_id = int.Parse(Console.ReadLine());

            Teacher teacher = new Teacher()
            {
                Id = teacher_id,
                FirstName = firstname,
                LastName = lastname,
               Phone_Num = phone,
               Group_id = groupId,
               Subject_id = subject_id
            };

            return teacher;
        }
    }
}
