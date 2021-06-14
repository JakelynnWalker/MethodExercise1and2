using System;

namespace MethodExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is yout favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is favorite dog breed?");
            string dogName = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"There was a person named {name} and {name} favorite was color {color}. One day {name} was walking and {name} seen a sign and it said {dogName}'s for sale and that is {name} favorite dog breed so {name} went in and bought one and named it Buster. While they were on the way home one of {name} buddies called and asked if {name} wanted to go see {band} perform and {name} was excited. {name} got back from the concert and {name} and buster went to sleep.");

            Console.WriteLine("Give me a number to add");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please put another number");
            int number2 = int.Parse(Console.ReadLine());

            int math = Math(number1, number2);
            Console.WriteLine($"{math}");


        }

        public static int Math(int number1, int number2)
        {

            return number1 + number2;
        }

        public static int Multiply(int x, int y);

          
        


      

        


            
        
        
    }
}
