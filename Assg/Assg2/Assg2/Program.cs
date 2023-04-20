/*
When to use String vs. StringBuilder in C# ?
Use StringBuilder if you want to mutate the string a lot. Use string for
smaller text that does not require freqent modification.

What is the base class for all arrays in C#?
It is the Array Class

How do you sort an array in C#?
Use Array.Sort(input an array here)

What property of an array object can be used to get the total number of elements in
an array?
User .Length method

Can you store multiple data types in System.Array?
Yes if you do object [] array.

Whats the difference between the System.Array.CopyTo() and System.Array.Clone()?
CopyTo will copy the source array, Clone will make a new object.
 */

//Q1 Copy Array
using System;
using System.Diagnostics.Tracing;

int[] original = { 1, 4, 5, 1, 3, 6, 8, 8, 9, 5 };
int[] copy = new int[original.Length];

for (int i = 0; i < original.Length; i++)
{
    copy[i] = original[i];
}

foreach (int x in original)
{
    Console.Write(x);
}
Console.WriteLine();

foreach (int y in copy)
{
    Console.Write(y);
}
Console.WriteLine();

//Q2 Managing list
List<string> itemList = new List<string>();

while (true)
{
    Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
    string input2 = Console.ReadLine();
    char operation = input2[0];

    if (input2.Substring(0, input2.Length) == "--")
    {
        itemList.Clear();
    }
    else if (operation == '-')
    {
        itemList.Remove(input2.Substring(2));
    }
    else if (operation == '+')
    {
        itemList.Add(input2.Substring(2));
    }
    else
    {
        break;
    }
}

//Q3 primes
static int[] FindPrimesInRange(int startNum, int endNum)
{
    int[] primes = new int[endNum - startNum];
    int index = 0;
    for (int i = startNum; i <= endNum; i++)
    {
        bool isPrime = true;
        if (i == 0 || i == 1)
        {
            continue;
        }

        for (int j = 2; j <= i / 2; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            primes[index] = i;
            index++;
        }
    }
    return primes;
}

//Q4 rotate
string input = Console.ReadLine();
string[] numbersString = input.Split(" ");
int[] numbers = new int[numbersString.Length];
for (int i = 0; i < numbersString.Length; i++)
{
    numbers[i] = Convert.ToInt32(numbersString[i]);
}

int[] sum = new int[numbers.Length];

int k = Convert.ToInt32(Console.ReadLine());
for (int r = 1; r <= k; r++)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        sum[i] += numbers[(i - r + numbers.Length) % numbers.Length];
    }
}

//Q5 longest sequence
string input3 = Console.ReadLine();
string[] numbersString2 = input.Split(" ");
int[] numbers2 = new int[numbersString2.Length];
for (int i = 0; i < numbersString2.Length; i++)
{
    numbers2[i] = Convert.ToInt32(numbersString2[i]);
}

int currentElement = numbers2[0];
int longestEelement = numbers2[0];
int currentCount = 1;
int longestCount = 1;

for (int i = 1; i < numbers2.Length; i++)
{
    if (numbers2[i] == currentElement)
    {
        currentCount++;
    }
    else
    {
        if (currentCount > longestCount)
        {
            longestEelement = currentElement;
            longestCount = currentCount;
        }
        currentCount = 1;
        currentElement = numbers2[i];
    }
}

for (int j = 0; j < longestCount; j++)
{
    Console.Write(longestEelement + " ");
}

//Q6 most frequent number
string input = Console.ReadLine();
string[] numbersString = input.Split(" ");
int[] numbers = new int[numbersString.Length];
for (int i = 0; i < numbersString.Length; i++)
{
    numbers[i] = Convert.ToInt32(numbersString[i]);
}

Dictionary<int, int> freqMap = new Dictionary<int, int>();
for (int i = 0; i < numbers.Length; i++)
{
    int num = numbers[i];
    if (freqMap.ContainsKey(num))
    {
        freqMap[num] = freqMap[num] + 1;
    }
    else
    {
        freqMap.Add(num, 1);
    }
}

int currentCount = 0;
int mostFreqNum = -1;
foreach (KeyValuePair<int, int> pair in freqMap)
{
    if (currentCount < pair.Value)
    {
        currentCount = pair.Value;
        mostFreqNum = pair.Key;
    }
}

Console.WriteLine(mostFreqNum + " is most frequent, appear " + mostFreqNum + " times");

//Practice String Q1 reverse string
string input = Console.ReadLine();
string reversed = "";
for (int i = 0; i < input.Length; i++)
{
    reversed = input[i] + reversed;
}
Console.WriteLine(reversed);

//Q2 reverse words in sentence
string input = Console.ReadLine();
char[] separators = { '&', '?', '!', '"', ']', '[', '(', ')', '=', ';', ':', '.', ',', '/', ' ' };
string[] wordsString = input.Split(separators);
string reversedSentence = "";

for (int i = wordsString.Length - 1; i >= 0; i--)
{
    reversedSentence = reversedSentence + wordsString[i];
}

//Q3 palindromes
string input = Console.ReadLine();
string[] words = input.Split(' ', ',');
List<string> paliList = new List<string>();

foreach (string word in words)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    string pali = new string(charArray);

    if (word == pali && paliList.Contains(word) == false)
    {
        paliList.Add(word);
    }
}

paliList.Sort();
Console.WriteLine(string.Join(", ", paliList));

//Q4 url
string input = Console.ReadLine();
string[] wordsString = input.Split("://");
string protocol = wordsString[0];
string[] wordsString2 = input.Split("/");
string server = wordsString2[0];
string resource = wordsString2[1];
Console.WriteLine("[protocol] = \"" + protocol + "\"");
Console.WriteLine("[server] = \"" + server + "\"");
Console.WriteLine("[resource] = \"" + resource + "\"");