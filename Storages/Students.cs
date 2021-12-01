using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
    public class Studnet
    {
        public class StudnetStorage
        {
            private Dictionary<int, Studnet> Studnets { get; } = new Dictionary<int, Studnet>();

            public void Create(Studnet studnet)
            {
                Studnets.Add(studnet.StudentId, studnet)
            }

            public Studnet Read(int studentId)
            {
                return Studnets[studentId];
            }

            public Studnet Update(int studentId, Studnet newStudnet)
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
}