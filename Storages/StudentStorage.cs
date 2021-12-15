using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
        public class StudentStorage
        {
            private Dictionary<int, Student> Studnets { get; } = new Dictionary<int, Student>();

            public void Create(Student studnet)
            {
            Studnets.Add(studnet.StudentId, studnet);
            }

            public Student Read(int studentId)
            {
                return Studnets[studentId];
            }

            public Student Update(int studentId, Student newStudnet)
            {
                Studnets[studentId] = newStudnet;
                return Studnets[studentId];
            }

            public bool Delete(int studentId)
            {
                return Studnets.Remove(studentId);
            }
        }
}