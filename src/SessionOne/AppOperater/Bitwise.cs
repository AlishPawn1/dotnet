using System;

namespace dotnet.src.SessionOne.AppOperater
{
    public static class Bitwise
    {
        public static void run()
        {
            int primary = 60; // 111100
            int secondary = 13; // 1101

            Console.WriteLine($"{primary} = {Convert.ToString(primary, 2)}");
            Console.WriteLine($"{secondary} = {Convert.ToString(secondary, 2)}");

            int andResult = primary & secondary; // should be 12
            Console.WriteLine($"\n{primary} & {secondary} = {andResult} : {Convert.ToString(andResult, 2)}");

            int orResult = primary | secondary;
            Console.WriteLine($"\n{primary} | {secondary} = {orResult} : {Convert.ToString(orResult, 2)}");

            int xorResult = primary ^ secondary;
            Console.WriteLine($"\n{primary} ^ {secondary} = {xorResult} : {Convert.ToString(xorResult, 2)}");

            int onesComplementResult = ~primary; // -(x+1)
            Console.WriteLine($"\n~{primary} = {onesComplementResult} : {Convert.ToString(onesComplementResult, 2)}");

            int leftShiftResult = primary << 2;
            Console.WriteLine($"\n{primary} << = {leftShiftResult} : {Convert.ToString(leftShiftResult, 2)}");

            int rightShiftResult = primary >> 2;
            Console.WriteLine($"\n{primary} >> = {rightShiftResult} : {Convert.ToString(rightShiftResult, 2)}");

        }
    }
}
