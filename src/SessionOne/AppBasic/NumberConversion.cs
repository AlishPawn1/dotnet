using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet.src.SessionOne.AppBasic
{
    public class NumberConversion
    {
        public static void Run()
        {
            int numOne = 10;
            int numFour = 0;
            decimal numTwo = 20.11m;
            long numThree = numOne;
            float numFive = (float)numTwo;
            int numSix = 0;
            Type intType = typeof(int);
            if (numTwo >= short.MinValue && numTwo <= short.MaxValue)
            {
                numFour = (short)numTwo;
                Console.WriteLine("successfully type casted numTwo into short");
            }
            if (numFive >= int.MinValue && numTwo <= int.MaxValue)
            {
                numSix = (int)numFive;
            }

            Console.WriteLine("\nResult:");
            Console.WriteLine(
                $"numOne>{numOne.GetType()} > {numOne}\n" +
                $"numTwo>{numTwo.GetType()} > {numTwo}\n" +
                $"numThree>{numThree.GetType()} > {numThree}\n" +
                $"numFour>{numFour.GetType()} > {numFour}\n" +
                $"numFive>{numFive.GetType()}> {numFive}\n" +
                $"numSix>{numSix.GetType()}> {numSix}\n" +
                $"Int type information >> {intType}"
            );
        }
    }
}
