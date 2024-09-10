namespace dotnet.src.SessionThree.AppClass{
    using System;
    using InnerSpace;

    public static class RunAppClass{
        public static void RunMusic(){
            Music nepali = new();
            Music english = new();

            nepali.Artist = "Rahul Rai";
            nepali.Genre = "Rock";
            nepali.Title = "huna due jay huna cha";

            nepali.showInfo();
            System.Console.WriteLine();
            english.showInfo();

            Movie movies = new();
            Movie school = new();
        }

        public static void RunUser(){
            User user = new("ALish", 21, "Male");

            // user.name = "alish";
            // user.age = 21;
            // user.gender = "male";
        }
    }
}