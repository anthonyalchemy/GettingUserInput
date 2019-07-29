using System;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: " ); //Console.Write isnt taking new line for when user inputs the name 
            string name = Console.ReadLine(); //will pause program to wait for user input also setting variable name to user input 
            Console.Write("Enter your Age: ");
            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " you are " + age );



            Console.ReadLine();
        }
    }
}
