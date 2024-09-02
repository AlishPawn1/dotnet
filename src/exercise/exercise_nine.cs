using System;
namespace dotnet.src.exercise;

public class exercise_nine{
    public static void run(){
        int[] a = {1,2,3,4,5};
        fun(a);
        Console.ReadLine();
    }
    static void fun(params int[] b){
        for(int i=0; i<b.Length; i++){
            b[i] = b[i] * 5;
            System.Console.WriteLine(b[i] + "");
        }
    }
}