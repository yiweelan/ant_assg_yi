/*
1.What are the six combinations of access modifier keywords and what do they do? 
The six combinations are public, prviate, protected, internal, protected internal, and private protected.
Public let you access it anywhere, private is only accessible within the same class, protected is
accessible in same class and derived class, internal is accessible in the same assembly, internal protected
is accessible in same assembly or derived class, private protected is accessible in same class or derived
class in same assembly.
2.What is the difference between the static, const, and readonly keywords when applied to a type member?
Readonly allows you to initialize at runtime or compile time while const has to be initialize at compile time.
Const and readonly cannot be modify once initialize, static can.
3. What does a constructor do?
Constructor are function that runs to create an instance of an object from a class.
4. Why is the partial keyword useful?
Partial keyword allows you to chop the functionality of the class, method, interface or structure into multiple
files and makes it possible to have multiple person work on a class at the same time.
5. What is a tuple?
Tuple is a data structure that let you group sequence of elements of different data type.
6. What does the C# record keyword do?
Recrod keyword is another keyword that allow you to create object similar to class and struct. It is
best to use when you need objects that are immutable or data model that depend on value equality.
7. What does overloading and overriding mean?
Overloading mean having another function with same function name but with different signature.
Overriding mean having the child class override a function in the parent class, the function need
to have virtual or abstract keyword to be overriden.
8. What is the difference between a field and a property?
A field is variable that defined inside the class; a property is what provide an level of abstraction
for accessing and modifying the field.
9. How do you make a method parameter optional?
You can make a method parameter optional by giving it a default value.
10. What is an interface and how is it different from abstract class?
Interface is like a constract which the derived class has to implement, and it cannot have
constructor and fields. Comparing to abstract class, interface support multiple inheritance.
However, an interface cannot have concrete members, unlike abstract class which can have abstract
and concrete members.
11. What accessibility level are members of an interface?
By defualt, the accessibility level of members are public.
12. True/False. Polymorphism allows derived classes to provide different implementations of the same method.
True
13. True/False. The override keyword is used to indicate that a method in a derived class is 
providing its own implementation of a method.
True
14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
True
15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
False
16.True/False. Normal (non-abstract) methods can be used in an abstract class. 
True
17. True/False. Derived classes can override methods that were virtual in the base class. 
True
18. True/False. Derived classes can override methods that were abstract in the base class. 
True
19. True/False. In a derived class, you can override a method that was neither virtual non abstract in the
base class.
False
20. True/False. A class that implements an interface does not have to provide an implementation for 
all of the members of the interface.
False
21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
True
22. True/False. A class can have more than one base class.
False
23. True/False. A class can implement more than one interface.
True
 */
//Q1 Reverse
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers();
        Reverse(ref numbers);
        PrintNumbers(numbers);
    }

    static int[] GenerateNumbers()
    {
        return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }

    static void PrintNumbers(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write(num + ",");
        }
        Console.WriteLine();
    }

    static void Reverse(ref int[] numbers)
    {
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int tem = numbers[i];
            numbers[i] = numbers[numbers.Length - i - 1];
            numbers[numbers.Length - i - 1] = tem;
        }
    }
}