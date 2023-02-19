namespace DotNetConcepts.Entities
{
    //this is a Bridge table or Adjuction Table = connect Student with Course
    public class StudentCourses
    {
        public int id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public Student student { get; set; }
        public Course course { get; set; }
    
    }


}
