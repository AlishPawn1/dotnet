using System;
namespace dotnet.src.exercise;

public class exercise_seven{
    public static void run(){
        int[] a = {1,2,3,4,5};

        foreach (int number in a){
            System.Console.WriteLine("the multiple of " + number + " is");

            for(int i=1 ; i <= 5 ; i++){
                System.Console.WriteLine(number * i + " ");
            }
            System.Console.WriteLine();
        }
    }
}