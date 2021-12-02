using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
    public class StudentBase
    {
        public class StudentBaseStorage
        {
            private Dictionary<string, StudentBase> StudentBases { get; } = new Dictionary<string, StudentBase>();

            public void Create(StudentBase studentBase)
            {
                StudentBases.Add(studentBase.Email, studentBase)
            }

            public StudentBase Read(int email)
            {
                return StudentBases[email];
            }

            public Schedule Update(int string, StudentBase newStudentBase)
            {
                StudentBases[email] = newStudentBase;
                return StudentBases[email];
            }

            public bool Delete(string email)
            {
                return StudentBases.Remove(email);
            }
        }
    }
}