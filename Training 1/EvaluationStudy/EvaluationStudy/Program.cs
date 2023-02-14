
using EvaluationStudy;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //VARIABLES
            int integerNumber = 1;
            long longNumber = 2l; //Add L to the end - Same as Int64
            float floatNumber = 3.1f; //Add F to the end
            double doubleNumber = 4.1; //D or nothing to the end
            decimal decimalNumber = 5.1m; //add M to the end
            String stringName = "Joao";
            char charLetter = 'H';
            bool boolean = true;

            Console.WriteLine(longNumber.GetType());


        //CASTING
            string stringToInt = Convert.ToString(integerNumber);
            Console.WriteLine("Integer to String, " + stringToInt.GetType());

            double doubletoInt = 6.4;
            Console.WriteLine("Double to int, " + doubletoInt.GetType());
            int doubletoInt2 = Convert.ToInt32(doubletoInt);
            Console.WriteLine("Double to int, " + doubletoInt2.GetType());

            Console.WriteLine("Char to String, " + charLetter.GetType());
            string chartoString = Char.ToString(charLetter);
            Console.WriteLine("Char to String, " + chartoString.GetType());


        //CONCATENATION
            string concat = "Joao" + "Pimenta" + "Giudice";
            Console.WriteLine(concat);


        //STRING INTERPOLATION
            string inter = $"To do interpolation, just add $ in front of it, followed by the expression between curly brackets: {integerNumber} ";
            Console.WriteLine(inter);


        //DATA STRUCTURES

        //LISTS
            List<string> list = new List<string>(); //list with default capacity: 4
            List<string> list2 = new List<string>(2); //list with capacity of 2
            List<string> list3 = new List<string>(50) { "Dog", "Cat", "Fish" }; //list with capacity of 50 and initialized

            Console.WriteLine(list3[2]);


            foreach (string i in list3)
            {
                Console.WriteLine(i);
            }

            list3.Add("Bird");

            //for (int j = 0; j <= list3.Count; j++) {
            //    Console.WriteLine(list3[j]);
            //}

            list3.Remove("Bird");
            list3.RemoveAt(1);
            list3.Clear();


        //DICTIONARY - Stores a key-value pairs in no particular order
        //Dictionary<Key, Value>
            IDictionary<string, int> employeeAge = new Dictionary<string, int>();

            employeeAge.Add("Joao Pimenta", 29);
            employeeAge.Add("Almendra Astete Farfan", 25);
            employeeAge.Add("Athila", 11);

            foreach (KeyValuePair<string, int> i in employeeAge)
            {
                Console.WriteLine(i.Key + " " + i.Value);
            }

            Console.WriteLine(employeeAge.ContainsKey("Joao Pimenta"));
            employeeAge.Remove("Athila");
            employeeAge.Clear();



        //PASS BY VALUE AND PASS BY REFERENCE

        //Pass by value means passing a copy of the variable to the method.
        //Pass by reference means passing access to the variable to the method.


            int age = 100;
            int age2 = 101;

            Console.WriteLine("At the beginning");
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Age2: " + age2);

            byValue(age);
            byReference(ref age2);

            Console.WriteLine("After call");
            Console.WriteLine("Age value: " + age);
            Console.WriteLine("Age reference: " + age2);

            //After byValue is called, age will not change because the VALUE of age
            //has not being changed.
            //Age passed its value to a
            //Only the value of 'a' has been changed, not age
            void byValue(int a)
            {
                Console.WriteLine($"age value inside = " + a);
                a = 45;
            }

            //After byValue is called, age will change because the REFERENCE of age
            //has been changed.
            //Age passed its reference to 'a', so when changes, it also changes age
            void byReference(ref int a)
            {
                Console.WriteLine($"age reference inside = " + a);
                a = 46;
            }


        //PARAMS

            Console.WriteLine(paramsExample(12, 13, 10, 15, 56));
            Console.WriteLine(paramsExample(12, 13));
            Console.WriteLine(paramsExample());

            int paramsExample(params int[] sumParams)
            {

                int total = 0;

                foreach (int i in sumParams)
                {
                    total += i;
                }

                return total;
            }


        //Extension method - Implemented in a different file/class
 
            int smaller = 10;
            int greater = 20;

            bool result = smaller.isGreaterThan(greater);

            Console.WriteLine(result);

        //VIRTUAL KEYWORD 
            /* 
             * gives the method the possibility of being overriden or not
               is used in combination with the overriden keyword
             */

            double /*virtual*/ getArea(double x, double y)
            {
                return x * y;
            }

            //Virtual is commented because the main class cannot inherit anything
            //virtual is to be used in classes that can be inherited

        //GETTERS AND SETTERS
        
            getAndSet gs = new getAndSet();

            Console.WriteLine(gs.Name);


        //UPCASTING AND DOWNCASTING- Implemented below, in this file
        
            //Downcasting = you are asking for dog to behave like mammal.
            //Not always will work, because not all mammals are dogs

            //Upcasting = you are asking for a mammal to behavel like a dog
            //it will always work because all dogs are mammals
       
            void doAnimalStuff(Mammal animal) {
                animal.makeNoise();

                //Implicit downcasting - Illegal
                //Dog myDog = animal;

                /* Explicit downcasting - Not recommended
                 * If a dog is passed to the method, it will work however, if a cat
                 * is passed, the program will crach.
                 */
                //Dog myDog = (Dog)animal;
                //myDog.makeNoise();
            }

            Mammal genericMammal = new Mammal();
            doAnimalStuff(genericMammal);

            Mammal dog = new Dog();
            //Dog dog2 = new Dog(); //Work as well
            doAnimalStuff(dog);

            Mammal cat = new Cat();
            doAnimalStuff(cat);

            //Cat cat2 = new Mammal(); //Won't work implicit
            //Cat cat3 = (Cat)new Mammal(); //Work explicitly - not recommended

        //BOXING AND UNBOXING

            /* C# has 3 different types: value type, reference type and Pointer types
             * Boxing converts a value type into reference
             * Unboxing converts a reference typ into value
             */
            int box = 123;
            object o = box; //This boxes 'box'

            box = (int)o; //This unboxes 'o'

        //ENUM - Implemented furthuer below in this file.

            /* ENUM is a value type that represents a group of constants
             * By default, all items are assinged a integer value, starting with 0
             * for the first item.
             * 
             * Can't be implemented inside a class. It is treated just like a class
             * 
             */
            DaysWeek myDay = DaysWeek.Monday;
            Console.WriteLine(myDay);

            int num = (int)DaysWeek.Wednesday;
            Console.WriteLine(num);


        //ABSTRACT CLASSES - Implemented further down in this file
        Square sq = new Square();

        Console.WriteLine(sq.GetArea(2, 2));
        sq.Hello();

    }

    class Mammal
    {
        public virtual void makeNoise()
        {
            Console.WriteLine("Animal sounds");
        }
    }

    class Dog : Mammal
    {
        public override void makeNoise()
        {
            Console.WriteLine("Woof");
        }

        public void growl()
        {
            Console.WriteLine("grrr");
        }

    }

    class Cat : Mammal
    {
        public override  void makeNoise()
        {
            Console.WriteLine("Meow");
        }
    }

    public enum DaysWeek
    {
        Sunday, //Automaticall assigned value of 0
        Monday, //Automaticall assigned value of 1
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public abstract class Shape
    {
        public abstract int GetArea(int x, int y);

        public virtual void Hello() {
            Console.WriteLine("Hello from a concret method inside an Abstract class");
        }
    }

    public class Square : Shape //Abstract class
    { 
        public override int GetArea(int x, int y)
        {
            return x * y;
        }

        public override void Hello()
        {
            Console.WriteLine("Hello from the overriden method Hello, from Square class");
        }
    }

    public class Rectangle : Shape2 //Interface
    {
        public int GetArea(int x, int y)
        {
            return x * y;
        }

        public void Hello()
        {
            Console.WriteLine("Hello from the overriden method Hello, from Square class");
        }
    }

    interface Shape2
    { 
        int GetArea(int x, int y);
        void Hello();
        
    }




}



