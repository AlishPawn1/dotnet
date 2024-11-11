using System;
namespace dotnet.src.SessionFour.AppException;

public static class AppTryCatch{
    private static int numOne = 10, numTwo = 0;
    private static string[] nameList = ["mota", "tota", "ect"];

    public static void ZeroDevision(){
        try{
            int result = numOne / numTwo;
            if(result < 0 ) throw new ArithmeticException("Result is less than Zero");
            System.Console.WriteLine($"Division result is {result}");
        } catch(DivideByZeroException e){
            System.Console.WriteLine($"Can not be divide by zero at {e.TargetSite}");
            return;
        } finally{
            System.Console.WriteLine("This always runs");
        }

        System.Console.WriteLine("This is outside try/catch inside ZeroDivision.");
    }

    public static void CheckRange(){
        try{
            nameList[3] = "Alish";
        } catch(IndexOutOfRangeException e){
            System.Console.WriteLine($"What are you even doing? {e.Message}");
        } catch (InvalidOperationException e){
            System.Console.WriteLine($"Failed to execute this operation. {e}");
        } catch (FormatException e){
            System.Console.WriteLine($"Data was not formatted properly. {e}");
        }catch (Exception e){
            System.Console.WriteLine($"something went wrong. {e}");
        }
        System.Console.WriteLine("This is outside try/catch inside checkRange.");
    }
}