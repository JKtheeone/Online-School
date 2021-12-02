namespace getone.Domains
{
    public class HeadTeacher
    {
        public int HeadTeacherId { get; set; }

        public string FullName { get; set; }

        public HeadTeacher() { }

        public HeadTeacher(int hTeacherId , string fullname)
        {
            HeadTeacherId = hTeacherId;
            FullName = fullname;
        }
    }
}