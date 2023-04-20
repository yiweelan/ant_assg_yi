
/*
 * 1. What happens when you divide an int variable by 0?
 * You get an exception error
 * 2. What happens when you divide a double variable by 0?
 * Code compile and run without errors
 * 3. What happens when you overflow an int variable, that is, set it to a value beyond its range?
 * It will wrap around and the sign switch
 * 4. What is the difference between x = y++; and x = ++y;?
 * y++ will add y after it's assign to x, ++y is prefix so addition happens before y is assign to x
 * 5. What is the difference between break, continue, and return when used inside a loop statement?
 * break will break out of the closest loop statement, continue will go to the new iteration of loop,
 * and return will stop the execution of function and return a result
 * 6. What are the three parts of a for statement and which of them are required?
 * for statement has the initialize part, condition part, and iterator part. All sections are optional
 * 7. What is the difference between the = and == operators?
 * = operator assign variable, == check if variables are equal
 * 8. Does the following statement compile? for ( ; true; ) ;
 * Yes, it will be an infinite for loop.
 * 9. What does the underscore _ represent in a switch expression?
 * 
 * 10. What interface must an object implement to be enumerated over by using the foreach statement?
 * 
 */

//Q1 fizzbuzz
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("fizz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

/* What will happen if this code executes?
 * int max = 500;
for (byte i = 0; i < max; i++)
{
    Console.WriteLine(i);
}

It will result in infinte loop because byte cannot store over 255, so
i will wrap around back to 0 and never reach 500.
 */

//Q2 star pyramid
for (int i = 0; i < 5; i++)
{
    int numSpace = 4 - i;
    int numStar = 1 + i * 2;
    for (int j = 0; j < numSpace; j++)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < numStar; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//Q3 guess number
int guess = -1;
int correct = 3;

while (guess != correct)
{
    Console.WriteLine("Please guess a number between 1 to 3: ");
    int guessedNumber = int.Parse(Console.ReadLine());

    guess = guessedNumber;
    if (guess > 3 || guess < 1)
    {
        Console.WriteLine("You guess out of range");
    }
    else if (guess == correct)
    {
        Console.WriteLine("You guess correct!");
        break;
    }
    else if (guess < correct)
    {
        Console.WriteLine("You guess to low");
    }
    else
    {
        Console.WriteLine("You guess too high");
    }
}

//Q4 days
int year = Convert.ToInt32(Console.ReadLine());
int month = Convert.ToInt32(Console.ReadLine());
int day = Convert.ToInt32(Console.ReadLine());
DateTime birthDay = new DateTime(year, month, day);
DateTime today = DateTime.Now;
Console.WriteLine((today - birthDay).TotalDays + " days");

//Q5 greetings
DateTime greetingTime = DateTime.Now;
Console.WriteLine("Current hour is " + greetingTime.Hour);
switch (greetingTime.Hour)
{
    case > 0 and <= 5:
        Console.WriteLine("Good Night");
        break;
    case > 5 and <= 12:
        Console.WriteLine("Good Morning");
        break;
    case > 12 and <= 18:
        Console.WriteLine("Good Afternoon");
        break;
    case > 18 and <= 20:
        Console.WriteLine("Good Evening");
        break;
    default:
        Console.WriteLine("Good Night");
        break;
}

//Q6 count to 24
for(int x = 1; x <= 4; x++)
{
    for(int y = 0; y <= 24; y += x)
    {
        Console.Write(y);
        if(y != 24)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
