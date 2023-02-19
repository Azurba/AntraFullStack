namespace DotNetConcepts.Models.RequestModels
{
    public class StudentCourseRequestModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseDifficulty { get; set; }

    }
}
