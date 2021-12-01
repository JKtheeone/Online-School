namespace getone.Storages
{
    public static class Storage
    {
        public static ApplicationJournalStorage ApplicationJournalStorage { get; } = new ApplicationJournalStorage();
        public static CoursematerialStorage CoursematerialStorage { get; } = new CoursematerialStorage();
        public static CourseStorage CourseStorage { get; } = new CourseStorage();
        public static EducationalPlanStorage EducationalPlanStorage { get; } = new EducationalPlanStorage();
        public static FeedbackJournalStorage FeedbackJournalStorage { get; } = new FeedbackJournalStorage();
        public static GroupStorage GroupStorage { get; } = new GroupStorage();
        public static HeadTeacherStorage HeadTeacherStorage { get; } = new HeadTeacherStorage();
        public static ScheduleStorage ScheduleStorage { get; } = new ScheduleStorage();
        public static StudentBaseStorage StudentBaseStorage { get; } = new StudentBaseStorage();
        public static StudentStorage StudentStorage { get; } = new StudentStorage();
        public static TeachersStorage TeachersStorage { get; } = new TeachersStorage();
        public static TechiciansStorage TechiciansStorage { get; } = new TechiciansStorage();

    }
}