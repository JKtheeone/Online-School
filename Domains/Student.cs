

namespace getone.Domains
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int Group { get; set; }

        public Student() { }

        public Student(int studentId,string fullName,string email,string phoneNumber,int group)
        {
            StudentId = studentId;
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            Group = group;
        }

    }
}