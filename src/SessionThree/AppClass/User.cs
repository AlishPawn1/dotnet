namespace dotnet.src.SessionThree.AppClass{
    using System;

    public class User{
        // Field
        private uint? age;
        private readonly string? name;
        private readonly string? gender;

        // Properties
        public uint? Age{
            get {return this.age;}
            // set { this.age = value;}
            set {
                if (value < 18) throw new ArithmeticException("Invalid age");
                this.age = value;
            }
        }

        public string? Name{get; set;}
        public string? Gender{get; set;}


        // Invoked once ont the first instance
        static User(){
            System.Console.WriteLine("This is inside User static constructor");
        }

        public User(string name, uint age, string gender){
            this.age = age ;
            this.name = name;
            this.gender = gender ?? "N/A";
        }

        public User(){
            System.Console.WriteLine("This is User constructor without paramenters");
        }

        public void UserNameIs(){
            System.Console.WriteLine($"User name is {this.name}");
        }

        // overloading method (same name but different signature)
        public void UserNameIs(string name){
            System.Console.WriteLine($"User name is {name} and it is method overloaded");
        }

        public void UserDetail(){
            System.Console.WriteLine("User details: ");
            System.Console.WriteLine($"Name : {this.name} \nGender : {this.gender} \nAge : {this.age}");
        }

        ~User(){
            System.Console.WriteLine("User class is destoryed");
        }
    }    
}