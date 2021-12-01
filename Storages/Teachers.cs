using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
    public class Teacher
    {
        public class TeacherStorage
        {
            private Dictionary<string, Teacher> Teachers { get; } = new Dictionary<string, Teacher>();


            public void Create(Teacher teacher)
            {
                Teachers.Add(teacher.FullName, teacher)
            }

            public Teacher Read(string fullName)
            {
                return Teachers[fullName];
            }

            public Teacher Update(string fullName, Teacher newTeacher)
            {
                Teachers[fullName] = newTeacher;
                return Teachers[fullName];
            }

            public bool Delete(string fullName)
            {
                return Teachers.Remove(fullName);
            }
        }
    }
}