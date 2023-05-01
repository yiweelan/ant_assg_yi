using System;
using System.Collections.Generic;

/*
Test your Knowledge
1. Describe the problem generics address.
Generics allows you to define a class or method that can work wth any data type. This addresses
the problem of a need to create multiple of the same function in order to work with all
different types like an add numbers method.
2. How would you create a list of strings, using the generic List class?
List<string> listOfString = new List<string>();
3. How many generic type parameters does the Dictionary class have?
Dictionary class has 2 parameters, a key and a value.
4. True/False. When a generic class has multiple type parameters, they must all match.
False
5. What method is used to add items to a List object?
Add()
6. Name two methods that cause items to be removed from a List.
Remove() for removing specific element of first occurance, RemoveAt() for removing from 
specific index.
7. How do you indicate that a class has a generic type parameter?
Use the <T> after the Name
8. True/False. Generic classes can only have one generic type parameter.
False
9. True/False. Generic type constraints limit what can be used for the generic type.
True
10. True/False. Constraints let you use the methods of the thing you are constraining to.
True
 */

/*
1 Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
 */

using System.Collections;

class MyStack<T>
{
    private List<T> stack = new List<T>();

    private int count = 0;

    public int Count()
    {
        return stack.Count();
    }

    public T Pop()
    {
        T popped = stack[Count() - 1];
        stack.RemoveAt(Count() - 1);
        return popped;
    }

    public void Push(T item)
    {
        stack.Add(item);
    }

    public void stackPrint()
    {
        for (int i = 0; i < stack.Count(); i++)
        {
            Console.WriteLine(stack[i]);
        }
    }
}

/*
2 Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
 */

class MyList<T>
{
    ArrayList list = new ArrayList();

    public void Add(T item)
    {
        list.Add(item);
    }

    public T Remove(int index)
    {
        T removed = (T)list[index];
        list.RemoveAt(index);
        return removed;
    }

    public bool Contains(T item)
    {
        return list.Contains(item);
    }

    public void Clear()
    {
        list.Clear();
    }

    public void InsertAt(T element, int index)
    {
        list.Insert(index, element);
    }

    public void DeleteAt(int index)
    {
        list.RemoveAt(index);
    }

    public T Find(int index)
    {
        return (T)list[index];
    }
}

/*
3 Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc
 */

interface IRepository<T>
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}

interface IEntity
{
    public int Id { get; set; }
}

class GenericRepository<T> : IRepository<T> where T : class, IEntity
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }
    public void Remove(T item)
    {
        list.Remove(item);
    }
    public void Save()
    {

    }
    public IEnumerable<T> GetAll()
    {
        return list.AsEnumerable();
    }
    public T GetById(int id)
    {
        for(int i = 0; i < list.Count; i++)
        {
            if (list[i].Id == id)
            {
                return list[i];
            }
        }

        return null;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        MyStack<int> testStack = new MyStack<int>();
        testStack.Push(1);
        testStack.Push(2);
        testStack.Push(5);
        Console.WriteLine("count is " + testStack.Count());
        testStack.Pop();
        Console.WriteLine("count is " + testStack.Count());
        
        MyList<int> testList = new MyList<int>();
        testList.Add(1);
        testList.InsertAt(7, 1);
        Console.WriteLine(testList.Contains(7));
    }
}