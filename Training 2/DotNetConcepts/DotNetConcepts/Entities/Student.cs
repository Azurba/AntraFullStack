﻿namespace DotNetConcepts.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CourseId {get; set;}
        public List<Course> Courses { get; set; }
        
    }
}
