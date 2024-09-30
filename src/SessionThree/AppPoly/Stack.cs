using System;
namespace dotnet.src.SessionThree.AppPoly;

public class CustomStack<T>{
    private int top;
    private T[] element;

    public string stackMessage = "This is parent stack";

    public CustomStack(int capacity){
        element = new T[capacity];
        top = -1;
    }

    public void Push(T item){
        if(top == element.Length - 1) throw new Exception("Stack overflow");
        element[++top] = item;
    }

    public T Pop(){
        if(top == -1) throw new Exception("Stack Underflow");
        return element[top--];
    }

    public void ShowStack(){
        for(int i = 0; i <= top; i++){
            T item = element[i];
            Console.WriteLine(item);
            // Console.WriteLine(element[i]);
        }
    }
}


public class AnotherStack : CustomStack<int>{
    public new string stackMessage = "This is another stack";

    // calling parent constructor
    public AnotherStack(int capacity) : base(capacity){}

    public void ShowBase(){
        // using the base keyword
        Console.WriteLine(base.stackMessage);
        Console.WriteLine(stackMessage);

    }
}