using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
        public class StudentStorage
        {
            private Dictionary<int, Student> Students { get; } = new Dictionary<int, Student>();

            public void Create(Student student)
            {
            Students.Add(student.StudentId, student);
            }

            public  Student Read(int studentId)
            {
                return Students[studentId];
            }

            public Student Update(int studentId, Student newStudnet)
            {
            Students[studentId] = newStudnet;
                return Students[studentId];
            }

            public bool Delete(int studentId)
            {
                return Students.Remove(studentId);
            }
        }
}