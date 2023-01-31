	1. What type would you choose for the following “numbers”?
	A person’s telephone number = string
	A person’s heightA person’s age = float or double
	A person’s gender (Male, Female, Prefer Not To Answer) = enum
	A person’s salary = Decimal
	A book’s ISBNA book’s price = decimal
	A book’s shipping weight = float or double
	A country’s population = long
	The number of stars in the universe = long
	The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business) = integer
	
	2. What are the difference between value type and reference type variables? What is boxing and unboxing?
		○ The C# Type System contains three data types: Value Types (int, char, etc), Reference Types (object) and Pointer Types. 
		○ Basically, Boxing converts a Value Type variable into a Reference Type variable, and Unboxing achieves the vice-versa. 
		○ Boxing and Unboxing enable a unified view of the type system in which a value of any type can be treated as an object.

	3. What is meant by the terms managed resource and unmanaged resource in .NET
	Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control while Unmanaged resources are those that are not. File handles, pinned memory, COM objects, database connections etc.
	
	4. Whats the purpose of Garbage Collector in .NET?
	Just like in Java, the garbage collector in .NET manages the allocation and release of memory for the application
	
	1. What happens when you divide an int variable by 0?
	Unhandled Exception:
	System.DivideByZeroException: Attempted to divide by zero.
	
	2. What happens when you divide a double variable by 0?
	Will result in "Infinity"
	
	3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
	It will wrap it around back to the smallest possible value: -2147483648
	
	4. What is the difference between x = y++; and x = ++y;?
	X = y++ means: take the value of y, increment it and assign it to X
	X = ++y means: increment the value of y, assign it to y and then assign it to X
	
	5. What is the difference between break, continue, and return when used inside a loop statement?
	Break statement is used to terminate the current loop iteration or terminate the switch statement in which it appears whereas continue skip the execution of current iteration only and it does not break the loop/switch. The return terminates the execution of the function and returns control to the caller

	6. What are the three parts of a for statement and which of them are required?
	for ( initialization ; condition; iterator )
	Example:
	for(int i = 0; i <= 10; i++)
	Only the condition is require
	
	7. What is the difference between the = and == operators?
	The equality operator == checks whether two operands are equal or not while the = assigns a value to a variable
	
	8. Does the following statement compile? for ( ; true; ) ;
	Yes, it is just like a while loop with no "stop condition". In other words is a infinity loop
	
	9. What does the underscore _ represent in a switch expression?
	It replaces the default keyword
	
	10. What interface must an object implement to be enumerated over by using the foreach statement?
	IEnumerator interface
	
	1. When to use String vs. StringBuilder in C# ?
	The String object is immutable. Every time we use one of the methods in the string class, c# will create a new string object in memory, which requires a new allocation of space for that new object while StringBuilder class can be used when you want to modify a string without creating a new object
	
	2. What is the base class for all arrays in C#?
	Array Class
	
	3. How do you sort an array in C#?
	We can use the method from the Array Class: Sort
	Array.sort(arrayName)
	
	4. What property of an array object can be used to get the total number of elements in an array?
	Length
	
	5. Can you store multiple data types in System.Array?
	Yes
	
	6. What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
	
	CopyTo() will copy all the data in the array to another existing array. It will perform a shallow copy.
	
	Clone() will copy all the data in the array and will return it into a new object. It also performs a shallow copy
	
