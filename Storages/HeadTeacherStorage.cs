using getone.Domains;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace getone.Storages
{
        public class HeadTeacherStorage
        {
            private Dictionary<int, HeadTeacher> HeadTeachers { get; } = new Dictionary<int, HeadTeacher>();

            public void Create(HeadTeacher headTeacher)
            {
                HeadTeachers.Add(headTeacher.HeadTeacherId, headTeacher);
            }

            public HeadTeacher Read(int hTeacherId)
            {
                return HeadTeachers[hTeacherId];
            }

            public HeadTeacher Update(int hTeacherId, HeadTeacher newHeadTeacher)
            {
                HeadTeachers[hTeacherId] = newHeadTeacher;
                return HeadTeachers[hTeacherId];
            }

            public bool Delete(int hTeacherId)
            {
                return HeadTeachers.Remove(hTeacherId);
            }
        }
    
}