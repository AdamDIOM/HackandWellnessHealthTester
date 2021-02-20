using System;

namespace HackandWellnessPartyTester
{
    class MainClass
    {
        public delegate void GoingOut();
        public static void Main(string[] args)
        {
            Console.WriteLine("Are you looking to go out partying?");
            //bool goingOut = true;
            Console.WriteLine("yes or no");
            GoingOut MethodToUse;
            MethodToUse = (Console.ReadLine().ToUpper() == "YES") ? new GoingOut(Out) : new GoingOut(In);
            MethodToUse();
        }
        public static void Out()
        {
            Console.WriteLine("What country are you in?");
            string output = (Console.ReadLine().ToUpper() == "ISLE OF MAN") ? "Have a great time!" : "Are you sure thats a healthy decision?";
            Console.WriteLine(output);
        }
        public static void In()
        {
            Console.WriteLine("Well done for staying healthy!");
        }
    }
}
