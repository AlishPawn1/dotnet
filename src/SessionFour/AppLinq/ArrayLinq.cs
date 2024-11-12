using System;
using System.Linq;
namespace dotnet.src.SessionFour.AppLinq;

// object collection, ADD .Net database, XML document, SQL database and other

public class ArrayLinq{
    private static int[] numberList = [1,2,3,4,5,6,7,8,9,10];

    private static string[] names = ["Alice", "Charl", "Charlie", "David", "Eve", "Frank", "Grace", "George", "Evan", "Unknown"];

    public static void CheckEven(){
        // from 'variable' in 'data_source' where ' condition ' orderby 'variable'
        var evenNumbers = from num in numberList
            where num % 2 == 0
            orderby num descending
            select num;

        foreach (int num in evenNumbers) Console.WriteLine($"{num}");
        System.Console.WriteLine();
    }

    public static void GroupName(){
        var groupedNames = from name in names 
        group name by name[0] into nameGroup
        orderby nameGroup.Key ascending 
        select nameGroup;

        // var startWithC = from name in names 
        // where key by c
        // group name by name[0] into nameGroup
        // orderby nameGroup.Key ascending 
        // select nameGroup;

        var startWithC = from name in names
        where name.StartsWith('C')
        select name;

        // foreach (var group in groupedNames){
        //     System.Console.WriteLine($"Name starting with '{group.Key}':");
        //     foreach (string name in group) System.Console.WriteLine($" >> {name}");
        // }

        foreach(var name in startWithC){
            System.Console.WriteLine($"Name starting with c: {name}");
        }

    }
}