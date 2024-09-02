using System;
using System.Text;

namespace dotnet.src.SessionTwo.AppDefault;

public class Precedence{

    // statement are instructions that execute sequentially in a function
    public static void run(){
        // declaration statement
        // const int age = 16;
        // bool hasBrain = true;
        // string name = 'Myself';

        //  * has higher precedence
        System.Console.WriteLine(1 + 2 * 3); //ans 7

        // binary operators are left associative (except for =, => ,??)
        System.Console.WriteLine(8 / 4 / 2); // ans 1

        // right associative x = y = 3;

        {
            // expression statements are expresssions that are also valid statement
            // assignment expression, 
            // method call expression, 
            // object instantion expression

            string address;
            int x = 0, y = 0;

            x += 1;

            // assignment expression, 
            address = "USA";
            // method call expression, 
            System.Console.WriteLine(address);
            // y++;
            ++y;
            System.Console.WriteLine(y);

            y = Math.Max(x, 5);

            // object instantion expression
            new StringBuilder();

        }
    }
}