using System;

namespace dotnet.src.SessionOne.AppOperater
{
    public static class ElvisPresley
    {
        public static void run()
        {
            User user = new User();
            user.Name = "Test";

            Address address = new Address();
            address.street = "demo";

            string userName = user.Name;
            string seperateStreet = address.street;
            string userStreet = user?.Address?.street ?? "Defult Street";

            Console.WriteLine($"User name is {userName}");
            Console.WriteLine($"Separate streer  is {seperateStreet}");

            if (userStreet is not null)
            {
                Console.WriteLine($"User street is {userStreet}");
            }
            else
            {
                Console.WriteLine("user has no street");
            }
        }
    }
}   
