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
            // User user = new();
            user.UserNameIs();
            // user.name("ajaya");
            user.UserNameIs("aajay");
            user.UserDetail();

            // user.name = "alish";
            // user.age = 21;
            // user.gender = "male";
        }

        public static void RunStudentIndexer(){
            StudentIndexer std = new(3);
            // std.getLength(3);
            std[0] = "alish";
            std[1] = "hari";
            std[2] = "sari";
            // std[3] ={"alish", "hari", "sari"}

            // for(int i = 0; i < std.nameList.Length; i++ ){
            //     System.Console.WriteLine(std[i]);
            // }
            
            for(int i = 0; i < std.getLength(); i++ ){
                System.Console.WriteLine(std[i]);
            }
        }

        // PointStruct
        public static void RunPointStruct(){
            PointStruct point = new(5, -1);
            System.Console.WriteLine(point.X);
            System.Console.WriteLine(point.Y);
        }
    }
}