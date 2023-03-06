using System;

namespace Main
{
    class YourName
    {
        static void Main(string[] args)
        {
            Console.Write("Hey, user! Please input your name here: ");
            string name = Console.ReadLine() ?? "no name";
            
            Console.WriteLine("Welcome to the system, " + name + "!");
        }
    }
}