
class Program {
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


            foreach (string i in list3) {
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

            foreach (KeyValuePair<string, int> i in employeeAge) {
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
        void byValue(int a) {
            Console.WriteLine($"age value inside = " + a);
            a = 45;
        }

        //After byValue is called, age will change because the REFERENCE of age
        //has been changed.
        //Age passed its reference to 'a', so when changes, it also changes age
        void byReference(ref int a) {
            Console.WriteLine($"age reference inside = " + a);
            a = 46;
        }


        //PARAMS

        Console.WriteLine(paramsExample(12, 13, 10, 15, 56));
        Console.WriteLine(paramsExample(12, 13));
        Console.WriteLine(paramsExample());

        int paramsExample(params int[] sumParams) {

            int total = 0;

            foreach (int i in sumParams) {
                total += i;
            }
            
            return total;
        }

    }
}



