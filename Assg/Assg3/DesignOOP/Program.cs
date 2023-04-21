/*
1. Write a program that that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
/Polymorphism/.
2. Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.
3. Use /Encapsulation/ to keep many details private in each class.
4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.
5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.
...

7. Try creating the two classes below, and make a simple program to work with them, as
described below
Create a Color class:
On a computer, colors are typically represented with a red, green, blue, and alpha
(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
A constructor that takes a red, green, blue, and alpha value.
A constructor that takes just red, green, and blue, while alpha defaults to 255
(opaque).
Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
A method to get the grayscale value for the color, which is the average of the red,
green and blue values.
Create a Ball class:
The Ball class should have instance variables for size and color (the Color class you just
created). Let’s also add an instance variable that keeps track of the number of times it
has been thrown.
Create any constructors you feel would be useful.
Create a Pop method, which changes the ball’s size to 0.
Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
popped (has a size of 0).
A method that returns the number of times the ball has been thrown.
 */
using Microsoft.Win32.SafeHandles;

class Program
{
    interface ICourseService
    {
        string[] listOfEnrolled();
    }

    interface IPersonService
    {
        int calculateAge();
        double calculateSalary();
    }

    interface IDepartmentService
    {
        string[] listOfCourses();
    }

    class Person: IPersonService
    {
        public DateTime birthday
        {
            get; set;
        }

        public double salaryPerMonth
        {
            get; set;
        }

        public List<String> addresses
        {
            get; set;
        }

        public int calculateAge()
        {
            return DateTime.Now.Year - birthday.Year;
        }

        public double calculateSalary()
        {
            return 12 * salaryPerMonth;
        }
    }

    class Instructor
    {
        public bool isHeadOfDepartment
        {
            get; set;
        }

        public string belongedDepartment
        {
            get; set; 
        }
    }

    class Course: ICourseService
    {
        public string[] enrolled
        {
            get; set;
        }
        public string[] listOfEnrolled()
        {
            return enrolled;
        }
    }

    class Student
    {
        public double GPA
        {
            get; set;
        }
       
        public string[] takingCourses 
        { 
            get; set; 
        }
    }

    class Department
    {
        public string headOfDepartment
        {
            get; set;
        }
        public int budget
        {
            get; set;
        }

        public string[] allCourses
        {
            get; set;
        }
    }

    public class Color
    {
        public Color(ushort redIn, ushort greenIn, ushort blueIn, ushort alphaIn)
        {
            red = redIn;
            green = greenIn;
            blue = blueIn;
            alpha = alphaIn;
        }

        public Color(ushort redIn, ushort greenIn, ushort blueIn)
        {
            red = redIn;
            green = greenIn;
            blue = blueIn;
            alpha = 255;
        }

        public ushort red
        {
            get; set;
        }

        public ushort green
        {
            get; set;
        }

        public ushort blue
        {
            get; set;
        }

        public ushort alpha
        {
            get; set;
        }

        public ushort grayscale()
        {
            return (ushort)((red + green + blue) / 3);
        }
    }

    public class Ball
    {
        public Ball(Color color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public Color color
        {
            get; set;
        }

        public int size
        {
            get; set;
        }

        public int timesThrow
        {
            get; set;
        }

        public void pop()
        {
            size = 0;
        }

        public void throwBall()
        {
            if(size != 0)
            {
                size += 1;
                timesThrow++;
            }
        }

        public int ballThrown()
        {
            return timesThrow;
        }
    }

    static void Main(string[] args)
    {
        Color myColor = new Color(12, 12, 12, 19);
        Ball myBall = new Ball(myColor, 2);
        myBall.throwBall();
        myBall.throwBall();
        Console.WriteLine(myBall.ballThrown());


        Color myColor2 = new Color(112, 112, 12);
        Ball myBall2 = new Ball(myColor, 2);
        myBall2.throwBall();
        myBall2.throwBall();
        myBall2.throwBall();
        Console.WriteLine(myBall2.ballThrown());
        myBall2.pop();
        myBall2.throwBall();
        Console.WriteLine(myBall2.ballThrown());
    }
}
