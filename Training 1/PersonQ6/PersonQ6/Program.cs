	
public class Program { 


	public static void Main(string[] args)
	    {
	        Student student = new Student();
	        student.behavior();
	        student.study();
	        Console.WriteLine(student.salary());
	        
	        Instructor instructor = new Instructor();
	        instructor.behavior();
	        instructor.teach();
	        Console.WriteLine(instructor.salary());
	
	
	    }
	
	    abstract class Person
	    {
	        private string beha = "sleep";
	        public virtual void behavior()
	        {
	            Console.WriteLine(beha);
	        }
	
	        public virtual int salary()
	        {
	            return 0;
	        }
	
	    }
	
	    class Student : Person
	    {
	        private string beha = "Study, Drink Coffee, repeat";
	        private string study2 = "Studying";
	        public override void behavior()
	        {
	            Console.WriteLine(beha);
	        }
	
	        public void study()
	        {
	            Console.WriteLine(study2);
	        }
	
	        public override int salary()
	        {
	            return 1000;
	        }
	
	    }
	
	    class Instructor : Person
	    {
	        private string beha = "Research, teach, repeat ";
	        private string teach2 = "Teaching";
	        public override void behavior()
	        {
	            Console.WriteLine(beha);
	        }
	
	        public void teach()
	        {
	            Console.WriteLine(teach2);
	        }
	
	        public override int salary()
	        {
	            return 70000;
	        }
	
    }
}