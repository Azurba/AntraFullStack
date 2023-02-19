using DotNetConcepts.Entities;
using DotNetConcepts.Models.RequestModels;

namespace DotNetConcepts.MapHelper
{
    public static class MapHelper
    {
        public static StudentCourseRequestModel MapToStudentCourseRequestModel(Student student, Course course)
        {
            StudentCourseRequestModel model = new StudentCourseRequestModel();
            model.StudentAge = student.Id;
            model.StudentName= student.Name;
            model.StudentAge = student.Age;
            model.CourseDifficulty = course.Difficulty;
            model.CourseId = course.Id;
            model.CourseName = course.Name;
            return model;
        }
    }
}
