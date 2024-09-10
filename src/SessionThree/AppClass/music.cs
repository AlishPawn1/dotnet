namespace dotnet.src.SessionThree.AppClass{
    using System;

    public class Music{
        public string? Title {get; set;}
        public string? Genre {get; set;}
        public string? Artist {get; set;}

        // defult (nullary) constructor
        public Music(){}

        // method to get the album information
        public void showInfo(){
            System.Console.WriteLine("Music Information:");
            System.Console.WriteLine(
                $"Title: {Title?.Trim() ?? "N/A"} | Type: {Title?.GetType().Name ?? "UNknown"}\n" +
                $"Genre: {Genre?.Trim() ?? "N/A"} | Type: {Genre?.GetType().Name ?? "UNknown"}\n" +
                $"Artist: {Artist?.Trim() ?? "N/A"} | Type: {Artist?.GetType().Name ?? "UNknown"}"
            );
        }
    }

    namespace InnerSpace{
        public class Movie{}
        public class School{}
    }

}