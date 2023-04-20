/*1.
 * A person’s telephone number: string
 * A person’s height: float
 * A person’s age: ushort
 * A person’s gender (Male, Female, Prefer Not To Answer): string
 * A person’s salary: int
 * A book’s ISBN: string
 * A book’s price: ushort
 * A book’s shipping weight: float
 * A country’s population: ulong
 * The number of stars in the universe: ulong
 * The number of employees in each of the small or medium businesses: uint
 * 
 * 2.What are the difference between value type and reference type variables? What is
 * boxing and unboxing?
 * Value type variables store the actual value, while reference type variables store the memory location
 * of the value. Boxing is the process of converting value type to reference type, it is done implicitly.
 * Unboxing is the process of converting reference type to value type, it is done explicitly.
 * 
 * 3.What is meant by the terms managed resource and unmanaged resource in .NET
 * 
 * 
 * 4.Whats the purpose of Garbage Collector in .NET?
 * Garbage Collector is the automatic memory manager. Objects are given generation 0 to 2 depending on
 * the live term of the objects.
 */
Console.WriteLine("Program 1");

Console.WriteLine("sbyte -128 to +127");
Console.WriteLine("byte 0 to 255");
Console.WriteLine("short -32,768 to 32,767");
Console.WriteLine("ushort 0 to 65,535");
Console.WriteLine("int -2,147,483,648 to 2,147,483,647");
Console.WriteLine("uint 0 to 4,294,967,295");
Console.WriteLine("long -9,223,372,036,854,775,808 to\r\n9,223,372,036,854,775,807");
Console.WriteLine("ulong 0 to 18,446,744,073,709,551,615");
Console.WriteLine("float ±1.0e-45 to ±3.4e38");
Console.WriteLine("double ±5e-324 to ±1.7e308");
Console.WriteLine("decimal ±1.0 × 10e-28 to ±7.9e28 ");

Console.WriteLine("\nProgram 2");

int centuries = Convert.ToInt32(Console.ReadLine());
ulong nanosec = 3155673600000000000* Convert.ToUInt64(centuries);
Console.WriteLine(centuries + " centuries = " + 100*centuries + " years = " + 36524*centuries + " days = " + 876576*centuries + " hours = " + 52594560*centuries + " minutes" +
    "\n= " + 3155673600*centuries + " seconds = " + 3155673600000* centuries +" milliseconds = "+ 3155673600000000*centuries +
    "\nmicroseconds = " + nanosec + " nanoseconds");