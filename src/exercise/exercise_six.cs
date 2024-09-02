using System;
namespace dotnet.src.exercise;
class exercise_six{

    public static void run(){

        System.Console.WriteLine("enter the selling price: ");
        int selling_price = Convert.ToInt16(Console.ReadLine());
        System.Console.WriteLine("enter the cost price: ");
        int cost_price = Convert.ToInt16(Console.ReadLine());

        if(selling_price > cost_price){
            int profit = selling_price - cost_price;
            System.Console.WriteLine("The profit is " + profit);
        }
        else if(selling_price < cost_price){
            int loss = cost_price - selling_price ;
            System.Console.WriteLine("The loss is " + loss);
        }
        else{
            System.Console.WriteLine("its nither profit nor loss");
        }
    }
}