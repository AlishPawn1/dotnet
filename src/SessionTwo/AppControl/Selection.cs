// selection state

using System;

namespace dotnet.src.SessionTwo.Appcontrol;

public static class Selection{
    public static void run(){
        uint number = 20;
        bool isActive = true;
        bool isLoggedIn = true;
        int i = 25, j = 20, k = 30;

        // nested if
        if (isLoggedIn && isActive){
            if (i > j && j > k) System.Console.WriteLine("i is greater");

            if(j > k && j > i){
                System.Console.WriteLine("j is greater");
            }
            else System.Console.WriteLine("k is greater");
        }
        else System.Console.WriteLine("Invalid user");

        // IF else ladder

        if(i == j){
            System.Console.WriteLine("i == j");
        }
        else if (i > j){
            System.Console.WriteLine("i > j");
        }
        else if (i < j){
            System.Console.WriteLine("i < j");
        }
        else{
            System.Console.WriteLine("Invalid number");
        }

        switch(number){
            case 1:
                System.Console.WriteLine("The number is one");
                break;
            case 2:
                System.Console.WriteLine("The number is two");
                break;
            case 3:
                System.Console.WriteLine("The number is three");
                break;
            default:
                System.Console.WriteLine("Unknown number");
                break;
        }
    }
}