using System;
namespace dotnet.src.SessionThree.AppPoly;

using System.Collections.Generic;
using dotnet.src.Constant;

public  class RunPoly{
    public static void runOperatorOverloading(){
        ComplexNumber c1 = new(2, 3);
        ComplexNumber c2 = new(4, 5);

        // result 6, 8
        //  6 + 8i
        ComplexNumber result = c1 + c2;
        Console.WriteLine(result.ToString());

        Increment inc = new(5);
        Console.WriteLine($"This is imcremented value {inc++}");
    }

    public static void runCasting(){
        // Upcasting
        User admin = new Admin();
        User guest = new Guest();
        
        // downcasting parent to child
        Admin adminUser = (Admin)admin;
        if(adminUser != null){
            adminUser.Greet();
        }

        Guest? guestUser = guest as Guest;
         if(guestUser != null){
            guestUser.Greet();
        }
    }

    public static void runStack(){
        object p = 's';
        int x = 9;
        object y = x; // Boxing the int x into object y
        int z = (int)y; // Unboxing the object y into int z

        CustomStack<int> myStack = new(4);
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(2);
        myStack.Push(2);
        myStack.Pop();
        myStack.ShowStack();

        // Getting the type of an object
        Console.WriteLine(myStack.GetType());
        Console.WriteLine(x.GetType());
        Console.WriteLine(y.GetType());
        Console.WriteLine(z.GetType());
        Console.WriteLine(p.GetType());
        Type stackType = typeof(CustomStack<string>);
        Console.WriteLine($"Type of CustomStack = {stackType}");
         
        Console.WriteLine($"User role = {AppEnum.UserRole.admin} at position {(int)AppEnum.UserRole.admin}");
        Console.WriteLine($"User role = {AppEnum.UserRole.hr} at position {(int)AppEnum.UserRole.hr}");

        AnotherStack another = new(5);
        another.ShowBase();
    }

    public static void runDictionary(){
        // creating a dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // adding key- value pairs to the dictionary
        ages["John"] = 30;
        ages["Alex"] = 25;
        ages["Tom"] = 45;

        // Accessing value by key
        Console.WriteLine($"John's age is {ages["John"]}");
        Console.WriteLine($"Alex's age is {ages["Alex"]}");

        // iterating over the dictionary and printing key-value pairs
        foreach(KeyValuePair<string, int> entry in ages){
            Console.WriteLine($"Key = {entry.Key}, Value = {entry.Value}");
            Console.WriteLine($"{entry.Key} is {entry.Value} years old");
        }

        // checking if a key exists
        if(ages.TryGetValue("Tom", out int value)) Console.WriteLine($"Tom's age: {value}");
    }

    public static void runQueue(){
        // creating a queue of integers
        Queue<int> queue = new Queue<int>();

        // Enqueue element
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // peek at the front element without removing it
        Console.WriteLine($"Front element: {queue.Peek()}");

        // Dequeue element
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued element: {queue.Dequeue()}");

        // check the number of element left
        Console.WriteLine($"Number of elements in queue: {queue.Count}");

        // iterate over the remaining element
        foreach(int item in queue) Console.WriteLine($"Item: {item}");
    }
}
