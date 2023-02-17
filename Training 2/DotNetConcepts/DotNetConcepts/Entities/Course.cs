namespace DotNetConcepts.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Difficulty { get; set; }
        public int StudentCoursesId { get; set; }


    }
}