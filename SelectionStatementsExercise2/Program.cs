using static System.Collections.Specialized.BitVector32;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is very important!");
                    break;
                case "science":
                    Console.WriteLine("Science! Wow that's fun!");
                    break;
                case "i.t":
                    Console.WriteLine("I.T I like it too. but it's very challenging!");
                    break;
                case "english":
                    Console.WriteLine("English is very fun mostly for the idioms. lol!");
                    break;
                case "history":
                    Console.WriteLine("History is a very interesting subject. I like to draw event picture in my mind!");
                    break;
                default:
                    Console.WriteLine("Amazing choice! what do you like about it?");
                    break;
            }
        }
    }
}